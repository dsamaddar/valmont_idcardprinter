Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmIDLoader

    Public dtEmpIDCard As New DataTable()
    Dim EmpData As New clsEmployee()

    Protected Function FormatEmpIDCard() As DataTable
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("EmployeeName", System.Type.GetType("System.String"))
        dt.Columns.Add("EmpCode", System.Type.GetType("System.String"))
        dt.Columns.Add("Designation", System.Type.GetType("System.String"))
        dt.Columns.Add("Section", System.Type.GetType("System.String"))
        dt.Columns.Add("JoiningDate", System.Type.GetType("System.DateTime"))
        dt.Columns.Add("BloodGroup", System.Type.GetType("System.String"))
        dt.Columns.Add("EmpPhoto", System.Type.GetType("System.String"))
        dt.Columns.Add("AltMobile", System.Type.GetType("System.String"))
        dt.Columns.Add("MobileNo", System.Type.GetType("System.String"))
        dt.Columns.Add("NationalID", System.Type.GetType("System.String"))
        dt.Columns.Add("PermanentAddress", System.Type.GetType("System.String"))
        dt.Columns.Add("JoiningDateBangla", System.Type.GetType("System.String"))
        dt.Columns.Add("CardNoBangla", System.Type.GetType("System.String"))
        Return dt
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
     
    End Sub

    Protected Sub PrintIDCard(ByVal StartingCardNo As String, ByVal EndingCardNo As String)
        Dim serverName As [String], uid As [String], pwd As [String], dbName As [String]
        Dim strPath As String = ""
        Dim myImage As System.Drawing.Image
        Dim converter As New System.Drawing.ImageConverter
        Dim myReport As New rptEmpIDCardBangla
        'Dim folder As String
        'Dim f As String
        Dim repName As String

        Try
            dtEmpIDCard = EmpData.fnPrintIDCardBangla(StartingCardNo, EndingCardNo).Tables(0)
            repName = "rptEmpIDCardBangla.rpt"

            dtEmpIDCard.Columns.Add(New DataColumn("Picture", System.Type.GetType("System.Byte[]")))
            dtEmpIDCard.AcceptChanges()
            For Each rw As DataRow In dtEmpIDCard.Rows
                strPath = "\\192.168.100.25\Attachments$\" + rw.Item("EmpPhoto")
                myImage = System.Drawing.Image.FromFile(strPath)
                rw.Item("Picture") = converter.ConvertTo(myImage, System.Type.GetType("System.Byte[]"))
                rw.AcceptChanges()
            Next

            Dim conStr = "Data Source=192.168.100.25;Initial Catalog=ValmontDB;uid=sa;password=Farc1lgh#;"
            Dim retArr As [String](), usrArr As [String](), pwdArr As [String](), serverArr As [String](), dbArr As [String]()

            myReport.Load(repName)

            retArr = conStr.Split(";")
            serverArr = retArr(0).Split("=")
            dbArr = retArr(1).Split("=")
            usrArr = retArr(2).Split("=")
            pwdArr = retArr(3).Split("=")

            serverName = serverArr(1)
            uid = usrArr(1)
            pwd = pwdArr(1)
            dbName = dbArr(1)

            myReport.SetDatabaseLogon(uid, pwd, serverName, dbName)
            myReport.SetDataSource(dtEmpIDCard)
            
            idviewer.ReportSource = myReport
            idviewer.Dock = DockStyle.Fill
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnProcessReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessReport.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            PrintIDCard(txtRangeFrom.Text, txtRangeTo.Text)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
