using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Mapping;

namespace DataScrubberPro
{
    internal class dockpaneDataScrubberProViewModel : DockPane
    {
        private const string _dockPaneID = "DataScrubberPro_dockpaneDataScrubberPro";

        private ObservableCollection<string> _layers;
        private string _selectedLayer;

        private ICommand _cmdScrub;
        private ICommand _cmdDropDownLayers;
        private string _selectedScrubberType;

        protected dockpaneDataScrubberProViewModel() { }

        public ObservableCollection<string> Layers
        {
            get { return _layers; }
            set
            {
                _layers = value;
                NotifyPropertyChanged(new PropertyChangedEventArgs("Layers"));
            }
        }

        public string SelectedLayer
        {
            get { return _selectedLayer; }
            set
            {
                SetProperty(ref _selectedLayer, value, () => SelectedLayer);
            }
        }


        /// <summary>
        /// This method will populate the Layers (bound to the LayersComboBox) with all the Feature Layers present in the Active Map View
        /// </summary>
        public ICommand CmdDropDownLayers
        {
            get
            {
                return _cmdDropDownLayers ?? (_cmdDropDownLayers = new RelayCommand(() =>
                {
                    Layers =
                        new ObservableCollection<string>(
                            MapView.Active.Map.Layers.Where(layer => layer is FeatureLayer).Select(layer => layer.Name));
                }, () => MapView.Active.Map.Layers != null));
            }
        }

       public string SelectedScrubberType
        {
            get { return _selectedScrubberType; }
            set
            {
                if (_selectedScrubberType != value)
                {
                    _selectedScrubberType = value;
                    NotifyPropertyChanged("SelectedScrubberType");
                }
            }
        }


        private void BrowseForFeatureClass()
        {
            OpenItemDialog dataToScrubberDialog;

            dataToScrubberDialog = new OpenItemDialog();
            dataToScrubberDialog.InitialLocation = @"C:\";
            dataToScrubberDialog.MultiSelect = false;
            dataToScrubberDialog.Filter = ItemFilters.featureClasses_all;

            dataToScrubberDialog.Title = "Browse for your data";

            bool? ok = dataToScrubberDialog.ShowDialog();

        }


        #region UI Management
        /// <summary>
        /// Show the DockPane.
        /// </summary>
        internal static void Show()
        {
            DockPane pane = FrameworkApplication.DockPaneManager.Find(_dockPaneID);
            if (pane == null)
                return;

            pane.Activate();
        }

        /// <summary>
        /// Text shown near the top of the DockPane.
        /// </summary>
        private string _heading = "SchoolSite DataScrubber";
        public string Heading
        {
            get { return _heading; }
            set
            {
                SetProperty(ref _heading, value, () => Heading);
            }
        }
        #endregion

    }

    /// <summary>
    /// Button implementation to show the DockPane.
    /// </summary>
    internal class dockpaneDataScrubberPro_ShowButton : Button
    {
        protected override void OnClick()
        {
            dockpaneDataScrubberProViewModel.Show();
        }
    }
}
