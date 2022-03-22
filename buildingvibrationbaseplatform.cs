using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace SgnalProcess.DAL
{
	/// <summary>
	/// 数据访问类:buildingvibrationbaseplatform
	/// </summary>
	public partial class buildingvibrationbaseplatform
	{
		public buildingvibrationbaseplatform()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "buildingvibrationbaseplatform"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from buildingvibrationbaseplatform");
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
		public bool Add(SgnalProcess.Model.buildingvibrationbaseplatform model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into buildingvibrationbaseplatform(");
			strSql.Append("BVBP_PROGRAM_ID,BVBP_EquipmentInfo_URL,BVBP_CheckNumInfo_URL,BVBP_BasePlatform_URL,BVBP_POWEREQUIPMENT_WC_ID,BVBP_NormalProduction_WC_ID,BVBP_CREATEDATA,BVBP_ISDEL)");
			strSql.Append(" values (");
			strSql.Append("@BVBP_PROGRAM_ID,@BVBP_EquipmentInfo_URL,@BVBP_CheckNumInfo_URL,@BVBP_BasePlatform_URL,@BVBP_POWEREQUIPMENT_WC_ID,@BVBP_NormalProduction_WC_ID,@BVBP_CREATEDATA,@BVBP_ISDEL)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BVBP_PROGRAM_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVBP_EquipmentInfo_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVBP_CheckNumInfo_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVBP_BasePlatform_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVBP_POWEREQUIPMENT_WC_ID", MySqlDbType.Int32,255),
					new MySqlParameter("@BVBP_NormalProduction_WC_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVBP_CREATEDATA", MySqlDbType.Datetime),
					new MySqlParameter("@BVBP_ISDEL", MySqlDbType.VarChar,1)};
			parameters[0].Value = model.BVBP_PROGRAM_ID;
			parameters[1].Value = model.BVBP_EquipmentInfo_URL;
			parameters[2].Value = model.BVBP_CheckNumInfo_URL;
			parameters[3].Value = model.BVBP_BasePlatform_URL;
			parameters[4].Value = model.BVBP_POWEREQUIPMENT_WC_ID;
			parameters[5].Value = model.BVBP_NormalProduction_WC_ID;
			parameters[6].Value = model.BVBP_CREATEDATA;
			parameters[7].Value = model.BVBP_ISDEL;

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
		public bool Update(SgnalProcess.Model.buildingvibrationbaseplatform model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update buildingvibrationbaseplatform set ");
			strSql.Append("BVBP_PROGRAM_ID=@BVBP_PROGRAM_ID,");
			strSql.Append("BVBP_EquipmentInfo_URL=@BVBP_EquipmentInfo_URL,");
			strSql.Append("BVBP_CheckNumInfo_URL=@BVBP_CheckNumInfo_URL,");
			strSql.Append("BVBP_BasePlatform_URL=@BVBP_BasePlatform_URL,");
			strSql.Append("BVBP_POWEREQUIPMENT_WC_ID=@BVBP_POWEREQUIPMENT_WC_ID,");
			strSql.Append("BVBP_NormalProduction_WC_ID=@BVBP_NormalProduction_WC_ID,");
			strSql.Append("BVBP_CREATEDATA=@BVBP_CREATEDATA,");
			strSql.Append("BVBP_ISDEL=@BVBP_ISDEL");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BVBP_PROGRAM_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVBP_EquipmentInfo_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVBP_CheckNumInfo_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVBP_BasePlatform_URL", MySqlDbType.VarChar,255),
					new MySqlParameter("@BVBP_POWEREQUIPMENT_WC_ID", MySqlDbType.Int32,255),
					new MySqlParameter("@BVBP_NormalProduction_WC_ID", MySqlDbType.Int32,11),
					new MySqlParameter("@BVBP_CREATEDATA", MySqlDbType.Datetime),
					new MySqlParameter("@BVBP_ISDEL", MySqlDbType.VarChar,1),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.BVBP_PROGRAM_ID;
			parameters[1].Value = model.BVBP_EquipmentInfo_URL;
			parameters[2].Value = model.BVBP_CheckNumInfo_URL;
			parameters[3].Value = model.BVBP_BasePlatform_URL;
			parameters[4].Value = model.BVBP_POWEREQUIPMENT_WC_ID;
			parameters[5].Value = model.BVBP_NormalProduction_WC_ID;
			parameters[6].Value = model.BVBP_CREATEDATA;
			parameters[7].Value = model.BVBP_ISDEL;
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
			strSql.Append("delete from buildingvibrationbaseplatform ");
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
			strSql.Append("delete from buildingvibrationbaseplatform ");
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
		public SgnalProcess.Model.buildingvibrationbaseplatform GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,BVBP_PROGRAM_ID,BVBP_EquipmentInfo_URL,BVBP_CheckNumInfo_URL,BVBP_BasePlatform_URL,BVBP_POWEREQUIPMENT_WC_ID,BVBP_NormalProduction_WC_ID,BVBP_CREATEDATA,BVBP_ISDEL from buildingvibrationbaseplatform ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			SgnalProcess.Model.buildingvibrationbaseplatform model=new SgnalProcess.Model.buildingvibrationbaseplatform();
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
		public SgnalProcess.Model.buildingvibrationbaseplatform DataRowToModel(DataRow row)
		{
			SgnalProcess.Model.buildingvibrationbaseplatform model=new SgnalProcess.Model.buildingvibrationbaseplatform();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["BVBP_PROGRAM_ID"]!=null && row["BVBP_PROGRAM_ID"].ToString()!="")
				{
					model.BVBP_PROGRAM_ID=int.Parse(row["BVBP_PROGRAM_ID"].ToString());
				}
				if(row["BVBP_EquipmentInfo_URL"]!=null)
				{
					model.BVBP_EquipmentInfo_URL=row["BVBP_EquipmentInfo_URL"].ToString();
				}
				if(row["BVBP_CheckNumInfo_URL"]!=null)
				{
					model.BVBP_CheckNumInfo_URL=row["BVBP_CheckNumInfo_URL"].ToString();
				}
				if(row["BVBP_BasePlatform_URL"]!=null)
				{
					model.BVBP_BasePlatform_URL=row["BVBP_BasePlatform_URL"].ToString();
				}
				if(row["BVBP_POWEREQUIPMENT_WC_ID"]!=null && row["BVBP_POWEREQUIPMENT_WC_ID"].ToString()!="")
				{
					model.BVBP_POWEREQUIPMENT_WC_ID=int.Parse(row["BVBP_POWEREQUIPMENT_WC_ID"].ToString());
				}
				if(row["BVBP_NormalProduction_WC_ID"]!=null && row["BVBP_NormalProduction_WC_ID"].ToString()!="")
				{
					model.BVBP_NormalProduction_WC_ID=int.Parse(row["BVBP_NormalProduction_WC_ID"].ToString());
				}
				if(row["BVBP_CREATEDATA"]!=null && row["BVBP_CREATEDATA"].ToString()!="")
				{
					model.BVBP_CREATEDATA=DateTime.Parse(row["BVBP_CREATEDATA"].ToString());
				}
				if(row["BVBP_ISDEL"]!=null)
				{
					model.BVBP_ISDEL=row["BVBP_ISDEL"].ToString();
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
			strSql.Append("select id,BVBP_PROGRAM_ID,BVBP_EquipmentInfo_URL,BVBP_CheckNumInfo_URL,BVBP_BasePlatform_URL,BVBP_POWEREQUIPMENT_WC_ID,BVBP_NormalProduction_WC_ID,BVBP_CREATEDATA,BVBP_ISDEL ");
			strSql.Append(" FROM buildingvibrationbaseplatform ");
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
			strSql.Append("select count(1) FROM buildingvibrationbaseplatform ");
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
			strSql.Append(")AS Row, T.*  from buildingvibrationbaseplatform T ");
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
			parameters[0].Value = "buildingvibrationbaseplatform";
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

