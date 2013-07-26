using System;
using System.Collections.Generic;
using System.Data;

namespace PetaPoco
{
	public interface IDatabase
	{
		int ExecuteStoredProcedure(string procedureName, IEnumerable<IDbDataParameter> parameters);
		int Execute(string sql, params object[] args);
		int Execute(Sql sql);
		T ExecuteScalarStoredProcedure<T>(string sql, params object[] args);
		T ExecuteScalarStoredProcedure<T>(string sql, IEnumerable<IDbDataParameter> parameters);
		T ExecuteScalar<T>(string sql, params object[] args);
		T ExecuteScalar<T>(string sql, bool isSP, params object[] args);
		T ExecuteScalar<T>(Sql sql);
		List<T> Fetch<T>(string sql, params object[] args);
		List<T> FetchStoredProcedure<T>(string sql, params object[] args);
		List<T> FetchStoredProcedure<T>(string sql, IEnumerable<IDbDataParameter> parameters);
		List<T> Fetch<T>(Sql sql);
		Page<T> Page<T>(long page, long itemsPerPage, string sql, params object[] args);
		Page<T> Page<T>(long page, long itemsPerPage, Sql sql);
		List<T> Fetch<T>(long page, long itemsPerPage, string sql, params object[] args);
		List<T> Fetch<T>(long page, long itemsPerPage, Sql sql);
		List<T> SkipTake<T>(long skip, long take, string sql, params object[] args);
		List<T> SkipTake<T>(long skip, long take, Sql sql);
		IEnumerable<T> Query<T>(string sql, params object[] args);
		IEnumerable<TRet> Query<TRet>(Type[] types, object cb, string sql, params object[] args);
		IEnumerable<T> Query<T>(Sql sql);
		T Single<T>(object primaryKey);
		T SingleOrDefault<T>(object primaryKey);
		T Single<T>(string sql, params object[] args);
		T SingleOrDefault<T>(string sql, params object[] args);
		T First<T>(string sql, params object[] args);
		T FirstOrDefault<T>(string sql, params object[] args);
		T Single<T>(Sql sql);
		T SingleOrDefault<T>(Sql sql);
		T First<T>(Sql sql);
		T FirstOrDefault<T>(Sql sql);
		object Insert(string tableName, string primaryKeyName, object poco);
		object Insert(string tableName, string primaryKeyName, bool autoIncrement, object poco);
		object Insert(object poco);
		int Update(string tableName, string primaryKeyName, object poco, object primaryKeyValue);
		int Update(string tableName, string primaryKeyName, object poco, object primaryKeyValue, IEnumerable<string> columns);
		int Update(string tableName, string primaryKeyName, object poco);
		int Update(string tableName, string primaryKeyName, object poco, IEnumerable<string> columns);
		int Update(object poco, IEnumerable<string> columns);
		int Update(object poco);
		int Update(object poco, object primaryKeyValue);
		int Update(object poco, object primaryKeyValue, IEnumerable<string> columns);
		int Update<T>(string sql, params object[] args);
		int Update<T>(Sql sql);
		int Delete(string tableName, string primaryKeyName, object poco);
		int Delete(string tableName, string primaryKeyName, object poco, object primaryKeyValue);
		int Delete(object poco);
		int Delete<T>(object pocoOrPrimaryKey);
		int Delete<T>(string sql, params object[] args);
		int Delete<T>(Sql sql);
		void Save(string tableName, string primaryKeyName, object poco);
		void Save(object poco);
	}
}