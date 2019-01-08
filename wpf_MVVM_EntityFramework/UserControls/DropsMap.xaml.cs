using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThinkGeo.MapSuite;
using ThinkGeo.MapSuite.Drawing;
using ThinkGeo.MapSuite.Layers;
using ThinkGeo.MapSuite.Shapes;
using ThinkGeo.MapSuite.Wpf;

namespace wpf_MVVM_EntityFramework.UserControls
{
    /// <summary>
    /// Interaction logic for DropsMap.xaml
    /// </summary>
    public partial class DropsMap : UserControl
    {
        public DropsMap()
        {

            InitializeComponent();
            myMap.Focus();
            //Set map to Aerial mode with labels
            myMap.Mode = new AerialMode(true);


           WebBrowserGoogleMap.Navigate("https://www.google.com/maps?q=Shahal+Jerusalem+") ;  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string street = txt_street.Text;
            string city = txt_city.Text;
            string state = txt_state.Text;
            string zip = txt_zip.Text;
            try
            {
                StringBuilder quarryAddress = new StringBuilder();
                StringBuilder quarryAddress2 = new StringBuilder();
                StringBuilder quarryAddress3 = new StringBuilder();

                quarryAddress.Append("https://www.google.com/maps?q=");
                //quarryAddress2.Append(" https://www.google.com/maps/d/u/0/edit?hl=iw&hl=iw&mid=1Cbdx-P-iEr0iTcSYEH3sno3gUsG0WMA2&ll=31.805111156673668%2C34.964537153527544&z=11 ");
                //quarryAddress3.Append(" https://www.google.com/maps/d/u/0/edit?hl=iw&hl=iw&mid=1Cbdx-P-iEr0iTcSYEH3sno3gUsG0WMA2&ll=31.960262760614995%2C35.34942100000001&z=15 ");
   
              
                //street
                if (street != string.Empty)
                {
                    quarryAddress.Append(street + "," + "+");
                }
                //city
                if (city != string.Empty)
                {
                    quarryAddress.Append(city + "," + "+");
                }
                //state
                if (state != string.Empty)
                {
                    quarryAddress.Append(state + "," + "+");
                }
                //zip
                if (zip != string.Empty)
                {
                    quarryAddress.Append(zip + "," + "+");
                }
                WebBrowserGoogleMap.Navigate(quarryAddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR");
            }
        }

        //private void UserControl_Loaded(object sender, RoutedEventArgs e)
        //{
        //    WpfMap.MapUnit = GeographyUnit.DecimalDegree;
        //    WpfMap.CurrentExtent = new RectangleShape(-155.733, 95.60, 104.42, -81.9);

        //    BackgroundLayer backgroundLayer = new BackgroundLayer(new GeoSolidBrush(GeoColor.GeographicColors.ShallowOcean));

        //    ShapeFileFeatureLayer worldLayer = new ShapeFileFeatureLayer(@"..\..\SampleData\Data\Countries02.shp");
        //     WpfMap.Refresh();  worldLayer.ZoomLevelSet.ZoomLevel01.DefaultAreaStyle = ThinkGeo.MapSuite.Styles.AreaStyles.Country1;
        //    WpfMap.Refresh();  worldLayer.ZoomLevelSet.ZoomLevel01.DefaultAreaStyle = ThinkGeo.MapSuite.Styles.WorldStreetsAndAryaStyles;
        //     WpfMap.Refresh(); worldLayer.ZoomLevelSet.ZoomLevel01.DefaultAreaStyle = ThinkGeo.MapSuite.Wo;
        //    worldLayer.ZoomLevelSet.ZoomLevel01.ApplyUntilZoomLevel = ApplyUntilZoomLevel.Level20;

        //    LayerOverlay worldOverlay = new LayerOverlay();
        //    worldOverlay.Layers.Add(backgroundLayer);
        //    worldOverlay.Layers.Add(worldLayer);
        //    WpfMap.Overlays.Add(worldOverlay);
        //    WpfMap.Refresh();

        //    /*  WpfMap.Refresh();  
        //      WpfMap.MapUnit = GeographyUnit.DecimalDegree;
        //      WpfMap.CurrentExtent = new RectangleShape(-155.733, 95.60, 104.42, -81.9);

        //      //WpfMap.Overlays.Add( new WorldStreetsAndImageryOverlay());
        //      WpfMap.Overlays.Add( new ThinkGeoCloudMapsOverlay());

        //      WpfMap.Refresh();
        //      */

        //}
    }
}
