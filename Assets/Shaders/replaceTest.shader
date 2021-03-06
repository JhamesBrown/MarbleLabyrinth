﻿Shader "Custom/replaceTest" {
	Properties {
		_Color("Color", Color) = (1,1,1,1)
	}
	SubShader {
		Tags { "RenderType"="Opaque" }

		ZWRITE On
		Pass{
			CGPROGRAM

			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				float depth : DEPTH;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.depth = -mul(UNITY_MATRIX_MV, v.vertex).z *_ProjectionParams.w;
				return o;
			}

			half4 _Color;

			fixed4 frag (v2f i) : SV_Target
			{
				float invert = 1 - i.depth;
				return fixed4(-i.vertex.x * _ProjectionParams.w , invert, invert, 1) * _Color;
			}
			ENDCG
		}
	}
	FallBack "Diffuse"
}
