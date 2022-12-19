namespace MVWDictionary
{
    [System.Serializable]
    public class DictionarySerializing
    {
        public string[] Keys { get; set; }
        public string[] Values { get; set; }

        public System.Collections.Generic.Dictionary<string, string> GetThisDictionary()
        {
            System.Collections.Generic.Dictionary<string, string> ResDic = new
                System.Collections.Generic.Dictionary<string, string>();
            int lenght = Keys.Length;
            for (int i = 0; i < lenght; i++)
            {
                ResDic.Add(Keys[i], Values[i]);
            }
            return ResDic;
        }
    }
}
