Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class clsEmployee

    Dim ValmontConn As String = "Data Source=192.168.100.25;Initial Catalog=ValmontDB;uid=sa;password=Farc1lgh#"

    Dim _EmployeeID, _EmployeeName, _EmployeeNameBangla, _EmpCode, _FathersName, _MothersName, _PresentAddress, _PermanentAddress, _MobileNo, _AlternateMobileNo, _MachineNo, _EmpPhoto, _EmpSignature, _
    _BlockID, _SectionID, _DesignationID, _EmpStatus, _EntryBy, _NameorID, _NationalID, _UserID, _UserPassword, _UserType, _BloodGroup, _RFIDCode, _
    _AccessModule, _PermittedMenu, _CardNo, _CardNoBangla, _JoiningDateBangla As String

    Public Property EmployeeID() As String
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As String)
            _EmployeeID = value
        End Set
    End Property

    Public Property EmployeeName() As String
        Get
            Return _EmployeeName
        End Get
        Set(ByVal value As String)
            _EmployeeName = value
        End Set
    End Property

    Public Property EmployeeNameBangla() As String
        Get
            Return _EmployeeNameBangla
        End Get
        Set(ByVal value As String)
            _EmployeeNameBangla = value
        End Set
    End Property

    Public Property EmpCode() As String
        Get
            Return _EmpCode
        End Get
        Set(ByVal value As String)
            _EmpCode = value
        End Set
    End Property

    Public Property FathersName() As String
        Get
            Return _FathersName
        End Get
        Set(ByVal value As String)
            _FathersName = value
        End Set
    End Property

    Public Property MothersName() As String
        Get
            Return _MothersName
        End Get
        Set(ByVal value As String)
            _MothersName = value
        End Set
    End Property

    Public Property PresentAddress() As String
        Get
            Return _PresentAddress
        End Get
        Set(ByVal value As String)
            _PresentAddress = value
        End Set
    End Property

    Public Property PermanentAddress() As String
        Get
            Return _PermanentAddress
        End Get
        Set(ByVal value As String)
            _PermanentAddress = value
        End Set
    End Property

    Public Property MobileNo() As String
        Get
            Return _MobileNo
        End Get
        Set(ByVal value As String)
            _MobileNo = value
        End Set
    End Property

    Public Property AlternateMobileNo() As String
        Get
            Return _AlternateMobileNo
        End Get
        Set(ByVal value As String)
            _AlternateMobileNo = value
        End Set
    End Property

    Public Property MachineNo() As String
        Get
            Return _MachineNo
        End Get
        Set(ByVal value As String)
            _MachineNo = value
        End Set
    End Property

    Public Property EmpPhoto() As String
        Get
            Return _EmpPhoto
        End Get
        Set(ByVal value As String)
            _EmpPhoto = value
        End Set
    End Property

    Public Property EmpSignature() As String
        Get
            Return _EmpSignature
        End Get
        Set(ByVal value As String)
            _EmpSignature = value
        End Set
    End Property

    Public Property BlockID() As String
        Get
            Return _BlockID
        End Get
        Set(ByVal value As String)
            _BlockID = value
        End Set
    End Property

    Public Property SectionID() As String
        Get
            Return _SectionID
        End Get
        Set(ByVal value As String)
            _SectionID = value
        End Set
    End Property

    Public Property DesignationID() As String
        Get
            Return _DesignationID
        End Get
        Set(ByVal value As String)
            _DesignationID = value
        End Set
    End Property

    Public Property EmpStatus() As String
        Get
            Return _EmpStatus
        End Get
        Set(ByVal value As String)
            _EmpStatus = value
        End Set
    End Property

    Public Property EntryBy() As String
        Get
            Return _EntryBy
        End Get
        Set(ByVal value As String)
            _EntryBy = value
        End Set
    End Property

    Public Property NameorID() As String
        Get
            Return _NameorID
        End Get
        Set(ByVal value As String)
            _NameorID = value
        End Set
    End Property

    Public Property NationalID() As String
        Get
            Return _NationalID
        End Get
        Set(ByVal value As String)
            _NationalID = value
        End Set
    End Property

    Public Property UserID() As String
        Get
            Return _UserID
        End Get
        Set(ByVal value As String)
            _UserID = value
        End Set
    End Property

    Public Property UserPassword() As String
        Get
            Return _UserPassword
        End Get
        Set(ByVal value As String)
            _UserPassword = value
        End Set
    End Property

    Public Property UserType() As String
        Get
            Return _UserType
        End Get
        Set(ByVal value As String)
            _UserType = value
        End Set
    End Property

    Public Property BloodGroup() As String
        Get
            Return _BloodGroup
        End Get
        Set(ByVal value As String)
            _BloodGroup = value
        End Set
    End Property

    Public Property RFIDCode() As String
        Get
            Return _RFIDCode
        End Get
        Set(ByVal value As String)
            _RFIDCode = value
        End Set
    End Property

    Public Property AccessModule() As String
        Get
            Return _AccessModule
        End Get
        Set(ByVal value As String)
            _AccessModule = value
        End Set
    End Property

    Public Property PermittedMenu() As String
        Get
            Return _PermittedMenu
        End Get
        Set(ByVal value As String)
            _PermittedMenu = value
        End Set
    End Property

    Public Property JoiningDateBangla() As String
        Get
            Return _JoiningDateBangla
        End Get
        Set(ByVal value As String)
            _JoiningDateBangla = value
        End Set
    End Property

    Dim _IsActive, _InCludedInPayroll As Boolean

    Public Property IsActive() As Boolean
        Get
            Return _IsActive
        End Get
        Set(ByVal value As Boolean)
            _IsActive = value
        End Set
    End Property

    Public Property InCludedInPayroll() As Boolean
        Get
            Return _InCludedInPayroll
        End Get
        Set(ByVal value As Boolean)
            _InCludedInPayroll = value
        End Set
    End Property

    Dim _EntryDate, _JoiningDate As DateTime

    Public Property EntryDate() As DateTime
        Get
            Return _EntryDate
        End Get
        Set(ByVal value As DateTime)
            _EntryDate = value
        End Set
    End Property

    Public Property JoiningDate() As DateTime
        Get
            Return _JoiningDate
        End Get
        Set(ByVal value As DateTime)
            _JoiningDate = value
        End Set
    End Property

    Dim _BasicSalary As Double

    Public Property BasicSalary() As Double
        Get
            Return _BasicSalary
        End Get
        Set(ByVal value As Double)
            _BasicSalary = value
        End Set
    End Property

    Dim _PresentDistrictID, _PresentUpazilaID, _PermanentDistrictID, _PermanentUpazilaID As Integer

    Public Property PresentDistrictID() As Integer
        Get
            Return _PresentDistrictID
        End Get
        Set(ByVal value As Integer)
            _PresentDistrictID = value
        End Set
    End Property

    Public Property PresentUpazilaID() As Integer
        Get
            Return _PresentUpazilaID
        End Get
        Set(ByVal value As Integer)
            _PresentUpazilaID = value
        End Set
    End Property

    Public Property PermanentDistrictID() As Integer
        Get
            Return _PermanentDistrictID
        End Get
        Set(ByVal value As Integer)
            _PermanentDistrictID = value
        End Set
    End Property

    Public Property PermanentUpazilaID() As Integer
        Get
            Return _PermanentUpazilaID
        End Get
        Set(ByVal value As Integer)
            _PermanentUpazilaID = value
        End Set
    End Property

    Public Property CardNo() As String
        Get
            Return _CardNo
        End Get
        Set(ByVal value As String)
            _CardNo = value
        End Set
    End Property

    Public Property CardNoBangla() As String
        Get
            Return _CardNoBangla
        End Get
        Set(ByVal value As String)
            _CardNoBangla = value
        End Set
    End Property

#Region " Print ID Card Bangla "

    Public Function fnPrintIDCardBangla(ByVal StartingCardNo As String, ByVal EndingCardNo As String) As DataSet
        Dim sp As String = "spPrintIDCardBangla"
        Dim ds As New DataSet
        Using con As New SqlConnection(ValmontConn)
            Dim cmd As New SqlCommand(sp, con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@StartingCardNo", StartingCardNo)
            cmd.Parameters.AddWithValue("@EndingCardNo", EndingCardNo)
            con.Open()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(ds)
            con.Close()
            Return ds
        End Using
    End Function

#End Region

End Class
