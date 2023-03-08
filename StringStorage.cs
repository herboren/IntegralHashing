using System;
using System.Collections.Generic;

namespace IntegralHashing
{
    public class StringStorage
    {
        // Store imported hashes        
        public Dictionary<string, string> keyVal {get; set;}

        public Dictionary<string, string> matched { get; set; }

        public Dictionary<string, string> unique { get; set; }

        // Stores hashed files for comparing to list
        public List<string> hashed = new List<string>();

        // Stores files paths obtained from directory
        public List<string> absolute = new List<string>();

        // Stores the directory 
        public string directory { get; set; }

        
    }
}