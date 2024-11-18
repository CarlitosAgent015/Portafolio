using razor_mvc.Models;

namespace razor_mvc
{
    public class RepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
    {
        return
        [
            new Proyecto
            {
                Titulo="App para certificaciones Microsoft",
                Descripcion="Portal de entrenamiento Tecnologias Microsoft",
                Link = "https://learn.microsoft.com/es-es/certifications/",
                ImagenURL="/images/Wudy.jpeg"
            },
            new Proyecto
            {
                Titulo="Grupo Bancolombia",
                Descripcion="Desarrollo App clientes",
                Link = "https://www.bancolombia.com/personas//",
                ImagenURL="/images/elmo.jpeg"
            },
            new Proyecto
            {
                Titulo="Desarrollo App Virtual Exito",
                Descripcion="Desarrollo App Compras Online Angular",
                Link = "https://www.exito.com//",
                ImagenURL="/images/mika.jpeg"
            },
            new Proyecto
            {
                Titulo="Desarrollo App Simulador de Préstamos",
                Descripcion="Desarrollo App de Préstamos",
                Link = "https://www.bancoldex.com/",
                ImagenURL="/images/spaidi.jpeg"
            }
        ];
    }

    }
}