Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Software ELQUIAULA 1.0."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Contacto Equipo ELQUIDEAS LTDA."

        Return View()
    End Function
End Class
