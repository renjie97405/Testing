using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace SgnalProcess.DAL
{
	/// <summary>
	/// 数据访问类:buildingvibrationairfloatationplatform
	/// </summary>
	public partial class buildingvibrationairfloatationplatform
	{
		public buildingvibrationairfloatationplatform()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "buildingvibrationairfloatationplatform"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from buildingvibrationairfloatationplatform");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SgnalProcess.Model.buildingvibrationairfloatationplatform model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into buildingvibrationairfloatationplatform(");
			strSql.Append("BVAF_PROGRAM_ID,BVAF_TESTREPORT_URL,BVAF_TESTPOINTDRAWING_URL,BVAF_InstallationComplete_WC_ID,BVAF__NORMALUSE_WC_ID,BVAF_CREATEDATA,BVAF_ISDEL)");
			strSql.Append(" values (");
			strSql.Append("@BVAF_PROGRAM_ID,@BVAF_TESTREPORT_URL,@BVAF_TESTPOINTDRAWING_URL,@BVAF_InstallationComplete_WC_ID,@BVAF__NORMALUSE_WC_ID,@BVAF_CREATEDATA,@BVAF_ISDEL)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BVAF_PROGRAM_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVAF_TESTREPORT_URL", MySqlDbType.Int32,11),
					new MySqlParameter("@BVAF_TESTPOINTDRAWING_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVAF_InstallationComplete_WC_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVAF__NORMALUSE_WC_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVAF_CREATEDATA", MySqlDbType.Datetime),
					new MySqlParameter("@BVAF_ISDEL", MySqlDbType.VarChar,1)};
			parameters[0].Value = model.BVAF_PROGRAM_ID;
			parameters[1].Value = model.BVAF_TESTREPORT_URL;
			parameters[2].Value = model.BVAF_TESTPOINTDRAWING_URL;
			parameters[3].Value = model.BVAF_InstallationComplete_WC_ID;
			parameters[4].Value = model.BVAF__NORMALUSE_WC_ID;
			parameters[5].Value = model.BVAF_CREATEDATA;
			parameters[6].Value = model.BVAF_ISDEL;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SgnalProcess.Model.buildingvibrationairfloatationplatform model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update buildingvibrationairfloatationplatform set ");
			strSql.Append("BVAF_PROGRAM_ID=@BVAF_PROGRAM_ID,");
			strSql.Append("BVAF_TESTREPORT_URL=@BVAF_TESTREPORT_URL,");
			strSql.Append("BVAF_TESTPOINTDRAWING_URL=@BVAF_TESTPOINTDRAWING_URL,");
			strSql.Append("BVAF_InstallationComplete_WC_ID=@BVAF_InstallationComplete_WC_ID,");
			strSql.Append("BVAF__NORMALUSE_WC_ID=@BVAF__NORMALUSE_WC_ID,");
			strSql.Append("BVAF_CREATEDATA=@BVAF_CREATEDATA,");
			strSql.Append("BVAF_ISDEL=@BVAF_ISDEL");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BVAF_PROGRAM_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVAF_TESTREPORT_URL", MySqlDbType.Int32,11),
					new MySqlParameter("@BVAF_TESTPOINTDRAWING_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVAF_InstallationComplete_WC_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVAF__NORMALUSE_WC_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVAF_CREATEDATA", MySqlDbType.Datetime),
					new MySqlParameter("@BVAF_ISDEL", MySqlDbType.VarChar,1),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.BVAF_PROGRAM_ID;
			parameters[1].Value = model.BVAF_TESTREPORT_URL;
			parameters[2].Value = model.BVAF_TESTPOINTDRAWING_URL;
			parameters[3].Value = model.BVAF_InstallationComplete_WC_ID;
			parameters[4].Value = model.BVAF__NORMALUSE_WC_ID;
			parameters[5].Value = model.BVAF_CREATEDATA;
			parameters[6].Value = model.BVAF_ISDEL;
			parameters[7].Value = model.id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from buildingvibrationairfloatationplatform ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from buildingvibrationairfloatationplatform ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SgnalProcess.Model.buildingvibrationairfloatationplatform GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,BVAF_PROGRAM_ID,BVAF_TESTREPORT_URL,BVAF_TESTPOINTDRAWING_URL,BVAF_InstallationComplete_WC_ID,BVAF__NORMALUSE_WC_ID,BVAF_CREATEDATA,BVAF_ISDEL from buildingvibrationairfloatationplatform ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			SgnalProcess.Model.buildingvibrationairfloatationplatform model=new SgnalProcess.Model.buildingvibrationairfloatationplatform();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SgnalProcess.Model.buildingvibrationairfloatationplatform DataRowToModel(DataRow row)
		{
			SgnalProcess.Model.buildingvibrationairfloatationplatform model=new SgnalProcess.Model.buildingvibrationairfloatationplatform();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["BVAF_PROGRAM_ID"]!=null && row["BVAF_PROGRAM_ID"].ToString()!="")
				{
					model.BVAF_PROGRAM_ID=int.Parse(row["BVAF_PROGRAM_ID"].ToString());
				}
				if(row["BVAF_TESTREPORT_URL"]!=null && row["BVAF_TESTREPORT_URL"].ToString()!="")
				{
					model.BVAF_TESTREPORT_URL=int.Parse(row["BVAF_TESTREPORT_URL"].ToString());
				}
				if(row["BVAF_TESTPOINTDRAWING_URL"]!=null)
				{
					model.BVAF_TESTPOINTDRAWING_URL=row["BVAF_TESTPOINTDRAWING_URL"].ToString();
				}
				if(row["BVAF_InstallationComplete_WC_ID"]!=null && row["BVAF_InstallationComplete_WC_ID"].ToString()!="")
				{
					model.BVAF_InstallationComplete_WC_ID=int.Parse(row["BVAF_InstallationComplete_WC_ID"].ToString());
				}
				if(row["BVAF__NORMALUSE_WC_ID"]!=null && row["BVAF__NORMALUSE_WC_ID"].ToString()!="")
				{
					model.BVAF__NORMALUSE_WC_ID=int.Parse(row["BVAF__NORMALUSE_WC_ID"].ToString());
				}
				if(row["BVAF_CREATEDATA"]!=null && row["BVAF_CREATEDATA"].ToString()!="")
				{
					model.BVAF_CREATEDATA=DateTime.Parse(row["BVAF_CREATEDATA"].ToString());
				}
				if(row["BVAF_ISDEL"]!=null)
				{
					model.BVAF_ISDEL=row["BVAF_ISDEL"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,BVAF_PROGRAM_ID,BVAF_TESTREPORT_URL,BVAF_TESTPOINTDRAWING_URL,BVAF_InstallationComplete_WC_ID,BVAF__NORMALUSE_WC_ID,BVAF_CREATEDATA,BVAF_ISDEL ");
			strSql.Append(" FROM buildingvibrationairfloatationplatform ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM buildingvibrationairfloatationplatform ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from buildingvibrationairfloatationplatform T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "buildingvibrationairfloatationplatform";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

