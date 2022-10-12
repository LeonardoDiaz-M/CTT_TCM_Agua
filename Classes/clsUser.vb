Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Security.Principal
Imports System.Web.Security
Public Class clsUser
    Public UserName As String = ""
    Public Password As String = ""
    Public UsrErrorMessage As String = ""
    Public Nombre As String = ""
    Public Puesto As String = ""
    Public Oficina As String = ""
    Public ReadOpt As Boolean = False
    Public AddOpt As Boolean = False
    Public DelOpt As Boolean = False
    Public UpdOpt As Boolean = False
    Public Menus As String
    Public CambiaPassword As Boolean = False
    Public ValidaEquipo As Boolean = False
    Private cxn As New cxnData
#Region "SQLStrings"
#End Region
#Region "Login"
    Public Function LoginUser() As Boolean
        Dim ban As Boolean = False
        ' Se valida que el usuario tenga acceso al sistema y ademas que este activo
        Dim SQL_Login As String = "SELECT proUserId,isnull(proValidaUbicacion,0) FROM Users_Profiles WHERE proUserId='" & UserName.Trim & "' 
                                    AND Password=HASHBYTES('SHA2_512', '" & Password.Trim & "'+CAST(UsrKey AS NVARCHAR(36)))
                                    AND proActivo =1"
        Try
            If cxn.Select_SQL(SQL_Login) AndAlso cxn.arrayValores(0) IsNot Nothing Then
                ValidaEquipo = IIf(cxn.arrayValores(1) = True, True, False)
                If cxn.arrayValores(0).ToUpperInvariant = UserName.ToUpperInvariant Then
                    If Obtiene_Oficina() Then
                        ban = True
                    End If
                Else
                    UsrErrorMessage = "Usuario y/o Password incorrecto..."
                End If
            Else
                UsrErrorMessage = "Usuario y/o Password incorrecto..."
            End If
        Catch ex As Exception
            MsgBox("clsUser-LoginUser" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
        Return ban
    End Function
    Public Function checa_Password() As Boolean
        Dim ban As Boolean = False
        Try
            Dim SQL_Login As String = "SELECT UltimoAcceso FROM Users_Profiles WHERE proUserId='" & UserName.Trim & "'"
            If cxn.Select_SQL(SQL_Login) AndAlso cxn.arrayValores(0) IsNot Nothing And cxn.err = "" And cxn.arrayValores(0) <> "" Then
                ban = True
            End If
        Catch ex As Exception
            MsgBox("clsUser-checa_Password" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
        Return ban
    End Function
    Public Function Actualiza_Password()
        Dim ban As Boolean = False
        Try
            Dim SQL_Login As String = "Update Users_Profiles 
                                        set Password=HASHBYTES('SHA2_512', '" & Password.Trim & "'+CAST(UsrKey AS NVARCHAR(36))) ,
                                            UltimoAcceso=dbo.getdateMx()
                                        WHERE proUserId='" & UserName.Trim & "' "
            If cxn.Select_SQL(SQL_Login) AndAlso cxn.arrayValores(0) IsNot Nothing And cxn.err = "" Then
                ban = True
            End If
        Catch ex As Exception
            MsgBox("clsUser-Actualiza_Password" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
        Return ban
    End Function
#End Region
#Region "UserData"
    Public Function Obtiene_Oficina() As Boolean
        Dim ban As Boolean = False
        'Validamos que el usuario tenga asignada una oficina o puesto
        Dim SQL_Oficina As String = "select proNombres +' '+ proApellidoPaterno,pueDescripcion,o.nombre as Oficina
                                    from Users_Profiles up
	                                    inner join Puestos p on p.pueId = up.proIdPuesto 
	                                    inner join oficinas o on o.comun = up.proIdOficina 
                                    where up.proUserId= '" & UserName.Trim & "'"
        Try
            If cxn.Select_SQL(SQL_Oficina) And cxn.arrayValores(0) IsNot Nothing Then
                Nombre = cxn.arrayValores(0)
                Puesto = cxn.arrayValores(1)
                Oficina = cxn.arrayValores(2)
                ban = True
            Else
                UsrErrorMessage = "El usuario no tiene asignado un puesto, contacte al Administrador..."
            End If
        Catch ex As Exception
            MsgBox("clsUser-Obtiene_Oficina" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
        Return ban
    End Function
    Public Function Obtiene_Menus() As Boolean
        Dim SQL_GetRol As String = "SELECT distinct idRol FROM Users_Profiles WHERE proUserId='" & UserName.Trim & "' AND proActivo =1"
        Dim ban As Boolean = False
        Try
            If cxn.Select_SQL(SQL_GetRol) And cxn.arrayValores(0) IsNot Nothing Then
                Dim SQL_GetMenus As String = "select stuff((
                                                select  ','''+idMenu + '''' 
                                                from tbl_Profile where idRol=" & cxn.arrayValores(0) &
                                              " FOR XML PATH('')),1,1,'')"
                If cxn.Select_SQL(SQL_GetMenus) And cxn.arrayValores(0) IsNot Nothing Then
                    Menus = cxn.arrayValores(0).ToString
                Else
                    MsgBox("clsUser-Obtiene_Menus" & vbCrLf & "El Rol no tiene menus asignados...", vbCritical + vbOKOnly, "Error")
                End If
            Else
                MsgBox("clsUser-Obtiene_Menus" & vbCrLf & "El usuario no tiene un Rol asignado...", vbCritical + vbOKOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox("clsUser-Obtiene_Menus" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
        Return ban
    End Function
    Public Function obtiene_Permisos_Menu(idMenu As String) As Boolean
        Dim ban As Boolean = False
        Try
            If cxn.Select_SQL("select Readopt,AddOpt,DelOpt,UpdOpt  
                            from Users_Profiles u
	                            inner join tbl_Profile p on p.idRol = u.idRol 
                            where u.proUserId='" & UserName & "' and idMenu='" & idMenu & "'") Then
                If cxn.arrayValores(0) IsNot Nothing Then
                    ReadOpt = cxn.arrayValores(0)
                    AddOpt = cxn.arrayValores(1)
                    DelOpt = cxn.arrayValores(2)
                    UpdOpt = cxn.arrayValores(3)
                    ban = True
                Else
                    MsgBox("clsUser-Obtiene_Menus" & vbCrLf & "El Usuario no tiene acceso al menu...", vbCritical + vbOKOnly, "Error")
                End If
            Else
                MsgBox("clsUser-Obtiene_Menus" & vbCrLf & cxn.err, vbCritical + vbOKOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox("clsUser-obtiene_Permisos_Menu" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
        Return ban
    End Function

#End Region
#Region "RastreoEquipo"
    <Obsolete>
    Public Function registraEquipo() As Boolean
        Dim ban As Boolean = False
        Dim Mac As String = getMacAddress()
        Dim ipAddress As IPAddress
        Dim ipHostInfo As IPHostEntry = Dns.Resolve(Dns.GetHostName())
        ipAddress = ipHostInfo.AddressList(0)
        Try
            If cxn.Select_SQL("Select PCName from tbl_PCAccess 
                                where PCName='" & My.Computer.Name & "' 
                                and WindowsUser='" & My.User.Name & "' 
                                and MacAddress='" & Mac & "'
                                and UserId='" & UserName & "'") And cxn.err = "" Then
                If cxn.arrayValores(0) Is Nothing Then
                    cxn.Select_SQL("insert into tbl_PCAccess (PCName,IPAddress,
                                                                WindowsUser,UserId,
                                                                UltimoIngreso,FechaRegistro,MacAddress)
                                                            values('" & My.Computer.Name & "','" & ipAddress.ToString & "',
                                                              '" & My.User.Name & "','" & UserName & "',
                                                            dbo.getdateMx(),dbo.getdateMx(),'" & Mac & "')")
                Else
                    cxn.Select_SQL("update tbl_PCAccess set UltimoIngreso=dbo.getdateMx() 
                                            where PCName='" & My.Computer.Name & "' 
                                                    and WindowsUser='" & My.User.Name & "' 
                                                    and MacAddress='" & Mac & "'
                                                    and UserId='" & UserName & "'")
                End If
            Else
                MsgBox("Error registraEquipo" & vbCrLf & cxn.err, vbCritical + vbOKOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox("clsUser-registraEquipo" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
        Return ban
    End Function
    Public Function ValidaUbicacionUsuario() As Boolean
        Dim ban As Boolean = False
        Dim Mac As String = getMacAddress()
        Try
            If cxn.Select_SQL("Select Allowed from tbl_PCAccess 
                                where PCName='" & My.Computer.Name & "' 
                                and WindowsUser='" & My.User.Name & "' 
                                and MacAddress='" & Mac & "'
                                and UserId='" & UserName & "'") And cxn.err = "" Then
                If cxn.arrayValores(0) IsNot Nothing Then
                    If cxn.arrayValores(0) = "True" Or cxn.arrayValores(0) = "1" Then
                        ban = True
                    Else
                        UsrErrorMessage = "El Equipo no esta permitido para iniciar el sistema, contacte al Administrador.."
                    End If
                End If
            End If
        Catch ex As Exception
            UsrErrorMessage = ex.Message
        End Try
        Return ban
    End Function
    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function

#End Region
End Class
