using CommunityToolkit.Mvvm.ComponentModel;
using P06_01_DI_Contactos_TAPIADOR_rodrigo.Data.Entities;
using P06_01_DI_Contactos_TAPIADOR_rodrigo.Services.Services;
using System.Collections.ObjectModel;
using System.Windows;

namespace P06_01_DI_Contactos_TAPIADOR_rodrigo.UI.ViewModels;

partial class ProductViewModel : ObservableObject
{
    private readonly IRepositoryService<Product> _productService;

    [ObservableProperty]
    private ObservableCollection<Product> _products;

    public ProductViewModel(IRepositoryService<Product> productService)
    {
        _productService = productService;
        _products = new(productService.GetAll());
        MessageBox.Show("hay " + _products.Count() + " productos");
    }
}
