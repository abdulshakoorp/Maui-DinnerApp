using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppIntro.Models;

namespace MauiAppIntro.ViewModels;

public partial class MyBreakfastsViewModel : ObservableObject
{
    [ObservableProperty]
    List<Breakfast> breakfasts;

    [ObservableProperty]
    bool isRefreshing;

    public MyBreakfastsViewModel()
    {
        LoadBreakfastsAsync();
    }

    [RelayCommand]
    public async Task LoadBreakfastsAsync()
    {
        try
        {
            await Task.Delay(2000);
            Breakfasts = new()
            {
                new Breakfast(
                    Name: "Masala Dosa",
                    Description: "Masala..!! Join us for a healthy breakfast,Join us for a healthy breakfast, Join us for a healthy breakfast",
                    StartDateTime: DateTime.UtcNow.AddDays(1),
                    EndDateTime: DateTime.UtcNow.AddDays(1).AddHours(2),
                    Image : new Uri("https://images.unsplash.com/photo-1633204339708-86cc53afb015?ixlib=rb-1.png"),
                    Savory: new List<string>{"Dosa","Baji","Chutney","Avocado Juice","Omelet" },
                    Sweet:new List<string>{"Chikki" }),
                new Breakfast(
                    Name: "Rava Dosa",
                    Description: "Rava..!! Join us for a healthy breakfast, Join us for a healthy breakfast,Join us for a healthy breakfast,Join us for a healthy breakfast,Join us for a healthy breakfast,Join us for a healthy breakfast,Join us for a healthy breakfast",
                    StartDateTime: DateTime.UtcNow.AddDays(1),
                    EndDateTime: DateTime.UtcNow.AddDays(1).AddHours(2),
                    Image : new Uri("https://images.unsplash.com/photo-1633204339708-86.png"),
                    Savory: new List<string>{"Dosa","Chutney","Melon Juice","Salad" },
                    Sweet:new List<string>{"Jalebi" }),
            };

        }
        finally
        {
            IsRefreshing = false;
        }

    }
}

//