﻿namespace HeroesPowerPlant.LayoutEditor
{
    public class Object1102_CastleWall : SetObjectManagerHeroes
    {
        public override void Draw(SharpRenderer renderer, string[] modelNames, bool isSelected)
        {
            if (ModelNumber == 0)
            {
                Draw(renderer, modelNames[0], isSelected);
                Draw(renderer, modelNames[1], isSelected);
            }
            else
            {
                Draw(renderer, modelNames[2], isSelected);
                Draw(renderer, modelNames[3], isSelected);
            }
        }

        public int ModelNumber
        {
            get => ReadInt(4);
            set => Write(4, value);
        }

        public bool IsUpsideDown
        {
            get => ReadInt(8) != 0;
            set => Write(8, value ? 1 : 0);
        }
    }
}
