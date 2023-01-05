using CommunityToolkit.Mvvm.ComponentModel;

namespace TicTakToUsingMAUI.ViewModels;
public class MainPageVM : ObservableObject
{
    int i;
    public MainPageVM()
    {
        i = 0;
        BoxClickedCommand = new Command<String>(BoxClicked);
        ClearBordCommand = new Command(ClearBord);

    }

    private void BoxClicked(String BoxNumber)
    {
        i++;
        if (i % 2 == 0)
        {
            if (BoxNumber == "00" && B00 == null)
                B00 = "X";
            else if (BoxNumber == "01" && B01 == null)
                B01 = "X";
            else if (BoxNumber == "02" && B02 == null)
                B02 = "X";
            else if (BoxNumber == "10" && B10 == null)
                B10 = "X";
            else if (BoxNumber == "11" && B11 == null)
                B11 = "X";
            else if (BoxNumber == "12" && B12 == null)
                B12 = "X";
            else if (BoxNumber == "20" && B20 == null)
                B20 = "X";
            else if (BoxNumber == "21" && B21 == null)
                B21 = "X";
            else if (BoxNumber == "22" && B22 == null)
                B22 = "X";
            else
                i--;
        }
        else
        {
            if (BoxNumber == "00" && B00 == null)
                B00 = "O";
            else if (BoxNumber == "01" && B01 == null)
                B01 = "O";
            else if (BoxNumber == "02" && B02 == null)
                B02 = "O";
            else if (BoxNumber == "10" && B10 == null)
                B10 = "O";
            else if (BoxNumber == "11" && B11 == null)
                B11 = "O";
            else if (BoxNumber == "12" && B12 == null)
                B12 = "O";
            else if (BoxNumber == "20" && B20 == null)
                B20 = "O";
            else if (BoxNumber == "21" && B21 == null)
                B21 = "O";
            else if (BoxNumber == "22" && B22 == null)
                B22 = "O";
            else
                i--;
        }

        string str = Gameresult();
        if (str != null)
        {
            Application.Current.MainPage.DisplayAlert("Game Finished", str, "ok");
            ClearBord();
        }
    }


    private string Gameresult()
    {
        if (B00 == B01 && B01 == B02 && B00 != null)
            return B00 + " won the game";
        else if (B10 == B11 && B11 == B12 && B10 != null)
            return B10 + " won the game";
        else if (B20 == B21 && B21 == B22 && B20 != null)
            return B20 + " won the game";
        else if (B00 == B10 && B10 == B20 && B00 != null)
            return B00 + " won the game";
        else if (B01 == B11 && B11 == B21 && B01 != null)
            return B01 + " won the game";
        else if (B02 == B12 && B12 == B22 && B02 != null)
            return B02 + " won the game";
        else if (B00 == B11 && B11 == B22 && B00 != null)
            return B00 + " won the game";
        else if (B02 == B11 && B11 == B20 && B02 != null)
            return B02 + " won the game";
        else if (B00 != null && B01 != null && B02 != null && B10 != null && B11 != null && B12 != null && B20 != null && B21 != null && B22 != null)
            return "Match Draw";
        return null;
    }

    private void ClearBord()
    {
        B00 = null;
        B01 = null;
        B02 = null;
        B10 = null;
        B11 = null;
        B12 = null;
        B20 = null;
        B21 = null;
        B22 = null;
    }

    public Command BoxClickedCommand { get; set; }

    public Command ClearBordCommand { get; set; }


    private string _b00;
    public string B00
    {
        get => _b00;
        set
        {
            _b00 = value;
            OnPropertyChanged();
        }
    }

    private string _b01;
    public string B01
    {
        get => _b01;
        set
        {
            _b01 = value;
            OnPropertyChanged();
        }
    }

    private string _b02;
    public string B02
    {
        get => _b02;
        set
        {
            _b02 = value;
            OnPropertyChanged();
        }
    }

    private string _b10;
    public string B10
    {
        get => _b10;
        set
        {
            _b10 = value;
            OnPropertyChanged();
        }
    }

    private string _b11;
    public string B11
    {
        get => _b11;
        set
        {
            _b11 = value;
            OnPropertyChanged();
        }
    }

    private string _b12;
    public string B12
    {
        get => _b12;
        set
        {
            _b12 = value;
            OnPropertyChanged();
        }
    }

    private string _b20;
    public string B20
    {
        get => _b20;
        set
        {
            _b20 = value;
            OnPropertyChanged();
        }
    }

    private string _b21;
    public string B21
    {
        get => _b21;
        set
        {
            _b21 = value;
            OnPropertyChanged();
        }
    }

    private string _b22;
    public string B22
    {
        get => _b22;
        set
        {
            _b22 = value;
            OnPropertyChanged();
        }
    }
}