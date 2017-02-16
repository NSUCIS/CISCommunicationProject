Imports System.Data.OleDb

Public Class DBManager
    'Variables declared once but reused
    Private dataSourceString As String = "Data Source=" & My.Application.Info.DirectoryPath & "\CIS Communications Contacts.accdb"
    Private connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & dataSourceString
    Private con As OleDbConnection = New OleDbConnection(connString)
    Private da As OleDbDataAdapter
    Private cmd As OleDbCommand
    'Private tableUpdate As OleDbCommandBuilder
    Dim ds As DataSet
    Dim tables As DataTableCollection

    ' Debug & Info Variables
    Public Exception As String

    Public Sub Query(Query As String)
        Try
            con.Open()
            cmd = New OleDbCommand(Query, con)
            da = New OleDbDataAdapter(cmd)
            con.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        'Make sure con is closed no matter what
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Public Sub Delete(Table As String, ID As String)
        Try
            Dim delString = "delete * from [" & Table & "] where ID = " & ID
            cmd = New OleDbCommand(delString, con)
            con.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Public Function FillTable(Table As String) As DataView
        Dim view As New DataView
        ds = New DataSet
        tables = ds.Tables
        Try
            con.Open()
            Dim qstring As String = "Select * from [" & Table & "]"
            da = New OleDbDataAdapter(qstring, con)
            da.Fill(ds, Table)
            view = New DataView(tables(0))
            con.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        'Make sure con is closed no matter what
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return view
    End Function
End Class
