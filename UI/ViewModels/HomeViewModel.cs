using CommunityToolkit.Mvvm.ComponentModel;
using P06_01_DI_Contactos_TAPIADOR_rodrigo.Data.Entities;
using P06_01_DI_Contactos_TAPIADOR_rodrigo.Services.Services;
using System.Collections.ObjectModel;

namespace P06_01_DI_Contactos_TAPIADOR_rodrigo.UI.ViewModels;

partial class HomeViewModel(IRepositoryService<Product> productService, IRepositoryService<Category> categoryService) : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Product> _products = new(productService.GetAll());
    [ObservableProperty]
    private ObservableCollection<Category> _categories = new(categoryService.GetAll());

}