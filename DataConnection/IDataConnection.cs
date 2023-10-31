using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLibrary;
using BussinessLibrary.SupportLibrary;
using System.Transactions;

namespace DataConnection
{
  public  interface IDataConnection
    {
        #region "Branch Section"

        void CreateBranch(tblBranch model);
        List<tblBranch> Branch_Get_All { get; }

        #endregion


        #region "Brand Section"

        void CreateBrand(tblBrand model);
        List<tblBrand> Brand_Get_All { get; }

        #endregion



        #region "Category Section"

        void CreateCategory(tblCategory model);
         List<tblCategory> Category_Get_All { get; }

        #endregion




        #region "Model Section"

        void CreateModel(tblModel model);
        List<tblModel> Model_Get_All { get; }

        #endregion


        #region "Transfer Challan Receive Section"

        void CreateReceiveChallan(tblMaster model);
        void UpdateReceiveChallan(tblMaster model);

        #endregion





        #region "tblMaster Section"

        List<tblMaster> MasterDetailGetAll { get; }
        tblMaster MasterDetailGetSingle(tblMaster model);


        #endregion



        #region "tblMasterDetails Section"


      
        void DeleteMasterDetails(string ChallanNo);
        bool IsChallan_Exist_InMasterDetails(string ChallanNo);
        tblMasterDetails GetMasterDetails_by_Challan_Model_Serial(ProductDetails model);
        void UpdateMasterDetails(tblMasterDetails PreviousModel, tblMasterDetails PresentModel);
        int GetMasterDetailsID(ProductDetails PD);
        

        #endregion


        #region Balance Section
        List<ProductBalance> GetProductBalance { get; }
        List<ProductBalance> GetProductBalancebyFilter(ProductDetails model);
        #endregion

        #region 'Details Section'

        List<ProductDetails> GetProductDetails_ByReceive(string Modelno);
        List<ProductDetails> GetProductDetails_ByReceive();
        List<ProductDetails> GetProductDetails_BySerial(string serialno);

        #endregion

        #region 'Product Section'
        List<Product> GetAllProduct { get; }
        ProductDetails Check_Serial_Duplication(tblMasterDetails model);
        #endregion


        #region 'Cannibalized Section'

        tblCannibalized CannibalizedCreate(tblCannibalized model);

        List<tblCannibalized> GetCannibalizad_All_by_Model { get; }

        ProductDetails GetCannibalizad(ProductDetails model);
        void DeleteCannibalizad(tblCannibalized model);

        List<tblCannibalized> Cannibalized_Product_All(ProductDetails model);
        List<tblCannibalized> Cannibalized_Product_ReceiveDate(string StartDate, string EndDate,ProductDetails model);

        List<CannibalizedDetails> Cannibalized_Product_Summery_All(ProductDetails model);
        List<CannibalizedDetails> Cannibalized_Product_Summery_By_Date(string StartDate, string EndDate,ProductDetails model);


        #endregion

        #region table Not Return
        void CreateNotReturn(tblNotReturn model);
        void DeleteNotReturn(tblNotReturn model);



        #endregion
        #region "GetMDID from table master Deteails Section"


        #endregion


        #region Datebase Section
        bool isDatabaseExists { get; }//Check Database
        void BackupDatabase(string Destination);
        void RestoreDatabase(string filename);



        #endregion

        void InsertSecurity(string Security);
        void UpdateSecurity(string Security);
        tblSecurity GetSecurity { get; }
        void InitialDatabaseRestore();


        // spGettblMasterDetails_by_Challan_Model_Serial


        #region "Challan Change Section"
        void ChangeChallanNo(string PreviousChallan, string NewChallan);

        List<tblMaster> GetAlltblMaster { get; }
        #endregion

        bool isEx { get; }

    }
}

