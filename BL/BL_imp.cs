using BE;
using BL.functions;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL_imp : Ibl
    {
        

        DAL_imp dal = new DAL_imp();
        #region Report
        public bool AddReport(Report report)
        {
            return dal.AddReport(report);
        }
        public bool RemoveReport(int id)
        {
            throw new NotImplementedException();
        }
        public bool UpdateReport(BE.Report report)
        {
            throw new NotImplementedException();
        }
        public Report GetReportById(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Drop
        public bool AddDrop(Drop drop)
        {
            return dal.AddDrop(drop);
        } //done
        public bool RemoveDrop(int id)
        {
            return dal.RemoveDrop(id);
        } //done
        public bool UpdateDrop(BE.Drop Drop)
        {
            throw new NotImplementedException();
        }
        public Drop GetDropById(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
      


        #region Functions
        public async void GetCoordinate(string address)
        {

            var Coordinate = await ApiAdressToCoordinate.GetGeoCoordinateAsync(address);
            double let = Coordinate.results[0].geometry.location.lat;
            double log = Coordinate.results[0].geometry.location.lng;
        }
        public void GetCoordinateFromExif(string imagePath)
        {
            var img = ExifImageTo_Lat_Log.GetLatLongFromImage(imagePath);
        }

       


        #endregion

    }
}
