# MauiNameBug

https://github.com/dotnet/maui/issues/8149

## This is a sample demonstrating `x:Name` incorrectly resolving in a RELEASE build.

### Repro project
https://github.com/Keflon/MauiNameBug

### Short version:

1. Create a xaml 'child' `ContentControl` whose root element has `x:Name="Self"`
1. Create a xaml 'Parent' `ContentControl` whose root element also has `x:Name="Self"`
    1. Add a `CollectionView`
    1. Add a `DataTemplate` to the `CollectionView` that instantiates the 'child' `ContentControl`
    1. Databind something in the `DataTemplate` to `x:Reference Self`

In a **DEBUG** build, the `Binding` correctly resolves to an instance of the 'Parent' control  
In a **RELEASE** build, the `Binding` incorrectly resolves to an instance of the 'Child' control  

### Workaround:
If you give elements an `x:Name`, make them unique, including any names in 3rd-party controls.

