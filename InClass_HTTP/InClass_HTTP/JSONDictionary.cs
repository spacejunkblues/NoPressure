using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMadeJSON
{
    class JSONDictionary
    {
        public Dictionary<string, string> dictString;
        public Dictionary<string, JSONDictionary> dictDictionary;
        public string stringForm;



        public JSONDictionary()
        {
            dictString = new Dictionary<string, string>();
            dictDictionary = new Dictionary<string, JSONDictionary>();
        }
        public JSONDictionary(string rawinput)
        {
            dictString = new Dictionary<string, string>();
            dictDictionary = new Dictionary<string, JSONDictionary>();
            stringForm = rawinput;
        }

        /* public string GetValue(string key)
         {
             if (dictString.ContainsKey(key))
                 return dictString[key];
             else if(dictDictionary.ContainsKey(key))
             {
                 GetValue(key, true);
             }
             else
                 throw new Exception();
         }*/
        public JSONDictionary GetValue(string key, bool JSON)
        {
            if (dictDictionary.ContainsKey(key))
            {
                return dictDictionary[key];
            }
            else if (dictString.ContainsKey(key))
                return new JSONDictionary(dictString[key]);
            else
                throw new Exception();

        }

        public void SetValue(string key, string value)
        {
            dictString[key] = value;
        }
        public void SetValue(string key, JSONDictionary value)
        {
            dictDictionary[key] = value;
        }

        /*public string this[string key]
        {
            get => GetValue(key);
            set => SetValue(key, value);
        }*/
        public JSONDictionary this[string key]
        {
            get => GetValue(key, true);
            set => SetValue(key, value);
        }

        public override string ToString()
        {
            return stringForm;
        }


        static public JSONDictionary JSONToDictionary(string s)
        {
            JSONDictionary dic = new JSONDictionary(s);

            bool keyFound = false;
            bool valueFound = false;
            bool subDicFound = false;
            bool valueIsString = false;
            bool valueIsDict = false;
            int startIndex = 2;
            string key = "";
            string value = "";
            int numOfSubStrings = 0;

            //first time through
            //find key start
            keyFound = true;

            //start at 1, to skip first "{"
            //all other "{" are considered sub dictionaries
            for (int i = startIndex; i < s.Length; i++)
            {

                //search for key or value
                if (keyFound == false && valueFound == false)
                {
                    if (s[i] == ',')
                        keyFound = true;
                    else if (s[i] == ':')
                        valueFound = true;

                    if (keyFound || valueFound)
                    {
                        //advance search to start of actual key or value
                        i += 1;
                        valueIsString = false;
                        valueIsDict = false;
                        if (s[i] == '\"')//skip any quote
                        {
                            i++;
                            valueIsString = true;
                        }
                        if (s[i] == '{') //value is a dictionary
                        {
                            valueIsDict = true;
                            numOfSubStrings = 0;
                        }
                        startIndex = i;
                    }

                }

                if (valueIsDict && s[i] == '{')
                    numOfSubStrings++;
                else if (valueIsDict && s[i] == '}')
                    numOfSubStrings--;

                //end of key
                if (keyFound && s[i] == '\"')
                {
                    key = s.Substring(startIndex, i - startIndex);
                    keyFound = false;
                }

                //**** need to account for double }   exmample if value looks like this "{key: {}}"
                //find value end     if it's a string, look for a "    if it's not a string, look for a ,                                               value is a dictionary, look for }
                if (valueFound && ((s[i] == '\"' && valueIsString) || (s[i] == ',' && valueIsString == false && valueIsDict == false) || (s[i] == '}' && valueIsString == false && numOfSubStrings <= 0)))
                {
                    if (valueIsDict)
                        value = s.Substring(startIndex, i - startIndex + 1);
                    else
                        value = s.Substring(startIndex, i - startIndex);
                    valueFound = false;

                    if (valueIsString == false)
                    {
                        i--; //this will allow the parser to relook at the comma to find the key

                        if (valueIsDict)
                        {
                            //can I make the value a dictionary or a string???? maybe make it a dictionary? Sure can!
                            dic.SetValue(key, JSONToDictionary(value));
                        }
                    }

                    //save the key and value to the dictionary
                    dic.SetValue(key, value);
                    //dic[key] = value;

                }


                //check for sub dict

                //parse to end of sub dict string

                //convert sub string to a dictionary

            }

            //return dictionary
            return dic;
        }
    }
}
