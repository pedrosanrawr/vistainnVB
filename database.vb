Imports System.Data.SqlClient
Imports System.Configuration

Public Class Database

    Public ReadOnly Property ConnectionString As String
        Get
            Return ConfigurationManager.ConnectionStrings("vistainnVB.My.MySettings.vistainnMSDBConnectionString").ConnectionString
        End Get
    End Property
End Class
