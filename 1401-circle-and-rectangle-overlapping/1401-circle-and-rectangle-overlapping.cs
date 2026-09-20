public class Solution {
    public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2) {
        int closestX = Math.Max(x1, Math.Min(xCenter, x2));
        int closestY = Math.Max(y1, Math.Min(yCenter, y2));

        int dx = xCenter - closestX;
        int dy = yCenter - closestY;

        return dx * dx + dy * dy <= radius * radius;

    }
}