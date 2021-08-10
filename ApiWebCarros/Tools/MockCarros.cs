using Api.Web.Carros.Data;
using Api.Web.Carros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Web.Carros.Tools
{
    public class MockCarros
    {
        private readonly ApplicationDbContext _context;
        public MockCarros(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public  void AddCarrosIniciais()
        {
            List<Carro> Garagem = new List<Carro>
            {
                new Carro { Marca ="Chevrolet", Modelo = "Celta", Ano = 2001, ImgLink = "https://image1.mobiauto.com.br/images/api/images/v1.0/61938562/transform/fl_progressive,f_jpg,q_50,w_768" },
                new Carro { Marca ="Volkwagem", Modelo = "Jetta GLI", Ano = 2019, ImgLink = "https://quatrorodas.abril.com.br/wp-content/uploads/2020/01/vw_golf_r_-_render.jpg" },
                new Carro { Marca ="Volkwagem", Modelo = "GOL", Ano = 2020, ImgLink = "https://quatrorodas.abril.com.br/wp-content/uploads/2020/01/vw_golf_gti_-_render_2020.jpg" },
                 new Carro { Marca ="Fiat", Modelo = "Argo", Ano = 2020, ImgLink = "https://s2.glbimg.com/SnbghEUAAP3LQ2-bQMzzshaZzGo=/0x0:6000x3940/1008x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_59edd422c0c84a879bd37670ae4f538a/internal_photos/bs/2020/d/x/mRAVtPRBqQp245yVLGSg/hgt18dianteira.jpeg" },

            };
            _context.Carros.AddRange(Garagem);
            _context.SaveChanges();
        }

    }
}
