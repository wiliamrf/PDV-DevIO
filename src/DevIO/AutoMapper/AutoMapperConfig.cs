using AutoMapper;
using DevIO.Business.Models;
using DevIO.ViewModels;

namespace DevIO.AutoMapper
{
    public class AutoMapperConfig:Profile
    {

  

        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
