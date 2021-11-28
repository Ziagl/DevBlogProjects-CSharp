using Blazor.Extensions.Canvas.Canvas2D;

namespace BlazorWebAssemblyCanvas.Models;

public class Agent
{
    public Agent(double x, double y)
    {
        Random random = new Random();
        Pos = new Vector(x, y);
        Vel = new Vector(random.NextDouble() * (random.Next(0,1)==0?-1.0:1.0), random.NextDouble() * (random.Next(0, 1) == 0 ? -1.0 : 1.0));
        Radius = random.Next(4,12);
    }

    public void Bounce(int width, int height)
    {
        if(Pos.X <= 0 || Pos.X >= width)
        {
            Vel.X *= -1.0;
        }
        if(Pos.Y <= 0 || Pos.Y >= height)
        {
            Vel.Y *= -1.0;
        }
    }

    public void Update(float time)
    {
        Pos.X += Vel.X * time;
        Pos.Y += Vel.Y * time;
    }

    public async Task Draw(Canvas2DContext context)
    {
        await context.SaveAsync();
        await context.TranslateAsync(Pos.X, Pos.Y);
        await context.SetLineWidthAsync(4);
        await context.BeginPathAsync();
        await context.ArcAsync(0, 0, Radius, 0, Math.PI * 2);
        await context.FillAsync();
        await context.StrokeAsync();
        await context.RestoreAsync();
    }

    public int Radius { get; }
    public Vector Pos { get; private set; }
    public Vector Vel { get; private set; }
}