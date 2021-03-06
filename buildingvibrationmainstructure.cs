using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
using Maticsoft.DBUtility;
namespace SgnalProcess.DAL
{
	/// <summary>
	/// 数据访问类:buildingvibrationmainstructure
	/// </summary>
	public partial class buildingvibrationmainstructure
	{
		public buildingvibrationmainstructure()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "buildingvibrationmainstructure"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from buildingvibrationmainstructure");
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
		public bool Add(SgnalProcess.Model.buildingvibrationmainstructure model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into buildingvibrationmainstructure(");
			strSql.Append("BVM_PROGRAM_ID,BVM_MTCSDDRAWING_URL,BVM_VibrationPointDrawing_URL,BVM_MODELTEST_WC_ID,BVM_VIBRATIONTEST_TYPE,BVM_VIBRATIONTEST_WC_ID,BVM_CREATEDATA,BVM_ISDEL)");
			strSql.Append(" values (");
			strSql.Append("@BVM_PROGRAM_ID,@BVM_MTCSDDRAWING_URL,@BVM_VibrationPointDrawing_URL,@BVM_MODELTEST_WC_ID,@BVM_VIBRATIONTEST_TYPE,@BVM_VIBRATIONTEST_WC_ID,@BVM_CREATEDATA,@BVM_ISDEL)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BVM_PROGRAM_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVM_MTCSDDRAWING_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVM_VibrationPointDrawing_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVM_MODELTEST_WC_ID", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVM_VIBRATIONTEST_TYPE", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVM_VIBRATIONTEST_WC_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVM_CREATEDATA", MySqlDbType.Datetime),
					new MySqlParameter("@BVM_ISDEL", MySqlDbType.VarChar,1)};
			parameters[0].Value = model.BVM_PROGRAM_ID;
			parameters[1].Value = model.BVM_MTCSDDRAWING_URL;
			parameters[2].Value = model.BVM_VibrationPointDrawing_URL;
			parameters[3].Value = model.BVM_MODELTEST_WC_ID;
			parameters[4].Value = model.BVM_VIBRATIONTEST_TYPE;
			parameters[5].Value = model.BVM_VIBRATIONTEST_WC_ID;
			parameters[6].Value = model.BVM_CREATEDATA;
			parameters[7].Value = model.BVM_ISDEL;

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
		public bool Update(SgnalProcess.Model.buildingvibrationmainstructure model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update buildingvibrationmainstructure set ");
			strSql.Append("BVM_PROGRAM_ID=@BVM_PROGRAM_ID,");
			strSql.Append("BVM_MTCSDDRAWING_URL=@BVM_MTCSDDRAWING_URL,");
			strSql.Append("BVM_VibrationPointDrawing_URL=@BVM_VibrationPointDrawing_URL,");
			strSql.Append("BVM_MODELTEST_WC_ID=@BVM_MODELTEST_WC_ID,");
			strSql.Append("BVM_VIBRATIONTEST_TYPE=@BVM_VIBRATIONTEST_TYPE,");
			strSql.Append("BVM_VIBRATIONTEST_WC_ID=@BVM_VIBRATIONTEST_WC_ID,");
			strSql.Append("BVM_CREATEDATA=@BVM_CREATEDATA,");
			strSql.Append("BVM_ISDEL=@BVM_ISDEL");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BVM_PROGRAM_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVM_MTCSDDRAWING_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVM_VibrationPointDrawing_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVM_MODELTEST_WC_ID", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVM_VIBRATIONTEST_TYPE", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVM_VIBRATIONTEST_WC_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVM_CREATEDATA", MySqlDbType.Datetime),
					new MySqlParameter("@BVM_ISDEL", MySqlDbType.VarChar,1),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.BVM_PROGRAM_ID;
			parameters[1].Value = model.BVM_MTCSDDRAWING_URL;
			parameters[2].Value = model.BVM_VibrationPointDrawing_URL;
			parameters[3].Value = model.BVM_MODELTEST_WC_ID;
			parameters[4].Value = model.BVM_VIBRATIONTEST_TYPE;
			parameters[5].Value = model.BVM_VIBRATIONTEST_WC_ID;
			parameters[6].Value = model.BVM_CREATEDATA;
			parameters[7].Value = model.BVM_ISDEL;
			parameters[8].Value = model.id;

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
			strSql.Append("delete from buildingvibrationmainstructure ");
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
			strSql.Append("delete from buildingvibrationmainstructure ");
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
		public SgnalProcess.Model.buildingvibrationmainstructure GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,BVM_PROGRAM_ID,BVM_MTCSDDRAWING_URL,BVM_VibrationPointDrawing_URL,BVM_MODELTEST_WC_ID,BVM_VIBRATIONTEST_TYPE,BVM_VIBRATIONTEST_WC_ID,BVM_CREATEDATA,BVM_ISDEL from buildingvibrationmainstructure ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			SgnalProcess.Model.buildingvibrationmainstructure model=new SgnalProcess.Model.buildingvibrationmainstructure();
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
		public SgnalProcess.Model.buildingvibrationmainstructure DataRowToModel(DataRow row)
		{
			SgnalProcess.Model.buildingvibrationmainstructure model=new SgnalProcess.Model.buildingvibrationmainstructure();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["BVM_PROGRAM_ID"]!=null && row["BVM_PROGRAM_ID"].ToString()!="")
				{
					model.BVM_PROGRAM_ID=int.Parse(row["BVM_PROGRAM_ID"].ToString());
				}
				if(row["BVM_MTCSDDRAWING_URL"]!=null)
				{
					model.BVM_MTCSDDRAWING_URL=row["BVM_MTCSDDRAWING_URL"].ToString();
				}
				if(row["BVM_VibrationPointDrawing_URL"]!=null)
				{
					model.BVM_VibrationPointDrawing_URL=row["BVM_VibrationPointDrawing_URL"].ToString();
				}
				if(row["BVM_MODELTEST_WC_ID"]!=null)
				{
					model.BVM_MODELTEST_WC_ID=row["BVM_MODELTEST_WC_ID"].ToString();
				}
				if(row["BVM_VIBRATIONTEST_TYPE"]!=null)
				{
					model.BVM_VIBRATIONTEST_TYPE=row["BVM_VIBRATIONTEST_TYPE"].ToString();
				}
				if(row["BVM_VIBRATIONTEST_WC_ID"]!=null && row["BVM_VIBRATIONTEST_WC_ID"].ToString()!="")
				{
					model.BVM_VIBRATIONTEST_WC_ID=int.Parse(row["BVM_VIBRATIONTEST_WC_ID"].ToString());
				}
				if(row["BVM_CREATEDATA"]!=null && row["BVM_CREATEDATA"].ToString()!="")
				{
					model.BVM_CREATEDATA=DateTime.Parse(row["BVM_CREATEDATA"].ToString());
				}
				if(row["BVM_ISDEL"]!=null)
				{
					model.BVM_ISDEL=row["BVM_ISDEL"].ToString();
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
			strSql.Append("select id,BVM_PROGRAM_ID,BVM_MTCSDDRAWING_URL,BVM_VibrationPointDrawing_URL,BVM_MODELTEST_WC_ID,BVM_VIBRATIONTEST_TYPE,BVM_VIBRATIONTEST_WC_ID,BVM_CREATEDATA,BVM_ISDEL ");
			strSql.Append(" FROM buildingvibrationmainstructure ");
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
			strSql.Append("select count(1) FROM buildingvibrationmainstructure ");
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
			strSql.Append(")AS Row, T.*  from buildingvibrationmainstructure T ");
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
			parameters[0].Value = "buildingvibrationmainstructure";
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

