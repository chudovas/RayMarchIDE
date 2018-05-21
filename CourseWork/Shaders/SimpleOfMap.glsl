vec2 map( in vec3 pos )
{
    // in 2-th coord - material
    vec2 res = vec2(sdPlane(pos), 1.0);

    float c1 = sin(iTime / 3000000.0) * 2;
    float c2 = cos(iTime / 3000000.0) * 2;
    res = opU(res, vec2(0.5 * sdTorus(opTwist(pos - vec3(0.0, 0.45, 0.0), c1, c2),
	               vec2(0.40, 0.1)), abs(c1) * 50));
    return res;
}