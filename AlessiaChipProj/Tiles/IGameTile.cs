namespace AlessiaChipProj
{
    public interface IGameTile
    {
        int[] location { get; set; }
        bool containsPlayer { get; set; }

        void TogglePlayer();
    }
}