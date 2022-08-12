using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager2
{
    internal class ProductDAO
    {
      
        OracleConnection conn = null;
        Global g = new Global();
        public ProductDAO(OracleConnection conn)
        {
            this.conn = conn; 
        }

        /*
        public void connectDB()
        {
            String connstr = g.connectionString(db_url, db_port, db_sid, db_id, db_pw);
            conn = new OracleConnection(connstr);
            conn.Open();
        }
        */
        public void disconnectDB()
        {
            conn.Close();
        }
       


        public int insertProduct(ProductDTO productdto)
        {
            //connectDB();
            String sql = "insert into product (product_no, product_name, buy_date, buy_date_used, purpose) values (:0, :1, :2, :3, :4)";
            OracleCommand icmd = new OracleCommand(sql, conn);
            icmd.BindByName = true;
            icmd.Parameters.Add(new OracleParameter("0", productdto.Product_no));
            icmd.Parameters.Add(new OracleParameter("1", productdto.Product_name));
            icmd.Parameters.Add(new OracleParameter("2", productdto.Buy_date));
            icmd.Parameters.Add(new OracleParameter("3", productdto.Buy_date_used));
            icmd.Parameters.Add(new OracleParameter("4", productdto.Purpose));
            int result = icmd.ExecuteNonQuery();
            //disconnectDB();
            return result; 
        }

        public int updateProduct(ProductDTO productdto)
        {
            //connectDB();
            String sql = "update product set product_name = :0, buy_date = :1, buy_date_used = :2, purpose= :3 where product_no = :4";
            OracleCommand ucmd = new OracleCommand(sql, conn);
            ucmd.BindByName = true;
            ucmd.Parameters.Add(new OracleParameter("0", productdto.Product_name));
            ucmd.Parameters.Add(new OracleParameter("1", productdto.Buy_date));
            ucmd.Parameters.Add(new OracleParameter("2", productdto.Buy_date_used));
            ucmd.Parameters.Add(new OracleParameter("3", productdto.Purpose));
            ucmd.Parameters.Add(new OracleParameter("4", productdto.Product_no));
            int result = ucmd.ExecuteNonQuery();
            //disconnectDB();
            return result;
        }

        public int deleteProduct(String number)
        {
            //connectDB();
            String sql = "delete from product where product_no = :product_no";
            OracleCommand dcmd = new OracleCommand(sql, conn);
            dcmd.BindByName = true;
            dcmd.Parameters.Add(new OracleParameter("product_no", number));
            int result = dcmd.ExecuteNonQuery();
            //disconnectDB();
            return result; 
        }
        public List<MemberDTO> getMemberList()  //Login
        {
            //connectDB();
            List<MemberDTO> memberlist = new List<MemberDTO>();

            String sql = "select * from member order by id";
            OracleCommand scmd = new OracleCommand(sql, conn);  
            OracleDataReader dr = scmd.ExecuteReader();
            while (dr.Read())
            {
                MemberDTO memberdto = new MemberDTO();
                memberdto.Password = dr["password"].ToString();
                memberlist.Add(memberdto);
            }
            dr.Close();
            //disconnectDB();
            return memberlist;
        }

        public DataTable getProductList(Boolean desc, String columnname)
        {
            //connectDB();
            DataTable dt = new DataTable();
            String sql = null;
            if (desc)
            {
                if (columnname.Equals("buy_date"))
                {
                    sql = "select * from product order by buy_date desc";
                }
                else if (columnname.Equals("buy_date_used"))
                {
                    sql = "select * from product order by buy_date_used desc";
                }
                else
                {
                    sql = "select * from product order by product_no desc";
                }
            }
            else
            {
                if (columnname.Equals("buy_date"))
                {
                    sql = "select * from product order by buy_date";
                }
                else if (columnname.Equals("buy_date_used"))
                {
                    sql = "select * from product order by buy_date_used";
                }
                else
                {
                    sql = "select * from product order by product_no";
                }
            }
            OracleDataAdapter oda = new OracleDataAdapter(sql, conn);
            oda.Fill(dt);
            //disconnectDB();
            return dt;
        }

        public SortedList<String, String> GetProductListByNumber(String number)
        {
            //connectDB();
            SortedList<String, String> productlist = new SortedList<String, String>();
            String sql = "select * from product where product_no =:product_no";
            OracleCommand scmd = new OracleCommand(sql, conn);
            scmd.BindByName = true;
            scmd.Parameters.Add(new OracleParameter("product_no", number));
            OracleDataReader dr = scmd.ExecuteReader();
            while (dr.Read())
            {
                productlist["product_no"] = dr["product_no"].ToString();
                productlist["product_name"] = dr["product_name"].ToString();
                productlist["buy_date"] = dr["buy_date"].ToString();
                productlist["buy_date_used"] = dr["buy_date_used"].ToString();
                productlist["purpose"] = dr["purpose"].ToString();
            }
            dr.Close();
            //disconnectDB();
            return productlist; 
        }

        public int getProductNumber()
        {
            //connectDB();
            String sql = "select count(*) productnumber from product";
            int productnumber = 0;
            OracleCommand scmd = new OracleCommand(sql, conn);
            OracleDataReader dr = scmd.ExecuteReader();
            while (dr.Read())
            {
                productnumber = Int32.Parse(dr["productnumber"].ToString());
            }
            dr.Close();
            //disconnectDB();
            return productnumber; 
        }

        public int createTable()
        {
            String sql = "create table PRODUCT ( product_no int not null primary key, product_name varchar2(150) not null, buy_date varchar2(100), buy_date_used varchar2(100), purpose varchar2(150) not null)";
            OracleCommand scmd = new OracleCommand(sql, conn);
            int result = scmd.ExecuteNonQuery();
            scmd.Dispose();
            return result; 
        }

        public Boolean checkTableExist()
        {
            String sql = "select TNAME from tab where TNAME = 'PRODUCT'";
            OracleCommand scmd = new OracleCommand(sql, conn);
            OracleDataReader dr = scmd.ExecuteReader();
            Boolean existstatus = false;
            String tablename = null;
            if (dr.Read())
            {
                tablename = dr["TNAME"].ToString();
            }
            if(tablename != null)
            {
                existstatus = true; 
            }
            dr.Close();
            scmd.Dispose();
            return existstatus; 
        }
    }
}
