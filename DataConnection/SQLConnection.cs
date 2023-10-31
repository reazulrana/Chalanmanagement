using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLibrary;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using BussinessLibrary.SupportLibrary;
using System.Transactions;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using EncriptionLibrabry;
using SqlToolsLibrary;
using System.Diagnostics;

namespace DataConnection
{
    public class SQLConnection : IDataConnection
    {


        #region "Branch Section"

        string DatabaseName = "DBProductChallan";

        public void CreateBranch(tblBranch model)
        {

            DynamicParameters p = new DynamicParameters();

            using (IDbConnection con = NewSqlConnection)
            {

                p.Add("@Branch", model.Branch.ToUpper());

                con.Execute("spBranchCreate", p, commandType: CommandType.StoredProcedure);

            }



        }


        public List<tblBranch> Branch_Get_All
        {
            get
            {
                List<tblBranch> output = new List<tblBranch>();

                using (IDbConnection con = NewSqlConnection)
                {


                    output = con.Query<tblBranch>("spBranchGetAll", null, commandType: CommandType.StoredProcedure).ToList();

                }

                return output;
            }
        }






        #endregion

        #region "Brand Section"

        public void CreateBrand(tblBrand model)
        {

            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = NewSqlConnection)
            {

                p.Add("@Brand", model.Brand.ToUpper());

                con.Execute("spBrandCreate", p, commandType: CommandType.StoredProcedure);



            }


        }
        public List<tblBrand> Brand_Get_All
        {
            get
            {

                List<tblBrand> output = new List<tblBrand>();


                using (IDbConnection con = NewSqlConnection)
                {

                    output = con.Query<tblBrand>("spBrandGetAll", null, commandType: CommandType.StoredProcedure).ToList();


                }


                return output;
            }
        }

        #endregion

        #region "Category Section"

        public void CreateCategory(tblCategory model)
        {

            DynamicParameters p = new DynamicParameters();
            using (IDbConnection con = NewSqlConnection)
            {
                p.Add("@Category", model.Category.ToUpper());


                con.Execute("spCategoryCreate", p, commandType: CommandType.StoredProcedure);

            }

        }
        public List<tblCategory> Category_Get_All
        {
            get
            {
                List<tblCategory> output = new List<tblCategory>();

                using (IDbConnection con = NewSqlConnection)
                {
                    output = con.Query<tblCategory>("spCategoryGetAll", null, commandType: CommandType.StoredProcedure).ToList();


                }


                return output;
            }
        }

        #endregion

        #region "Model Section"

        public void CreateModel(tblModel model)
        {

            DynamicParameters p = new DynamicParameters();
            using (IDbConnection con = NewSqlConnection)
            {

                p.Add("@Model", ReduceSapce(model.Model).ToUpper());

                con.Execute("spModelCreate", p, commandType: CommandType.StoredProcedure);

            }


        }
        public List<tblModel> Model_Get_All
        {
            get
            {

                List<tblModel> Output = new List<tblModel>();

                using (IDbConnection con = NewSqlConnection)
                {
                    Output = con.Query<tblModel>("spModelGetAll", null, commandType: CommandType.StoredProcedure).ToList();
                }




                return Output;
            }
        }

        protected string ReduceSapce(string value)
        {

            string output = "";

            foreach (char s in value)
            {
                if (Convert.ToString(s) != " ")
                {
                    output += s;
                }
            }

            return output;
        }

        #endregion

        #region "Transfer Challan Receive Section"

        public void CreateReceiveChallan(tblMaster model)
        {






            using (IDbConnection con = NewSqlConnection)
            {
                DynamicParameters p = new DynamicParameters();
                using (TransactionScope scope = new TransactionScope())
                {


                    p.Add("@ChallanNo", model.ChallanNo);
                    p.Add("@TrDate", model.TrDate);
                    p.Add("@TrType", model.TrType);
                    p.Add("@Source", model.Source.ToUpper());
                    p.Add("@Destination", model.Destination.ToUpper());
                    p.Add("@ReceiveCondition", model.ReceiveCondition);
                    p.Add("@Remarks", model.Remarks);

                    con.Execute("spMasterCreate", p, commandType: CommandType.StoredProcedure);

                    if (IsChallan_Exist_InMasterDetails(model.ChallanNo))
                    {
                        DeleteMasterDetails(model.ChallanNo);
                    }

                    foreach (tblMasterDetails ms in model.ProductList)
                    {

                        p = new DynamicParameters();
                        p.Add("@ChallanNo", model.ChallanNo);
                        p.Add("@Brand", ms.Brand.ToUpper());
                        p.Add("@Category", ms.Category.ToUpper());
                        p.Add("@ProductName", ms.ProductName.ToUpper());
                        p.Add("@Model", ms.Model.ToUpper());
                        p.Add("@Serial", ms.Serial);
                        p.Add("@Code", ms.Code);
                        p.Add("@ReceiveChallan", ms.ReceiveChallan);
                        con.Execute("spMasterDetailsCreate", p, commandType: CommandType.StoredProcedure);
                    }

                    scope.Complete();

                }




                // Delete From tblNotReturn Table on Database if The transaction Type is Delivery

                if (model.TrType.ToLower() == "Delivery".ToLower())
                {

                    foreach (tblMasterDetails ms in model.ProductList)
                    {






                        p = new DynamicParameters();

                        p.Add("@Model", ms.Model);
                        p.Add("@Serial", ms.Serial);
                        p.Add("@ChallanNo", ms.Serial);

                        try
                        {

                            con.Execute("sptblNotReturnDelete", p, commandType: CommandType.StoredProcedure);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                    }
                }



            }
        }

        public void UpdateReceiveChallan(tblMaster model)
        {

            DynamicParameters p;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (IDbConnection con = NewSqlConnection)
                    {
                        p = new DynamicParameters();
                        p.Add("@ChallanNo", model.ChallanNo);
                        p.Add("@TrDate", model.TrDate);
                        p.Add("@TrType", model.TrType);
                        p.Add("@Source", model.Source.ToUpper());
                        p.Add("@Destination", model.Destination.ToUpper());
                        p.Add("@ReceiveCondition", model.ReceiveCondition);
                        p.Add("@Remarks", model.Remarks);

                        con.Execute("spMasterUpdate", p, commandType: CommandType.StoredProcedure);



                        if (IsChallan_Exist_InMasterDetails(model.ChallanNo))
                        {
                            DeleteMasterDetails(model.ChallanNo);
                        }


                        foreach (tblMasterDetails ms in model.ProductList)
                        {

                            p = new DynamicParameters();

                            p.Add("@ChallanNo", model.ChallanNo);
                            p.Add("@Brand", ms.Brand.ToUpper());
                            p.Add("@Category", ms.Category.ToUpper());
                            p.Add("@ProductName", ms.ProductName.ToUpper());
                            p.Add("@Model", ms.Model.ToUpper());
                            p.Add("@Serial", ms.Serial);
                            p.Add("@Code", ms.Code);
                            p.Add("@ReceiveChallan", ms.ReceiveChallan);

                            con.Execute("spMasterDetailsCreate", p, commandType: CommandType.StoredProcedure);


                        }
                        scope.Complete();
                    }

                }
            }
            catch
            {
                throw new Exception("Exception is found on UpdateReceiveChallan method");
            }
        }


        #endregion

        #region "tblMasterDetails Section"

        public void DeleteMasterDetails(string ChallanNo)
        {
            DynamicParameters p = new DynamicParameters();


            using (IDbConnection con = NewSqlConnection)
            {
                p.Add("@ChallanNo", ChallanNo);


                con.Execute("spMasterDetailsDelete_By_ChallanNo", p, commandType: CommandType.StoredProcedure);

            }
        }



        public bool IsChallan_Exist_InMasterDetails(string ChallanNo)
        {

            DynamicParameters p = new DynamicParameters();
            bool blnflag = false;
            List<tblMasterDetails> Output = new List<tblMasterDetails>();
            using (IDbConnection con = NewSqlConnection)
            {
                p.Add("@ChallanNo", ChallanNo);

                try
                {
                    Output = con.Query<tblMasterDetails>("spMasterDetailsDelete_IsExist_ChallanNo", p, commandType: CommandType.StoredProcedure).ToList(); ;

                }
                catch
                {
                    blnflag = false;
                }
            }


            if (Output.Count <= 0)
            {
                blnflag = false;
            }
            else
            {
                blnflag = true;
            }


            return blnflag;


        }


        public tblMasterDetails GetMasterDetails_by_Challan_Model_Serial(ProductDetails model)
        {



            using (IDbConnection con = NewSqlConnection)
            {

                DynamicParameters p = new DynamicParameters();
                         
                    p.Add("@ChallanNo", model.ReceiveChallan);
              
                p.Add("@Model", model.Model);
                p.Add("@Serial", model.Serial);


                return con.QuerySingle<tblMasterDetails>("spGettblMasterDetails_by_Challan_Model_Serial", p, commandType: CommandType.StoredProcedure);

            }




        }

        public void UpdateMasterDetails(tblMasterDetails PreviousModel, tblMasterDetails PresentModel)
        {



            using (IDbConnection con = NewSqlConnection)
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@MDID", PreviousModel.MDID);
                p.Add("@ChallanNo", PresentModel.ChallanNo);
                p.Add("@Brand", PresentModel.Brand);
                p.Add("@Category", PresentModel.Category);
                p.Add("@ProductName", PresentModel.ProductName);
                p.Add("@Model", PresentModel.Model);
                p.Add("@Serial", PresentModel.Serial);
                p.Add("@Code", PresentModel.Code); // Define Database Filed Code=Location in form 
                p.Add("@ReceiveChallan", PresentModel.ReceiveChallan);
                p.Add("@PreviousChallanno", PreviousModel.ChallanNo);
                p.Add("@PreviousModel", PreviousModel.Model);
                p.Add("@PreviousSerial", PreviousModel.Serial);

                // Upadte tblMasterDetails, tblCannibalized, tblNotReturn  with this procedure (spUpdatetblMasterDetails)
                con.Execute("spUpdatetblMasterDetails", p, commandType: CommandType.StoredProcedure);
              
            }


        }




        public int GetMasterDetailsID(ProductDetails PD)
        {

            tblMasterDetails tmpoutput = new tblMasterDetails();
            int output = 0;
            using (IDbConnection con = NewSqlConnection)
            {
                try
                {
                    DynamicParameters p = new DynamicParameters();
                p.Add("@ChallanNo", PD.DeliveryChallan);
                p.Add("@Model", PD.Model);
                p.Add("@Serial", PD.Serial);
                tmpoutput = con.QuerySingle<tblMasterDetails>("spGetMasterDetailMDID", p, commandType: CommandType.StoredProcedure);
                
                output = tmpoutput.MDID;
                }
                catch
                {
                    output = 0;
                }

            }


            return output;
        }

        #endregion

        #region "tblMaster Section"

        public List<tblMaster> MasterDetailGetAll
        {
            get
            {

                List<tblMaster> output = new List<tblMaster>();

                using (IDbConnection con = NewSqlConnection)
                {

                    try
                    {
                        output = con.Query<tblMaster>("spMasterGetAll", null, commandType: CommandType.StoredProcedure).ToList();

                    }
                    catch
                    {

                    }

                }

                return output;
            }
        }


        public tblMaster MasterDetailGetSingle(tblMaster model)
        {

            using (IDbConnection con = NewSqlConnection)
            {

                DynamicParameters p = new DynamicParameters();

                p.Add("@ChallanNo", model.ChallanNo);

                model.ProductList = con.Query<tblMasterDetails>("spMasterDetails_GetbyChallan", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return model;
        }

        #endregion

        #region Balance Section
        public List<ProductBalance> GetProductBalance
        {
            get

            {


                List<ProductBalance> output = new List<ProductBalance>();
                using (IDbConnection con = NewSqlConnection)
                {

                    output = con.Query<ProductBalance>("spBalanceGet", null, commandType: CommandType.StoredProcedure).ToList();


                }



                return output;
            }


        }


        public List<ProductBalance> GetProductBalancebyFilter(ProductDetails model)
        {
            List<ProductBalance> output = new List<ProductBalance>();
            using (IDbConnection con = NewSqlConnection)
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Brand", model.Brand);
                p.Add("@Category", model.Category);

                output = con.Query<ProductBalance>("spBalanceGet", p, commandType: CommandType.StoredProcedure).ToList();


            }



            return output;
        }
        #endregion



        #region 'Details Section'

        public List<ProductDetails> GetProductDetails_ByReceive(string Modelno)
        {

            List<ProductDetails> output = new List<ProductDetails>();


            using (IDbConnection con = NewSqlConnection)
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Model", Modelno);
                output = con.Query<ProductDetails>("spGetModelDetails_byReceive", p, commandType: CommandType.StoredProcedure).ToList();


                foreach (ProductDetails pd in output)
                {


                    p = new DynamicParameters();
                    p.Add("@Model", pd.Model);
                    p.Add("@Serial", pd.Serial);
                    p.Add("@ChallanNo", pd.ReceiveChallan);


                    if(pd.ReceiveChallan.ToLower() == "010819-080")
                    {
                        MessageBox.Show(pd.Serial);
                    }
                    if (pd.Model.ToLower()== "KLV-40W652D".ToLower() && pd.Serial.ToLower()== "9231620".ToLower() && pd.ReceiveChallan.ToLower()== "010819-080".ToLower())
                    { 
                    pd.CannibalizedProducts = con.Query<tblCannibalized>("spCannibalized_Get_By_ModelSerial", p, commandType: CommandType.StoredProcedure).ToList();
                    }
                }


            }


            return output;

        }



        public List<ProductDetails> GetProductDetails_BySerial(string serialno)
        {

            List<ProductDetails> output = new List<ProductDetails>();


            using (IDbConnection con = NewSqlConnection)
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Serial", serialno);
                output = con.Query<ProductDetails>("spSearchbySerial", p, commandType: CommandType.StoredProcedure).ToList();


                foreach (ProductDetails pd in output)
                {


                    p = new DynamicParameters();
                    p.Add("@Model", pd.Model);
                    p.Add("@Serial", pd.Serial);
                    p.Add("@ChallanNo", pd.ReceiveChallan);
                    pd.CannibalizedProducts = con.Query<tblCannibalized>("spCannibalized_Get_By_ModelSerial", p, commandType: CommandType.StoredProcedure).ToList();
                }


            }


            return output;

        }


        public List<ProductDetails> GetProductDetails_ByReceive()
        {

            List<ProductDetails> output = new List<ProductDetails>();


            using (IDbConnection con = NewSqlConnection)
            {

                output = con.Query<ProductDetails>("spGetModelDetails_byReceive", null, commandType: CommandType.StoredProcedure).ToList();

                foreach (ProductDetails pd in output)
                {


                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Model", pd.Model);
                    p.Add("@Serial", pd.Serial);
                    p.Add("@ChallanNo", pd.ReceiveChallan);

                                 
                        pd.CannibalizedProducts = con.Query<tblCannibalized>("spCannibalized_Get_By_ModelSerial", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach(tblCannibalized tb in pd.CannibalizedProducts)
                    {

                        pd.JobCode += tb.JobCode + ",";
                        pd.Branch += tb.Branch + ",";
                    }
                    if (pd.JobCode!=null && pd.JobCode.Length >= 1)
                    {
                        pd.JobCode = pd.JobCode.Substring(0,pd.JobCode.Length - 1);
                    }

                    if (pd.Branch!=null && pd.Branch.Length >= 1)
                    {
                        pd.Branch = pd.Branch.Substring(0,pd.Branch.Length - 1);
                    }
                }

            }


            return output;

        }
        #endregion




        #region 'Product Section'
        public List<Product> GetAllProduct
        {
            get

            {

                string cs = ConfigurationManager.ConnectionStrings["DBInventory"].ConnectionString;

                List<Product> output = new List<Product>();
                using (IDbConnection con = new SqlConnection(cs))
                {

                    output = con.Query<Product>("Select * from vwGetProduct", null, commandType: CommandType.Text).ToList();

                }


                return output;

            }

        }





        public ProductDetails Check_Serial_Duplication(tblMasterDetails model)
        {

            using (IDbConnection con = NewSqlConnection)
            {

                DynamicParameters p = new DynamicParameters();


                p.Add("@Model", model.Model);
                p.Add("@Serial", model.Serial);

                try
                {
                    return con.QuerySingle<ProductDetails>("spCheck_Duplicate_Receive_Same_Serial_Same_Model", p, commandType: CommandType.StoredProcedure);
                }
                catch
                {
                    return null;
                }

            }

        }

        #endregion



        #region 'Cannibalized Section'

        public tblCannibalized CannibalizedCreate(tblCannibalized model)
        {


            DynamicParameters p;
            using (IDbConnection con = NewSqlConnection)
            {
                p = new DynamicParameters();

                p.Add("@CanID", model.CanID, DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@ChallanNo", model.ChallanNo);
                p.Add("@Model", model.Model);
                p.Add("@Serial", model.Serial);
                p.Add("@ReceivedDate", model.ReceivedDate);
                p.Add("@ProductName", model.ProductName);
                p.Add("@PartNo", model.PartNo);
                p.Add("@Branch", model.Branch);
                p.Add("@JobCode", model.JobCode);
                p.Add("@Status", model.Status);
                p.Add("@OrderQty", model.OrderQty);
                p.Add("@OrderDate", model.OrderDate);
                p.Add("@Accessories", model.Accessories);

                con.Execute("spCannibalizedCreate", p, commandType: CommandType.StoredProcedure);
                model.CanID = p.Get<int>("@CanID");




            }



            return model;

        }




        public List<tblCannibalized> GetCannibalizad_All_by_Model
        {
            get
            {

                List<tblCannibalized> output = new List<tblCannibalized>();
                using (IDbConnection con = NewSqlConnection)
                {
                    output = con.Query<tblCannibalized>("spCannibalized_Get_By_ModelSerial", null, commandType: CommandType.StoredProcedure).ToList();

                }


                return output;
            }
        }

        public List<tblCannibalized> Cannibalized_Product_ReceiveDate(string StartDate, string EndDate, ProductDetails model)
        {


            List<tblCannibalized> output = new List<tblCannibalized>();
            using (IDbConnection con = NewSqlConnection)
            {
                try
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@startDate", StartDate);
                    p.Add("@EndDate", EndDate);
                    p.Add("@Brand", model.Brand);
                    p.Add("@Category", model.Category);


                    output = con.Query<tblCannibalized>("sptblCannibalized_byReceiveDate", p, commandType: CommandType.StoredProcedure).ToList();
                }
                catch
                {

                }
            }




            return output;

        }


        public List<tblCannibalized> Cannibalized_Product_All(ProductDetails model)
        {


            List<tblCannibalized> output = new List<tblCannibalized>();
            using (IDbConnection con = NewSqlConnection)
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Brand", model.Brand);
                p.Add("@Category", model.Category);



                output = con.Query<tblCannibalized>("sptblCannibalized_GetAll", p, commandType: CommandType.StoredProcedure).ToList();

            }


            return output;
        }
        public ProductDetails GetCannibalizad(ProductDetails model)
        {

            using (IDbConnection con = NewSqlConnection)
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Model", model.Model);
                p.Add("@Serial", model.Serial);
                p.Add("@ChallanNo", model.ReceiveChallan);
                model.CannibalizedProducts = con.Query<tblCannibalized>("spCannibalized_Get_By_ModelSerial", p, commandType: CommandType.StoredProcedure).ToList();
            }


            return model;
        }

        public void DeleteCannibalizad(tblCannibalized model)
        {

            StringBuilder s = new StringBuilder();


            s.AppendLine("");
            s.AppendLine("Name: " + model.ProductName);
            s.AppendLine("Model: " + model.Model);
            s.AppendLine("Part No: " + model.PartNo);







            if (MessageBox.Show("Are you sure to delete the Record \n\r" + s.ToString(), "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            using (IDbConnection con = NewSqlConnection)
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@CanID", model.CanID);


                con.Execute("spCannibalizedDelete", p, commandType: CommandType.StoredProcedure);

                MessageBox.Show("Record Deleted Successfully " + s.ToString());
            }
        }



        public List<CannibalizedDetails> Cannibalized_Product_Summery_All(ProductDetails model)
        {


            DynamicParameters p;
            List<CannibalizedDetails> output = new List<CannibalizedDetails>();

            using (IDbConnection con = NewSqlConnection)
            {

                p = new DynamicParameters();
                p.Add("@Brand", model.Brand);
                p.Add("@Category", model.Category);

                output = con.Query<CannibalizedDetails>("sptblCannibalized_UniqueModelAll", p, commandType: CommandType.StoredProcedure).ToList();



                foreach (CannibalizedDetails cb in output)
                {

                    p = new DynamicParameters();
                    p.Add("@ChallanNo", cb.ChallanNo);
                    p.Add("@Model", cb.Model);
                    p.Add("@Serial", cb.Serial);

                    try
                    {
                        cb.ListCannibalized = con.Query<tblCannibalized>("sptblCannibalized_Unique_byModel_Serial_ALL", p, commandType: CommandType.StoredProcedure).ToList();
                    }
                    catch
                    {

                    }


                }


            }





            return output;

        }



        public List<CannibalizedDetails> Cannibalized_Product_Summery_By_Date(string StartDate, string EndDate, ProductDetails model)
        {




            DynamicParameters p;
            List<CannibalizedDetails> output = new List<CannibalizedDetails>();

            using (IDbConnection con = NewSqlConnection)
            {
                p = new DynamicParameters();

                p.Add("@startDate", StartDate);
                p.Add("@EndDate", EndDate);
                p.Add("@Brand", model.Brand);
                p.Add("@Category", model.Category);

                output = con.Query<CannibalizedDetails>("sptblCannibalized_UniqueModel_by_Date", p, commandType: CommandType.StoredProcedure).ToList();



                foreach (CannibalizedDetails cb in output)
                {

                    p = new DynamicParameters();
                    p.Add("@ChallanNo", cb.ChallanNo);
                    p.Add("@Model", cb.Model);
                    p.Add("@Serial", cb.Serial);
                    p.Add("@StartDate", StartDate);
                    p.Add("@Enddate", EndDate);


                    try
                    {
                        cb.ListCannibalized = con.Query<tblCannibalized>("sptblCannibalized_Unique_byModel_Serial", p, commandType: CommandType.StoredProcedure).ToList();
                    }
                    catch
                    {

                    }


                }


            }





            return output;

        }



        #endregion






        #region table Not Return
        public void CreateNotReturn(tblNotReturn model)
        {

            using (IDbConnection con = NewSqlConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@Model", model.Model);
                p.Add("@Serial", model.Serial);
                p.Add("@ChallanNo", model.ChallanNo);
                p.Add("@NRReason", model.NRReason);

                try
                {

                    con.Execute("sptblNotReturnCreate", p, commandType: CommandType.StoredProcedure);
                    MessageBox.Show(string.Format("Record Saved Successfulle Model: {0}, Serial: {1}", model.Model, model.Serial));

                }
                catch
                {
                    throw new Exception("Exception is found on CreateNotReturn method");
                }


            }
        }
        public void DeleteNotReturn(tblNotReturn model)
        {
            using (IDbConnection con = NewSqlConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@Model", model.Model);
                p.Add("@Serial", model.Serial);
                p.Add("@ChallanNo", model.ChallanNo);

                try
                {

                    con.Execute("sptblNotReturnDelete", p, commandType: CommandType.StoredProcedure);
                    MessageBox.Show(string.Format("Record Deleted Successfulle Model: {0}, Serial: {1}", model.Model, model.Serial));
                }
                catch
                {
                    throw new Exception("Exception is found on DeleteNotReturn method");
                }


            }
        }





        #endregion




        #region  Datebase Section
        public bool isDatabaseExists // Check Database Exist
        {
            get
            {
                bool blnFlag = true;
                using (SqlConnection con = new SqlConnection(HelperConnection.GetConnection(DatabaseName)))
                {
                    try
                    {


                        con.Open();


                    }
                    catch
                    {
                        blnFlag = false;
                    }
                }

                return blnFlag;
            }
        }


        public void BackupDatabase(string Destination)
        {

            string cs = HelperConnection.GetConnection(DatabaseName);


            SQLDatabase.BackupDatabase(Destination, cs);

            //string dbName = "";
            //string BackUpName = "";

            //foreach (char c in Destination)
            //{
            //    if (c == Convert.ToChar("'"))
            //    {
            //        MessageBox.Show("You have to remove this character from Destination Folder Name (')");
            //        return;
            //    }
            //}


            //using (IDbConnection con = NewSqlConnection)
            //{
            //    dbName = con.Database;

            //    if (!isDatabaseExists)
            //    {

            //        MessageBox.Show("Database is not exists to the server (" + dbName + ")", "File Not Found");
            //        return;
            //    }


            //    try
            //    {
            //        BackUpName = dbName + "_Backup.bak";

            //        string checkFileExists = Destination + @"\" + BackUpName;
            //        string strBackup = "Backup Database " + dbName + " To Disk ='" + Destination + @"\" + BackUpName + "'";

            //        if (File.Exists(checkFileExists))
            //        {

            //            if (MessageBox.Show("File (" + BackUpName + ") is found to the folder; Do want to overwrite", "File Duplication", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            //            {
            //                return;
            //            }

            //            File.Delete(checkFileExists);
            //        }

            //        con.Execute(strBackup, null, commandType: CommandType.Text);
            //        MessageBox.Show("Database Back up Sucessfully");
            //    }
            //    catch
            //    {
            //        throw new Exception();
            //    }
            //}




        }




        public void RestoreDatabase(string filename)
        {


            string cs = HelperConnection.GetConnection(DatabaseName);


            SQLDatabase.BackupDatabase(filename, cs);

            //string dbName = "";
            //string BackUpName = "";
            //string connection = ConfigurationManager.ConnectionStrings["DBMaster"].ConnectionString;

            //using (IDbConnection cons = NewSqlConnection)
            //{
            //    dbName = cons.Database;
            //}

            //using (IDbConnection con = new SqlConnection(connection))
            //{


            //    if (isDatabaseExists)
            //    {

            //        MessageBox.Show("Database is exists to the server (" + dbName + ")", "File is found");
            //        return;
            //    }


            //    try
            //    {
            //        string strBackup = "Restore Database " + dbName + " from Disk ='" + filename + "'";
            //        con.Execute(strBackup, null, commandType: CommandType.Text);
            //        MessageBox.Show("Database Restored Sucessfully");
            //    }
            //    catch
            //    {
            //        throw new Exception();
            //    }
            //}




        }
        #endregion


        #region "Challan Change Section"
        public void ChangeChallanNo(string PreviousChallan, string NewChallan)
        {

            using (IDbConnection con = NewSqlConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@PreviousChallan", PreviousChallan);
                p.Add("@NewChallan", NewChallan);
                con.Execute("SpChangeChallanNo", p, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Challan no is Changed", "Save Successfully");



            }


        }


        public List<tblMaster> GetAlltblMaster
        {
            get
            {
                List<tblMaster> output = new List<tblMaster>();

                using (IDbConnection con = NewSqlConnection)
                {

                    output = con.Query<tblMaster>("sptblMasterGetAll", null, commandType: CommandType.StoredProcedure).ToList();




                }

                return output;
            }
        }
        #endregion



        public void InsertSecurity(string Security)
        {
            using (IDbConnection con = NewSqlConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@SecurityNo", GlobalEncription.EncriptCode.Encryption(Security.ToLower()));
                try
                {
                    con.Execute("spSecurityCreate", p, commandType: CommandType.StoredProcedure);
                }
                catch
                {
                    throw new Exception("Exception is found on InsertSecurity method");
                }
            }
        }
        public void UpdateSecurity(string Security)
        {
            using (IDbConnection con = NewSqlConnection)
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@SecurityNo", GlobalEncription.EncriptCode.Encryption(Security.ToLower()));
                try
                {
                    con.Execute("spSecurityUpdate", p, commandType: CommandType.StoredProcedure);
                }
                catch
                {
                    throw new Exception("Exception is found on UpdateSecurity method");
                }
            }
        }

        public tblSecurity GetSecurity
        {
            get
            {
                tblSecurity output = new tblSecurity();
                using (IDbConnection con = NewSqlConnection)
                {
                    DynamicParameters p = new DynamicParameters();


                    try
                    {
                        output = con.QuerySingle<tblSecurity>("spSecurityGet", null, commandType: CommandType.StoredProcedure);
                        output.SecurityNo = GlobalEncription.EncriptCode.Decryption(output.SecurityNo);
                    }
                    catch
                    {
                        output = null;

                    }
                }
                return output;
            }
        }





        public void InitialDatabaseRestore()
        {
            string cs = HelperConnection.GetConnection(DatabaseName);
            if (!isDatabaseExists)
            {
                SQLDatabase.RestoreDatabaseFirstTime(Application.StartupPath + @"\ProductChallan_Backup_New.bak", cs);
            }

        }
        protected SqlConnection NewSqlConnection
        {
            get
            {
                return new SqlConnection(HelperConnection.GetConnection(DatabaseName));
            }
        }
        public bool isEx { get

            {
                bool blnFlag = false;
                string s = ConfigurationManager.AppSettings["e"];
                string td = "31-10-" + (int.Parse(s));
                DateTime t = Convert.ToDateTime(td);
                if (DateTime.Now.Date > t)
                {
                    blnFlag = true;
                }
                
                return blnFlag;

            } }
    }
}

