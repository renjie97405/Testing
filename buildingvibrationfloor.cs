using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace SgnalProcess.DAL
{
	/// <summary>
	/// 数据访问类:buildingvibrationfloor
	/// </summary>
	public partial class buildingvibrationfloor
	{
		public buildingvibrationfloor()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "buildingvibrationfloor"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from buildingvibrationfloor");
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
		public bool Add(SgnalProcess.Model.buildingvibrationfloor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into buildingvibrationfloor(");
			strSql.Append("BVF_PROGRAM_ID,BVF_WORKINGCONDITION_ID,BVF_WCDETAIL_ID,BVF_THINCKNESS,BVF_BASICFORM,BVF_TESTPOINTDRAWING_URL,BVF_CREATEDATA,BVF_ISDEL)");
			strSql.Append(" values (");
			strSql.Append("@BVF_PROGRAM_ID,@BVF_WORKINGCONDITION_ID,@BVF_WCDETAIL_ID,@BVF_THINCKNESS,@BVF_BASICFORM,@BVF_TESTPOINTDRAWING_URL,@BVF_CREATEDATA,@BVF_ISDEL)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BVF_PROGRAM_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVF_WORKINGCONDITION_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVF_WCDETAIL_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVF_THINCKNESS", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVF_BASICFORM", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVF_TESTPOINTDRAWING_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVF_CREATEDATA", MySqlDbType.Datetime),
					new MySqlParameter("@BVF_ISDEL", MySqlDbType.VarChar,1)};
			parameters[0].Value = model.BVF_PROGRAM_ID;
			parameters[1].Value = model.BVF_WORKINGCONDITION_ID;
			parameters[2].Value = model.BVF_WCDETAIL_ID;
			parameters[3].Value = model.BVF_THINCKNESS;
			parameters[4].Value = model.BVF_BASICFORM;
			parameters[5].Value = model.BVF_TESTPOINTDRAWING_URL;
			parameters[6].Value = model.BVF_CREATEDATA;
			parameters[7].Value = model.BVF_ISDEL;

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
		public bool Update(SgnalProcess.Model.buildingvibrationfloor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update buildingvibrationfloor set ");
			strSql.Append("BVF_PROGRAM_ID=@BVF_PROGRAM_ID,");
			strSql.Append("BVF_WORKINGCONDITION_ID=@BVF_WORKINGCONDITION_ID,");
			strSql.Append("BVF_WCDETAIL_ID=@BVF_WCDETAIL_ID,");
			strSql.Append("BVF_THINCKNESS=@BVF_THINCKNESS,");
			strSql.Append("BVF_BASICFORM=@BVF_BASICFORM,");
			strSql.Append("BVF_TESTPOINTDRAWING_URL=@BVF_TESTPOINTDRAWING_URL,");
			strSql.Append("BVF_CREATEDATA=@BVF_CREATEDATA,");
			strSql.Append("BVF_ISDEL=@BVF_ISDEL");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BVF_PROGRAM_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVF_WORKINGCONDITION_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVF_WCDETAIL_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVF_THINCKNESS", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVF_BASICFORM", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVF_TESTPOINTDRAWING_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVF_CREATEDATA", MySqlDbType.Datetime),
					new MySqlParameter("@BVF_ISDEL", MySqlDbType.VarChar,1),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.BVF_PROGRAM_ID;
			parameters[1].Value = model.BVF_WORKINGCONDITION_ID;
			parameters[2].Value = model.BVF_WCDETAIL_ID;
			parameters[3].Value = model.BVF_THINCKNESS;
			parameters[4].Value = model.BVF_BASICFORM;
			parameters[5].Value = model.BVF_TESTPOINTDRAWING_URL;
			parameters[6].Value = model.BVF_CREATEDATA;
			parameters[7].Value = model.BVF_ISDEL;
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
			strSql.Append("delete from buildingvibrationfloor ");
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
			strSql.Append("delete from buildingvibrationfloor ");
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
		public SgnalProcess.Model.buildingvibrationfloor GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,BVF_PROGRAM_ID,BVF_WORKINGCONDITION_ID,BVF_WCDETAIL_ID,BVF_THINCKNESS,BVF_BASICFORM,BVF_TESTPOINTDRAWING_URL,BVF_CREATEDATA,BVF_ISDEL from buildingvibrationfloor ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			SgnalProcess.Model.buildingvibrationfloor model=new SgnalProcess.Model.buildingvibrationfloor();
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
		public SgnalProcess.Model.buildingvibrationfloor DataRowToModel(DataRow row)
		{
			SgnalProcess.Model.buildingvibrationfloor model=new SgnalProcess.Model.buildingvibrationfloor();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["BVF_PROGRAM_ID"]!=null && row["BVF_PROGRAM_ID"].ToString()!="")
				{
					model.BVF_PROGRAM_ID=int.Parse(row["BVF_PROGRAM_ID"].ToString());
				}
				if(row["BVF_WORKINGCONDITION_ID"]!=null && row["BVF_WORKINGCONDITION_ID"].ToString()!="")
				{
					model.BVF_WORKINGCONDITION_ID=int.Parse(row["BVF_WORKINGCONDITION_ID"].ToString());
				}
				if(row["BVF_WCDETAIL_ID"]!=null && row["BVF_WCDETAIL_ID"].ToString()!="")
				{
					model.BVF_WCDETAIL_ID=int.Parse(row["BVF_WCDETAIL_ID"].ToString());
				}
				if(row["BVF_THINCKNESS"]!=null)
				{
					model.BVF_THINCKNESS=row["BVF_THINCKNESS"].ToString();
				}
				if(row["BVF_BASICFORM"]!=null)
				{
					model.BVF_BASICFORM=row["BVF_BASICFORM"].ToString();
				}
				if(row["BVF_TESTPOINTDRAWING_URL"]!=null)
				{
					model.BVF_TESTPOINTDRAWING_URL=row["BVF_TESTPOINTDRAWING_URL"].ToString();
				}
				if(row["BVF_CREATEDATA"]!=null && row["BVF_CREATEDATA"].ToString()!="")
				{
					model.BVF_CREATEDATA=DateTime.Parse(row["BVF_CREATEDATA"].ToString());
				}
				if(row["BVF_ISDEL"]!=null)
				{
					model.BVF_ISDEL=row["BVF_ISDEL"].ToString();
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
			strSql.Append("select id,BVF_PROGRAM_ID,BVF_WORKINGCONDITION_ID,BVF_WCDETAIL_ID,BVF_THINCKNESS,BVF_BASICFORM,BVF_TESTPOINTDRAWING_URL,BVF_CREATEDATA,BVF_ISDEL ");
			strSql.Append(" FROM buildingvibrationfloor ");
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
			strSql.Append("select count(1) FROM buildingvibrationfloor ");
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
			strSql.Append(")AS Row, T.*  from buildingvibrationfloor T ");
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
			parameters[0].Value = "buildingvibrationfloor";
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

