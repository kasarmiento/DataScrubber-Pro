using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using System.Threading.Tasks;

namespace DataScrubberPro
{
    internal class modDataScrubberPro : Module
    {
        private static modDataScrubberPro _this = null;

        /// <summary>
        /// Retrieve the singleton instance to this module here
        /// </summary>
        public static modDataScrubberPro Current
        {
            get
            {
                return _this ?? (_this = (modDataScrubberPro)FrameworkApplication.FindModule("DataScrubberPro_Module"));
            }
        }

        #region Overrides
        /// <summary>
        /// Called by Framework when ArcGIS Pro is closing
        /// </summary>
        /// <returns>False to prevent Pro from closing, otherwise True</returns>
        protected override bool CanUnload()
        {
            //TODO - add your business logic
            //return false to ~cancel~ Application close
            return true;
        }

        #endregion Overrides

    }
}
