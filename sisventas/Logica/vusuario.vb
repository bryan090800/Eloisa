﻿Public Class vusuario
    Dim idusuario As Integer
    Dim nombre, apellidos, cedula, direccion, telefono, login, password, acceso As String

    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(value)
            idusuario = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(value)
            apellidos = value
        End Set
    End Property

    Public Property gcedula
        Get
            Return cedula
        End Get
        Set(value)
            cedula = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property

    Public Property glogin
        Get
            Return login
        End Get
        Set(value)
            login = value
        End Set
    End Property

    Public Property gpassword
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property

    Public Property gacceso
        Get
            Return acceso
        End Get
        Set(value)
            acceso = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idusuario As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal cedula As String, ByVal direccion As String, ByVal telefono As String, ByVal login As String, ByVal password As String, ByVal acceso As String)

        gidusuario = idusuario
        gnombre = nombre
        gapellidos = apellidos
        gcedula = cedula
        gdireccion = direccion
        gtelefono = telefono
        glogin = login
        gpassword = password
        gacceso = acceso

    End Sub

End Class
