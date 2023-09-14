# Darts Game

## Task description

Implement a [GetScore](DartsGame/Darts.cs#L13) method that calculates the earned points in a single toss of a Darts game. In the game, the target rewards with 4 different amounts of points, depending on where the dart lands:
- if the dart lands outside the target, player earns no points (0 points);
- if the dart lands in the outer circle of the target, player earns 1 point;
- if the dart lands in the middle circle of the target, player earns 5 points;
- if the dart lands in the inner circle of the target, player earns 10 points.  
The outer circle has a radius of 10 units (This is equivalent to the total radius for the entire target), the middle circle a radius of 5 units, and the inner circle a radius of 1. Of course, they are all centered to the same point (That is, the circles are concentric) defined by the coordinates (0, 0). The task definition is given in the XML-comments for the method.