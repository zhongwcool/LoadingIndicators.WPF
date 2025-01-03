using CommunityToolkit.Mvvm.ComponentModel;

namespace Sample;

public class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        SpeedRatio = 1.0;
        IsArcsActive = true;
        IsArcActive = true;
        IsArcsRingActive = true;
        IsDoubleBounceActive = true;
        IsFlipPlaneActive = true;
        IsPulseActive = true;
        IsRingActive = true;
        IsThreeDotsActive = true;
        IsWaveActive = true;
    }

    private double _speedratio = 1.0;

    // Properties
    public double SpeedRatio
    {
        get => _speedratio;
        set
        {
            SetProperty(ref _speedratio, value);
            OnPropertyChanged(nameof(SpeedRatioText));
        }
    }

    public string SpeedRatioText => SpeedRatio.ToString();

    private bool _isArcActive;

    public bool IsArcActive
    {
        get => _isArcActive;
        set => SetProperty(ref _isarcsactive, value);
    }

    private bool _isarcsactive;

    public bool IsArcsActive
    {
        get => _isarcsactive;
        set => SetProperty(ref _isarcsactive, value);
    }

    private bool _isarcsringactive;

    public bool IsArcsRingActive
    {
        get => _isarcsringactive;
        set => SetProperty(ref _isarcsringactive, value);
    }

    private bool _isdoublebounceactive;

    public bool IsDoubleBounceActive
    {
        get => _isdoublebounceactive;
        set => SetProperty(ref _isdoublebounceactive, value);
    }

    private bool _isflipplaneactive;

    public bool IsFlipPlaneActive
    {
        get => _isflipplaneactive;
        set => SetProperty(ref _isflipplaneactive, value);
    }

    private bool _ispulseactive;

    public bool IsPulseActive
    {
        get => _ispulseactive;
        set => SetProperty(ref _ispulseactive, value);
    }

    private bool _isringactive;

    public bool IsRingActive
    {
        get => _isringactive;
        set => SetProperty(ref _isringactive, value);
    }

    private bool _isthreedotsactive;

    public bool IsThreeDotsActive
    {
        get => _isthreedotsactive;
        set => SetProperty(ref _isthreedotsactive, value);
    }

    private bool _iswaveactive;

    public bool IsWaveActive
    {
        get => _iswaveactive;
        set => SetProperty(ref _iswaveactive, value);
    }
}