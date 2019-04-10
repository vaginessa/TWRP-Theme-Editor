﻿Namespace Objects.Elements
    Public Class Text : Inherits ElementBase

#Region "Properties"
        Property Font As String
        Property FontColor As String
        Property Text As String
#End Region

#Region "Constructor"
        Sub New(ByVal Placement As Placement, ByVal Conditions As List(Of Condition), ByVal Actions As List(Of Objects.Action), ByVal Font As String, ByVal FontColor As String, ByVal Text As String)
            Me.Placement = Placement
            Me.Conditions = Conditions
            Me.Actions = Actions
            Me.Font = Font
            Me.FontColor = FontColor
            Me.Text = Text
        End Sub
#End Region

    End Class
End Namespace