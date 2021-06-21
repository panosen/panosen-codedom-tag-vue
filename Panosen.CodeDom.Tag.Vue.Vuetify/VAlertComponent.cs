using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    /// <summary>
    /// 警示信息
    /// https://vuetifyjs.com/en/components/alerts
    /// </summary>
    public class VAlertComponent : VuetifyComponent
    {
        /// <summary>
        /// v-alert
        /// </summary>
        public override string Name { get; set; } = "v-alert";

        /// <summary>
        /// 设置类型
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns></returns>
        public VAlertComponent Type(AlertType type)
        {
            this.AddProperty("type", type.Value);

            return this;
        }

        /// <summary>
        /// 设置边框
        /// </summary>
        /// <param name="border">边框</param>
        /// <returns></returns>
        public VAlertComponent Border(AlertBorder border)
        {
            this.AddProperty("border", border.Value);

            return this;
        }
    }
}
