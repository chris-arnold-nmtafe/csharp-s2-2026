using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7 {
    interface IDataStore {
        void save(string key, object value);
        object read(string key);
    }
}
