# RayMarchIDE
This is IDE for create raymarching examples.
For create new scene - write "map" function in program and compile it. For all changes outside "map" function - 
see the files "RayMarchBegin.glsl" and "RayMarchMain.glsl".

List of available functions: 
```glsl
float sdPlane(vec3 p)
float sdSphere(vec3 p, float r)
float sdBox(vec3 p, vec3 b)
float sdEllipsoid(in vec3 p, in vec3 r)
float udRoundBox(vec3 p, vec3 b, float r)
float sdTorus(vec3 p, vec2 t)
float sdHexPrism(vec3 p, vec2 h)
float sdCapsule(vec3 p, vec3 a, vec3 b, float r)
float sdEquilateralTriangle(in vec2 p)
float sdTriPrism(vec3 p, vec2 h)
float sdCylinder(vec3 p, vec2 h)
float sdCone(in vec3 p, in vec3 c)
float sdConeSection(in vec3 p, in float h, in float r1, in float r2)
float sdPyramid4(vec3 p, vec3 h)
float length2(vec2 p)
float length6(vec2 p)
float length8(vec2 p)
float sdTorus82(vec3 p, vec2 t)
float sdTorus88(vec3 p, vec2 t)
float sdCylinder6(vec3 p, vec2 h)
float opS(float d1, float d2)
vec2 opU(vec2 d1, vec2 d2)
vec3 opRep(vec3 p, vec3 c)
vec3 opTwist(vec3 p, float c1, float c2)
```
