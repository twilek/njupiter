﻿using System.Data;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace nJupiter.DataAccess {
	public interface IProviderFactory {
		bool CanCreateDataSourceEnumerator { get; }
		IDbCommand CreateCommand();
		IDbConnection CreateConnection();
		IDbDataAdapter CreateDataAdapter();
		IDataParameter CreateParameter();
		DbCommandBuilder CreateCommandBuilder();
		DbConnectionStringBuilder CreateConnectionStringBuilder();
		DbDataSourceEnumerator CreateDataSourceEnumerator();
		CodeAccessPermission CreatePermission(PermissionState state);
	}
}