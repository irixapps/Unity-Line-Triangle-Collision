# Unity-Point-in-Polygon-Collision

Experiments with collision detection between 2 cubes using a point in polygon approach.

Which becomes a line to plane comparison, in the case of 2 cubes each line cube compared against each plane of the face of the other cube.

Given unity planes are made up of triangles, this becomes a line vs triangle intesection test, which has a fast alorithm in the [Moller Trumore](http://webserver2.tecgraf.puc-rio.br/~mgattass/cg/trbRR/Fast%20MinimumStorage%20RayTriangle%20Intersection.pdf) algorithm



**References**

https://forum.unity.com/threads/hit-point-for-moller-trumbore-triangle-intersection.457106/

http://answers.unity3d.com/questions/861719/a-fast-triangle-triangle-intersection-algorithm-fo.html

Other Unity Compatible geometry solutions 
https://github.com/gradientspace/geometry3Sharp

