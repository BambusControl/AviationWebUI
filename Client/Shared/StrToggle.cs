namespace AviationWebUI.Shared
{
    public class StrToggle
    {
        // TODO: is this not almost the same as ?
        private readonly string _value;

        public string Value => IsActive ? _value : string.Empty;
        public bool IsActive { get; private set; }

        public StrToggle(string value, bool isActive = true)
        {
            _value = value;
            IsActive = isActive;
        }

        public void Toggle() => IsActive = !IsActive;
        public override string ToString() => Value;
    }
}