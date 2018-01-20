using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
    public class DocData
    {

        public readonly static DocData[] Docs = new DocData[] {
            new DocData {
                Display = "Installation",
                View = "Installation"
            },
            new DocData {
                Display = "Input Generator",
                View = "Generator"
            },
            new DocData {
                Display = "Basic Editor Setup",
                View = "Editor"
            }
            //,
            //new DocData {
            //    View = "CustomEditor",
            //    Display = "Customize Editor"
            //}
        };

        public string Tag { get; set; }
        public string View { get; set; }
        public string Display { get; set; }

        private string _Link;
        public string Link
        {
            get {
                return _Link ?? "docs/" + View; }
            set { _Link = value; }
        }

        public DocData()
        {
            Tag = Guid.NewGuid().ToString();
        }

        public ActiveMenu Active => new ActiveMenu(Tag);

        public static implicit operator string(DocData data)
        {
            return data.Tag;
        }

    }
}
