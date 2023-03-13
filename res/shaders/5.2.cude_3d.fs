#version 330 core
out vec4 FragColor;
in vec2 texCoord;

uniform sampler2D ourTexture0;
uniform sampler2D ourTexture1;
uniform float mix_factor;

void main()
{
    FragColor = mix(texture(ourTexture0, texCoord), texture(ourTexture1, texCoord), mix_factor);
}