using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SQLite;

namespace eChrome.Models
{
    public class Downloads
    {
        public long id { get; set; }

        [Ignore] public string guid { get; set; }

        public string current_path { get; set; }

        public string path => Path.GetFileNameWithoutExtension(current_path);

       
        public string target_path { get; set; }

        public string target => Path.GetFileNameWithoutExtension(target_path);

        public long start_time { get; set; }

        public long received_bytes { get; set; }

        public long total_bytes { get; set; }

        public long state { get; set; }

        public long danger_type { get; set; }

        public long interrupt_reason { get; set; }

        public byte[] hash { get; set; }

        public long end_time { get; set; }

        public long opened { get; set; }

        public long last_access_time { get; set; }

        public long transient { get; set; }

        public string referrer { get; set; }

        public string site_url { get; set; }

        public string tab_url { get; set; }

        public string tab_referrer_url { get; set; }

        public string http_method { get; set; }

        public string by_ext_id { get; set; }

        public string by_ext_name { get; set; }

        public string etag { get; set; }

        public string last_modified { get; set; }

        public string mime_type { get; set; }

        public string original_mime_type { get; set; }
    }
}
