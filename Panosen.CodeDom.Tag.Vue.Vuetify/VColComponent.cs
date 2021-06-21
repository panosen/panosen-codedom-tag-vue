using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public class VColComponent : VuetifyComponent
    {
        public override string Name { get; set; } = "v-col";

        public VColComponent VFor(string vfor)
        {
            this.AddProperty("v-for", vfor);

            return this;
        }

        public VColComponent _Key(string key)
        {
            this.AddProperty(":key", key);

            return this;
        }

        public VColComponent Cols(int cols)
        {
            this.AddProperty("cols", cols);

            return this;
        }

        public VColComponent SM(int sm)
        {
            this.AddProperty("sm", sm);

            return this;
        }

        public VColComponent MD(int md)
        {
            this.AddProperty("md", md);

            return this;
        }

        public VColComponent LG(int lg)
        {
            this.AddProperty("lg", lg);

            return this;
        }

    }
}
