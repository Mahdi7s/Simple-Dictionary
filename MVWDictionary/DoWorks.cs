namespace MVWDictionary
{
    public class DoWorks
    {
        private string m_GlossFolder = string.Empty;
        private string m_SearchesFilePath = string.Empty;
        private DictionarySerializing[] m_Dictionaries = null;
        //------------------------------------------------------
        public DoWorks()
        {
            m_GlossFolder = System.Windows.Forms.Application.StartupPath + @"\Gloss\";
            m_SearchesFilePath = System.Windows.Forms.Application.StartupPath + @"\Searches.xml";
        }

        private System.IO.FileStream[] GetGlossFiles()
        {
            System.Collections.Generic.List<System.IO.FileStream> ResStreams = new
                System.Collections.Generic.List<System.IO.FileStream>();
            string[] GlossPath = System.IO.Directory.GetFiles(m_GlossFolder, "*.MVWD", System.IO.SearchOption.TopDirectoryOnly);
            foreach (string s in GlossPath)
            {
                System.IO.FileStream stream = new System.IO.FileStream(s,System.IO.FileMode.Open,System.IO.FileAccess.Read);
                ResStreams.Add(stream);
            }
            if (ResStreams.Count <= 0) return null;
            return ResStreams.ToArray();
        }

        public System.Collections.Generic.Dictionary<string, string>[]
            GetDictionaries()
        {
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>
                ResDics = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>();
            System.IO.FileStream[] GlossStreams = this.GetGlossFiles();
            if (GlossStreams == null) return null;
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter Serializer = new
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            System.Collections.Generic.List<DictionarySerializing> dics = new
                System.Collections.Generic.List<DictionarySerializing>();
            foreach (System.IO.FileStream gs in GlossStreams)
            {
                DictionarySerializing NewDic = (DictionarySerializing)Serializer.Deserialize(gs);
                gs.Close();
                ResDics.Add(NewDic.GetThisDictionary());
                dics.Add(NewDic);
            }
            m_Dictionaries = dics.ToArray();
            return ResDics.ToArray();
        }

        public void AddToGloss_SqlDb(string ServerName, string DatabaseName,
            string TableName, string GlossName)
        {
            ConvertDatabase converter = new ConvertDatabase();
            DictionarySerializing NewGloss = 
                converter.GetDictionaryFromSqlDatabase(ServerName, DatabaseName, TableName);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter =
                new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            string path = m_GlossFolder + GlossName + ".MVWD";
            System.IO.FileStream stream = new 
                System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            formatter.Serialize(stream, NewGloss);
            stream.Close();
        }

        public void AddToGloss_AccessDb(string AccessProvider,
            string AccessDbPath,string TableName,string GlossName)
        {
            ConvertDatabase converter = new ConvertDatabase();
            DictionarySerializing NewGloss =
                converter.GetDictionaryFromAccessDatabase(AccessProvider, AccessDbPath, TableName);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter =
                new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            string path = m_GlossFolder + GlossName + ".MVWD";
            System.IO.FileStream stream =
                new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            formatter.Serialize(stream, NewGloss);
            stream.Close();
        }

        public string[] Search(System.Collections.Generic.Dictionary<string, string>[] Dictionaries,string SearchString)
        {
            System.Collections.Generic.List<string> ResStrings =
                new System.Collections.Generic.List<string>();
            try
            {
                foreach (System.Collections.Generic.Dictionary<string, string> d in Dictionaries)
                {
                    string res = d[SearchString];
                    ResStrings.Add(res);
                }
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            { return new string[] { "word not found." }; }
            return ResStrings.ToArray();
        }

        public void SaveSearchedWords(string[] SearchedWords)
        {
            if (SearchedWords.Length > 20)
            {
                int NewWordsStartIndex = SearchedWords.Length - 20;
                int NewWordsLenght = 40 - SearchedWords.Length;
                string[] NewWords = new string[NewWordsLenght];
                for (int i = 0; i < NewWordsLenght; i++)
                {
                    NewWords[i] = SearchedWords[i + NewWordsStartIndex];
                }
                SearchedWords = NewWords;
            }
            System.Xml.Serialization.XmlSerializer serializer = new
                System.Xml.Serialization.XmlSerializer(typeof(string[]));
            if(System.IO.File.Exists(m_SearchesFilePath))
                System.IO.File.Delete(m_SearchesFilePath);
            System.IO.FileStream stream = new 
                System.IO.FileStream(m_SearchesFilePath,System.IO.FileMode.Create,System.IO.FileAccess.Write);
            serializer.Serialize(stream, SearchedWords);
            stream.Close();
        }

        public string[] GetSearchedWords()
        {
            if (System.IO.File.Exists(m_SearchesFilePath))
            {
                System.IO.FileStream stream = new 
                    System.IO.FileStream(m_SearchesFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                System.Xml.Serialization.XmlSerializer deserializer = new 
                    System.Xml.Serialization.XmlSerializer(typeof(string[]));
                string[] SearchedWords = (string[])deserializer.Deserialize(stream);
                stream.Close();
                return SearchedWords;
            }
            return null;
        }

        private bool CheckSpell(string key, string search)
        {
            int index = 0;
            int? last = null;
            foreach (char c in key)
            {

            }
            return false;
        }

        public string[] SpellingAlternatives(string SearchString, out string[] keys)
        {
            System.Collections.Generic.List<string> ResStrs = new
                System.Collections.Generic.List<string>();
            System.Collections.Generic.List<string> LKeys = new
                System.Collections.Generic.List<string>();
            foreach (DictionarySerializing d in m_Dictionaries)
            {
                int index = 0;
                foreach (string ks in d.Keys)
                {
                    if(this.CheckSpell(ks,SearchString))
                    {
                        LKeys.Add(ks);
                        ResStrs.Add(d.Values[index]);
                    }
                    ++index;
                }
            }
            keys = LKeys.ToArray();
            if (ResStrs.Count <= 0) return null;
            return ResStrs.ToArray();
        }

        public string AlternativesSearchAllString(string SearchString)
        {
            string[] keys, values;
            values = this.SpellingAlternatives(SearchString, out keys);
            if (values == null) return null;
            string ResString = string.Empty;
            for (int i = 0; i < keys.Length; i++)
            {
                ResString += keys[i] + " = " + values[i] + ", ";
            }
            return ResString;
        }
    }
}
