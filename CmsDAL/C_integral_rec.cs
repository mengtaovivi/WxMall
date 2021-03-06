﻿/**  版本信息模板在安装目录下，可自行修改。
* C_integral_rec.cs
*
* 功 能： N/A
* 类 名： C_integral_rec
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/2/4 10:53:11   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Cms.DBUtility;//Please add references
namespace Cms.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:C_integral_rec
	/// </summary>
	public partial class C_integral_rec
	{
		public C_integral_rec()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "C_integral_rec"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from C_integral_rec");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Cms.Model.C_integral_rec model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into C_integral_rec(");
			strSql.Append("article_id,user_id,usercard,openid,numberid,scorename,title,wescore,quantity,type,updateTime)");
			strSql.Append(" values (");
			strSql.Append("@article_id,@user_id,@usercard,@openid,@numberid,@scorename,@title,@wescore,@quantity,@type,@updateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@article_id", SqlDbType.Int,4),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@usercard", SqlDbType.VarChar,150),
					new SqlParameter("@openid", SqlDbType.VarChar,350),
					new SqlParameter("@numberid", SqlDbType.VarChar,150),
					new SqlParameter("@scorename", SqlDbType.VarChar,150),
					new SqlParameter("@title", SqlDbType.VarChar,150),
					new SqlParameter("@wescore", SqlDbType.BigInt,8),
					new SqlParameter("@quantity", SqlDbType.Int,4),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@updateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.article_id;
			parameters[1].Value = model.user_id;
			parameters[2].Value = model.usercard;
			parameters[3].Value = model.openid;
			parameters[4].Value = model.numberid;
			parameters[5].Value = model.scorename;
			parameters[6].Value = model.title;
			parameters[7].Value = model.wescore;
			parameters[8].Value = model.quantity;
			parameters[9].Value = model.type;
			parameters[10].Value = model.updateTime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Cms.Model.C_integral_rec model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update C_integral_rec set ");
			strSql.Append("article_id=@article_id,");
			strSql.Append("user_id=@user_id,");
			strSql.Append("usercard=@usercard,");
			strSql.Append("openid=@openid,");
			strSql.Append("numberid=@numberid,");
			strSql.Append("scorename=@scorename,");
			strSql.Append("title=@title,");
			strSql.Append("wescore=@wescore,");
			strSql.Append("quantity=@quantity,");
			strSql.Append("type=@type,");
			strSql.Append("updateTime=@updateTime");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@article_id", SqlDbType.Int,4),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@usercard", SqlDbType.VarChar,150),
					new SqlParameter("@openid", SqlDbType.VarChar,350),
					new SqlParameter("@numberid", SqlDbType.VarChar,150),
					new SqlParameter("@scorename", SqlDbType.VarChar,150),
					new SqlParameter("@title", SqlDbType.VarChar,150),
					new SqlParameter("@wescore", SqlDbType.BigInt,8),
					new SqlParameter("@quantity", SqlDbType.Int,4),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.article_id;
			parameters[1].Value = model.user_id;
			parameters[2].Value = model.usercard;
			parameters[3].Value = model.openid;
			parameters[4].Value = model.numberid;
			parameters[5].Value = model.scorename;
			parameters[6].Value = model.title;
			parameters[7].Value = model.wescore;
			parameters[8].Value = model.quantity;
			parameters[9].Value = model.type;
			parameters[10].Value = model.updateTime;
			parameters[11].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			strSql.Append("delete from C_integral_rec ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			strSql.Append("delete from C_integral_rec ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Cms.Model.C_integral_rec GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,article_id,user_id,usercard,openid,numberid,scorename,title,wescore,quantity,type,updateTime from C_integral_rec ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Cms.Model.C_integral_rec model=new Cms.Model.C_integral_rec();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
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
		public Cms.Model.C_integral_rec DataRowToModel(DataRow row)
		{
			Cms.Model.C_integral_rec model=new Cms.Model.C_integral_rec();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["article_id"]!=null && row["article_id"].ToString()!="")
				{
					model.article_id=int.Parse(row["article_id"].ToString());
				}
				if(row["user_id"]!=null && row["user_id"].ToString()!="")
				{
					model.user_id=int.Parse(row["user_id"].ToString());
				}
				if(row["usercard"]!=null)
				{
					model.usercard=row["usercard"].ToString();
				}
				if(row["openid"]!=null)
				{
					model.openid=row["openid"].ToString();
				}
				if(row["numberid"]!=null)
				{
					model.numberid=row["numberid"].ToString();
				}
				if(row["scorename"]!=null)
				{
					model.scorename=row["scorename"].ToString();
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["wescore"]!=null && row["wescore"].ToString()!="")
				{
					model.wescore=long.Parse(row["wescore"].ToString());
				}
				if(row["quantity"]!=null && row["quantity"].ToString()!="")
				{
					model.quantity=int.Parse(row["quantity"].ToString());
				}
				if(row["type"]!=null && row["type"].ToString()!="")
				{
					model.type=int.Parse(row["type"].ToString());
				}
				if(row["updateTime"]!=null && row["updateTime"].ToString()!="")
				{
					model.updateTime=DateTime.Parse(row["updateTime"].ToString());
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
			strSql.Append("select id,article_id,user_id,usercard,openid,numberid,scorename,title,wescore,quantity,type,updateTime ");
			strSql.Append(" FROM C_integral_rec ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,article_id,user_id,usercard,openid,numberid,scorename,title,wescore,quantity,type,updateTime ");
			strSql.Append(" FROM C_integral_rec ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM C_integral_rec ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
			strSql.Append(")AS Row, T.*  from C_integral_rec T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "C_integral_rec";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

