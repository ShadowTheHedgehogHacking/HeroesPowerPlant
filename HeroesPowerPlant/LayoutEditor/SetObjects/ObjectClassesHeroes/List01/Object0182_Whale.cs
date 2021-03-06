﻿using SharpDX;

namespace HeroesPowerPlant.LayoutEditor
{
    public class Object0182_Whale : SetObjectHeroes
    {
        private Matrix triggerMatrix;

        public override void CreateTransformMatrix()
        {
            base.CreateTransformMatrix();

            triggerMatrix = Matrix.Scaling(TriggerSize) * Matrix.Translation(TriggerX, TriggerY, TriggerZ);

            CreateBoundingBox();
        }

        public override void Draw(SharpRenderer renderer)
        {
            base.Draw(renderer);

            if (isSelected)
                renderer.DrawSphereTrigger(triggerMatrix, true);
        }

        public byte WhaleType
        {
            get => ReadByte(4);
            set => Write(4, value);
        }

        public short TriggerSize
        {
            get => ReadShort(6);
            set => Write(6, value);
        }

        public float WhaleScale
        {
            get => ReadFloat(8);
            set => Write(8, value);
        }

        public float ArchRadius
        {
            get => ReadFloat(12);
            set => Write(12, value);
        }

        public float TriggerX
        {
            get => ReadFloat(16);
            set => Write(16, value);
        }

        public float TriggerY
        {
            get => ReadFloat(20);
            set => Write(20, value);
        }

        public float TriggerZ
        {
            get => ReadFloat(24);
            set => Write(24, value);
        }
    }
}
