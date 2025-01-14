using System;
using System.Collections;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
using OpenTK3_StandardTemplate_WinForms.helpers;

namespace OpenTK3_StandardTemplate_WinForms.objects
{
    class Cube
    {
        private ArrayList coordonates;
        private ArrayList colors;
        private int textureId;
        private PolygonMode currentPolygonState = PolygonMode.Fill;
        private bool visibility;
       

        public Cube()
        {
            coordonates = new ArrayList
            {
                new Coords(0, 0, 0),
                new Coords(15, 0, 0),
                new Coords(15, 15, 0),
                new Coords(0, 15, 0),
                new Coords(0, 0, 15),
                new Coords(15, 0, 15),
                new Coords(15, 15, 15),
                new Coords(0, 15, 15)
            };

            colors = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                colors.Add(Randomizer.GetRandomColor());
            }

            visibility = true;
            textureId = 0;
        }

        public bool GetVisibility()
        {
            return visibility;
        }

        public void SetVisibility(bool _visibility)
        {
            visibility = _visibility;
        }

        public void Show()
        {
            visibility = true;
        }

        public void Hide()
        {
            visibility = false;
        }

        public void ToggleVisibility()
        {
            visibility = !visibility;
        }

        public void PolygonDrawingStyle(string style)
        {
            if (style == "line")
            {
                currentPolygonState = PolygonMode.Line;
                return;
            }

            if (style == "surface")
            {
                currentPolygonState = PolygonMode.Fill;
                return;
            }
        }

        public void SetTexture(int textureId)
        {
            this.textureId = textureId;
        }

        public void DrawBigCube(float alpha = 1.0f)
        {
            if (!visibility)
            {
                return;
            }

            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            GL.PolygonMode(MaterialFace.FrontAndBack, currentPolygonState);

            if (textureId != 0)
            {
                GL.Enable(EnableCap.Texture2D);
                GL.BindTexture(TextureTarget.Texture2D, textureId);
                GL.Color4(1.0f, 1.0f, 1.0f, alpha);
            }
            else
            {
                GL.Disable(EnableCap.Texture2D);
            }

            int[,] faces = {
                { 0, 1, 2, 3 },
                { 4, 5, 6, 7 },
                { 0, 1, 5, 4 },
                { 2, 3, 7, 6 },
                { 0, 3, 7, 4 },
                { 1, 2, 6, 5 }
            };

            GL.Begin(PrimitiveType.Quads);
            for (int i = 0; i < faces.GetLength(0); i++)
            {
                for (int j = 0; j < faces.GetLength(1); j++)
                {
                    int vertexIndex = faces[i, j];
                    Coords coord = (Coords)coordonates[vertexIndex];

                    if (textureId == 0)
                    {
                        Color color = (Color)colors[vertexIndex];
                        GL.Color4(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, alpha);
                    }

                    if (textureId != 0)
                    {
                        switch (j)
                        {
                            case 0:
                                GL.TexCoord2(0.0f, 0.0f);
                                break;
                            case 1:
                                GL.TexCoord2(1.0f, 0.0f);
                                break;
                            case 2:
                                GL.TexCoord2(1.0f, 1.0f);
                                break;
                            case 3:
                                GL.TexCoord2(0.0f, 1.0f);
                                break;
                        }
                    }

                    GL.Vertex3(coord.X, coord.Y, coord.Z);
                }
            }
            GL.End();

            if (textureId != 0)
            {
                GL.Disable(EnableCap.Texture2D);
            }

            GL.Disable(EnableCap.Blend);
        }

        public void DrawSmallCube()
        {
            if (!visibility)
            {
                return;
            }

            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            GL.PolygonMode(MaterialFace.FrontAndBack, currentPolygonState);

            Coords[] vertices = {
                new Coords(-16, 0, 0),
                new Coords(-11, 0, 0),
                new Coords(-11, 5, 0),
                new Coords(-16, 5, 0),
                new Coords(-16, 0, 5),
                new Coords(-11, 0, 5),
                new Coords(-11, 5, 5),
                new Coords(-16, 5, 5)
            };

            int[,] faces = {
                { 0, 1, 2, 3 },
                { 4, 5, 6, 7 },
                { 0, 1, 5, 4 },
                { 2, 3, 7, 6 },
                { 0, 3, 7, 4 },
                { 1, 2, 6, 5 }
            };

            GL.Begin(PrimitiveType.Quads);
            for (int i = 0; i < faces.GetLength(0); i++)
            {
                GL.Color4(0.0f, 0.0f, 1.0f, 1.0f);
                for (int j = 0; j < faces.GetLength(1); j++)
                {
                    Coords coord = vertices[faces[i, j]];
                    GL.Vertex3(coord.X, coord.Y, coord.Z);
                }
            }
            GL.End();

            GL.Disable(EnableCap.Blend);
        }

        public void DrawCube(float bigCubeAlpha = 1.0f)
        {
            DrawSmallCube();
            DrawBigCube(bigCubeAlpha);
        }
    }
}