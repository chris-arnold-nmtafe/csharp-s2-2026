using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7 {
    internal class TextDataStore : IDataStore {
        public string FilePath { get; private set; }
        public TextDataStore(string file) {
            FilePath = file;
        }

        public void save(string key, object value) {
        }
        public object read(string key) { return null; }
    }
}
