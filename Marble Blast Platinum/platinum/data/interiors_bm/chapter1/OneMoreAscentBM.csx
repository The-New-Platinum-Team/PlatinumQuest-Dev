<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2022/07/23 13:54:18">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="271">
                    <Brush id="0" owner="0" type="0" pos="0 0 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 3" />
                            <Vertex pos="3 3 -3" />
                            <Vertex pos="3 -3 3" />
                            <Vertex pos="3 -3 -3" />
                            <Vertex pos="-3 3 3" />
                            <Vertex pos="-3 3 -3" />
                            <Vertex pos="-3 -3 3" />
                            <Vertex pos="-3 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile05_B" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="0 -6 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -6 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 3" />
                            <Vertex pos="3 3 -3" />
                            <Vertex pos="3 -3 3" />
                            <Vertex pos="3 -3 -3" />
                            <Vertex pos="-3 3 3" />
                            <Vertex pos="-3 3 -3" />
                            <Vertex pos="-3 -3 3" />
                            <Vertex pos="-3 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile05_B" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="0 -12 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -12 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 3" />
                            <Vertex pos="3 3 -3" />
                            <Vertex pos="3 -3 3" />
                            <Vertex pos="3 -3 -3" />
                            <Vertex pos="-3 3 3" />
                            <Vertex pos="-3 3 -3" />
                            <Vertex pos="-3 -3 3" />
                            <Vertex pos="-3 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile05_B" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="0 -18 0.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -18 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 3" />
                            <Vertex pos="3 3 -3" />
                            <Vertex pos="3 -3 3" />
                            <Vertex pos="3 -3 -3" />
                            <Vertex pos="-3 3 3" />
                            <Vertex pos="-3 3 -3" />
                            <Vertex pos="-3 -3 3" />
                            <Vertex pos="-3 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile05_B" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="0 -24 1.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -24 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 3" />
                            <Vertex pos="3 3 -3" />
                            <Vertex pos="3 -3 3" />
                            <Vertex pos="3 -3 -3" />
                            <Vertex pos="-3 3 3" />
                            <Vertex pos="-3 3 -3" />
                            <Vertex pos="-3 -3 3" />
                            <Vertex pos="-3 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile05_B" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-3 -30 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -30 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 3" />
                            <Vertex pos="6 3 -3" />
                            <Vertex pos="6 -3 3" />
                            <Vertex pos="6 -3 -3" />
                            <Vertex pos="-6 3 3" />
                            <Vertex pos="-6 3 -3" />
                            <Vertex pos="-6 -3 3" />
                            <Vertex pos="-6 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile05_B" texgens="1 0 0 -1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-11 -30 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 -30 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.25" />
                            <Vertex pos="2 3 -0.25" />
                            <Vertex pos="2 -3 0.25" />
                            <Vertex pos="2 -3 -0.25" />
                            <Vertex pos="-2 3 0.25" />
                            <Vertex pos="-2 3 -0.25" />
                            <Vertex pos="-2 -3 0.25" />
                            <Vertex pos="-2 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile02_C" texgens="1 0 0 0 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-17 -30 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -30 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.25" />
                            <Vertex pos="2 3 -0.25" />
                            <Vertex pos="2 -3 0.25" />
                            <Vertex pos="2 -3 -0.25" />
                            <Vertex pos="-2 3 0.25" />
                            <Vertex pos="-2 3 -0.25" />
                            <Vertex pos="-2 -3 0.25" />
                            <Vertex pos="-2 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile02_C" texgens="1 0 0 0 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-14 -30 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -30 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.25" />
                            <Vertex pos="1 3 -0.25" />
                            <Vertex pos="1 -3 0.25" />
                            <Vertex pos="1 -3 -0.25" />
                            <Vertex pos="-1 3 0.25" />
                            <Vertex pos="-1 3 -0.25" />
                            <Vertex pos="-1 -3 0.25" />
                            <Vertex pos="-1 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile01_D" texgens="1 0 0 256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-23 -30 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 -30 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.25" />
                            <Vertex pos="2 3 -0.25" />
                            <Vertex pos="2 -3 0.25" />
                            <Vertex pos="2 -3 -0.25" />
                            <Vertex pos="-2 3 0.25" />
                            <Vertex pos="-2 3 -0.25" />
                            <Vertex pos="-2 -3 0.25" />
                            <Vertex pos="-2 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile02_C" texgens="1 0 0 0 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-20 -30 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -30 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.25" />
                            <Vertex pos="1 3 -0.25" />
                            <Vertex pos="1 -3 0.25" />
                            <Vertex pos="1 -3 -0.25" />
                            <Vertex pos="-1 3 0.25" />
                            <Vertex pos="-1 3 -0.25" />
                            <Vertex pos="-1 -3 0.25" />
                            <Vertex pos="-1 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile01_D" texgens="1 0 0 256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-29 -30 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -30 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.25" />
                            <Vertex pos="2 3 -0.25" />
                            <Vertex pos="2 -3 0.25" />
                            <Vertex pos="2 -3 -0.25" />
                            <Vertex pos="-2 3 0.25" />
                            <Vertex pos="-2 3 -0.25" />
                            <Vertex pos="-2 -3 0.25" />
                            <Vertex pos="-2 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile02_C" texgens="1 0 0 0 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-26 -30 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 -30 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.25" />
                            <Vertex pos="1 3 -0.25" />
                            <Vertex pos="1 -3 0.25" />
                            <Vertex pos="1 -3 -0.25" />
                            <Vertex pos="-1 3 0.25" />
                            <Vertex pos="-1 3 -0.25" />
                            <Vertex pos="-1 -3 0.25" />
                            <Vertex pos="-1 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile01_D" texgens="1 0 0 256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-35 -31 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 -31 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 12" />
                            <Vertex pos="4 4 -12" />
                            <Vertex pos="4 -4 12" />
                            <Vertex pos="4 -4 -12" />
                            <Vertex pos="-4 4 12" />
                            <Vertex pos="-4 4 -12" />
                            <Vertex pos="-4 -4 12" />
                            <Vertex pos="-4 -4 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile02_C" texgens="1 0 0 -512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-45 -29 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -45 0 1 0 -29 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 12" />
                            <Vertex pos="6 2 -12" />
                            <Vertex pos="6 -2 12" />
                            <Vertex pos="6 -2 -12" />
                            <Vertex pos="-6 2 12" />
                            <Vertex pos="-6 2 -12" />
                            <Vertex pos="-6 -2 12" />
                            <Vertex pos="-6 -2 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile02_C" texgens="1 0 0 -1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-43 -33 -3" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 -33 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 7.5" />
                            <Vertex pos="4 2 -16.5" />
                            <Vertex pos="4 -2 7.5" />
                            <Vertex pos="4 -2 -16.5" />
                            <Vertex pos="-4 2 16.5" />
                            <Vertex pos="-4 2 -16.5" />
                            <Vertex pos="-4 -2 16.5" />
                            <Vertex pos="-4 -2 -16.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.747409 0 0.664364 -7.97237" album="" material="bm_friction_mud" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.5" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-50 -33 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -50 0 1 0 -33 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 17" />
                            <Vertex pos="1 2 -17" />
                            <Vertex pos="1 -2 17" />
                            <Vertex pos="1 -2 -17" />
                            <Vertex pos="-1 2 17" />
                            <Vertex pos="-1 2 -17" />
                            <Vertex pos="-1 -2 17" />
                            <Vertex pos="-1 -2 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile02_C" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-57 -29 -5" rot="1 0 0 0" scale="" transform="1 0 0 -57 0 1 0 -29 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 9.5" />
                            <Vertex pos="6 2 -14.5" />
                            <Vertex pos="6 -2 9.5" />
                            <Vertex pos="6 -2 -14.5" />
                            <Vertex pos="-6 2 14.5" />
                            <Vertex pos="-6 2 -14.5" />
                            <Vertex pos="-6 -2 14.5" />
                            <Vertex pos="-6 -2 -14.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.384615 0 0.923077 -11.0769" album="" material="bm_tile02_C" texgens="1 0 0 -1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.5" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-57 -33 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -57 0 1 0 -33 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 17" />
                            <Vertex pos="6 2 -17" />
                            <Vertex pos="6 -2 17" />
                            <Vertex pos="6 -2 -17" />
                            <Vertex pos="-6 2 12" />
                            <Vertex pos="-6 2 -17" />
                            <Vertex pos="-6 -2 12" />
                            <Vertex pos="-6 -2 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.384615 0 0.923077 -13.3846" album="" material="bm_tile02_C" texgens="1 0 0 -1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="-65 -31 -5" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 -31 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 14.5" />
                            <Vertex pos="2 4 -14.5" />
                            <Vertex pos="2 -4 14.5" />
                            <Vertex pos="2 -4 -14.5" />
                            <Vertex pos="-2 4 14.5" />
                            <Vertex pos="-2 4 -14.5" />
                            <Vertex pos="-2 -4 14.5" />
                            <Vertex pos="-2 -4 -14.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14.5" album="" material="bm_tile02_C" texgens="1 0 0 0 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.5" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-48 -33 -3" rot="1 0 0 0" scale="" transform="1 0 0 -48 0 1 0 -33 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 16.5" />
                            <Vertex pos="1 2 -16.5" />
                            <Vertex pos="1 -2 16.5" />
                            <Vertex pos="1 -2 -16.5" />
                            <Vertex pos="-1 2 16.5" />
                            <Vertex pos="-1 2 -16.5" />
                            <Vertex pos="-1 -2 16.5" />
                            <Vertex pos="-1 -2 -16.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16.5" album="" material="bm_friction_bounce_med" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-27 -33 20" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 -33 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-21 -33 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 -33 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 2" />
                            <Vertex pos="4 2 1" />
                            <Vertex pos="4 -2 2" />
                            <Vertex pos="4 -2 1" />
                            <Vertex pos="-4 2 -1" />
                            <Vertex pos="-4 2 -2" />
                            <Vertex pos="-4 -2 -1" />
                            <Vertex pos="-4 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0.375 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -768 0.375 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.351123 0 0.936329 -0.468165" album="" material="bm_tile07_B" texgens="1 0 0 1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.351123 0 -0.936329 -0.468165" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-15 -35 23" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -35 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.5" />
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="2 -4 -0.5" />
                            <Vertex pos="-2 4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 -4 0.5" />
                            <Vertex pos="-2 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="-15 -43 24" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -43 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 4 -1.5" />
                            <Vertex pos="2 -4 1.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 4 -1.5" />
                            <Vertex pos="-2 -4 1.5" />
                            <Vertex pos="-2 -4 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.485071" album="" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-19 -47 25" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 -47 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 4 -1.5" />
                            <Vertex pos="2 -4 1.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 4 -1.5" />
                            <Vertex pos="-2 -4 1.5" />
                            <Vertex pos="-2 -4 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.485071" album="" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-19 -55 26" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 -55 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.5" />
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="2 -4 -0.5" />
                            <Vertex pos="-2 4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 -4 0.5" />
                            <Vertex pos="-2 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-15 -73 26" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -73 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.5" />
                            <Vertex pos="2 6 -0.5" />
                            <Vertex pos="2 -6 0.5" />
                            <Vertex pos="2 -6 -0.5" />
                            <Vertex pos="-2 6 0.5" />
                            <Vertex pos="-2 6 -0.5" />
                            <Vertex pos="-2 -6 0.5" />
                            <Vertex pos="-2 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-7 -77 27.5" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -77 0 0 1 27.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 2" />
                            <Vertex pos="6 2 1" />
                            <Vertex pos="6 -2 2" />
                            <Vertex pos="6 -2 1" />
                            <Vertex pos="-6 2 -1" />
                            <Vertex pos="-6 2 -2" />
                            <Vertex pos="-6 -2 -1" />
                            <Vertex pos="-6 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -2304 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.485071" album="" material="bm_tile07_B" texgens="1 0 0 1536 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.485071" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="1 -81 29.5" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -81 0 0 1 29.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 2" />
                            <Vertex pos="6 2 1" />
                            <Vertex pos="6 -2 2" />
                            <Vertex pos="6 -2 1" />
                            <Vertex pos="-6 2 -0.999998" />
                            <Vertex pos="-6 2 -2" />
                            <Vertex pos="-6 -2 -0.999998" />
                            <Vertex pos="-6 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -2304 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0.25 0 -1 128.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0.25 0 -1 128.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242535 0 0.970143 -0.485072" album="" material="bm_tile07_B" texgens="1 0 0 1536 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.485071" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="11 -83 31" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 -83 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_B" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="13 -91 32" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -91 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 4 -1.5" />
                            <Vertex pos="2 -4 1.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 4 -1.5" />
                            <Vertex pos="-2 -4 1.5" />
                            <Vertex pos="-2 -4 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.485071" album="" material="bm_tile07_B" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="17 -97 33.5" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -97 0 0 1 33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 -1" />
                            <Vertex pos="2 6 -2" />
                            <Vertex pos="2 -6 2" />
                            <Vertex pos="2 -6 1" />
                            <Vertex pos="-2 6 -1" />
                            <Vertex pos="-2 6 -2" />
                            <Vertex pos="-2 -6 2" />
                            <Vertex pos="-2 -6 1" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.485071" album="" material="bm_tile07_B" texgens="1 0 0 1536 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -0.485071" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="13 -103 35" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -103 0 0 1 35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 4 -1.5" />
                            <Vertex pos="2 -4 1.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 4 -1.5" />
                            <Vertex pos="-2 -4 1.5" />
                            <Vertex pos="-2 -4 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.485071" album="" material="bm_tile07_B" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="9 -113 36" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 -113 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 0.5" />
                            <Vertex pos="6 6 -0.5" />
                            <Vertex pos="6 -6 0.5" />
                            <Vertex pos="6 -6 -0.5" />
                            <Vertex pos="-6 6 0.5" />
                            <Vertex pos="-6 6 -0.5" />
                            <Vertex pos="-6 -6 0.5" />
                            <Vertex pos="-6 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-3 -117 37.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -117 0 0 1 37.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 -1" />
                            <Vertex pos="6 2 -2" />
                            <Vertex pos="6 -2 -1" />
                            <Vertex pos="6 -2 -2" />
                            <Vertex pos="-6 2 2" />
                            <Vertex pos="-6 2 1" />
                            <Vertex pos="-6 -2 2" />
                            <Vertex pos="-6 -2 1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -2304 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.485071" album="" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.485071" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="-11 -113 39.5" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 -113 0 0 1 39.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 -1" />
                            <Vertex pos="6 2 -2" />
                            <Vertex pos="6 -2 -1" />
                            <Vertex pos="6 -2 -2" />
                            <Vertex pos="-6 2 2" />
                            <Vertex pos="-6 2 1" />
                            <Vertex pos="-6 -2 2" />
                            <Vertex pos="-6 -2 1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -2304 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.485071" album="" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.485071" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="-19 -109 41.5" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 -109 0 0 1 41.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 -1" />
                            <Vertex pos="6 2 -2" />
                            <Vertex pos="6 -2 -1" />
                            <Vertex pos="6 -2 -2" />
                            <Vertex pos="-6 2 2" />
                            <Vertex pos="-6 2 1" />
                            <Vertex pos="-6 -2 2" />
                            <Vertex pos="-6 -2 1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -2304 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.485071" album="" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.485071" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="-31 -109 43" rot="1 0 0 0" scale="" transform="1 0 0 -31 0 1 0 -109 0 0 1 43 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 0.5" />
                            <Vertex pos="6 2 -0.5" />
                            <Vertex pos="6 -2 0.5" />
                            <Vertex pos="6 -2 -0.5" />
                            <Vertex pos="-6 2 0.5" />
                            <Vertex pos="-6 2 -0.5" />
                            <Vertex pos="-6 -2 0.5" />
                            <Vertex pos="-6 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_B" texgens="1 0 0 -512 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="-51 -89 43" rot="1 0 0 0" scale="" transform="1 0 0 -51 0 1 0 -89 0 0 1 43 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.5" />
                            <Vertex pos="2 6 -0.5" />
                            <Vertex pos="2 -6 0.5" />
                            <Vertex pos="2 -6 -0.5" />
                            <Vertex pos="-2 6 0.5" />
                            <Vertex pos="-2 6 -0.5" />
                            <Vertex pos="-2 -6 0.5" />
                            <Vertex pos="-2 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_B" texgens="1 0 0 -512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-51 -59 47" rot="1 0 0 0" scale="" transform="1 0 0 -51 0 1 0 -59 0 0 1 47 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.5" />
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="2 -4 -0.5" />
                            <Vertex pos="-2 4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 -4 0.5" />
                            <Vertex pos="-2 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_B" texgens="1 0 0 -512 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-51 -51 47" rot="1 0 0 0" scale="" transform="1 0 0 -51 0 1 0 -51 0 0 1 47 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_B" texgens="1 0 0 -1024 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="11 -83 5.5" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 -83 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 25" />
                            <Vertex pos="4 4 -25" />
                            <Vertex pos="4 -4 25" />
                            <Vertex pos="4 -4 -25" />
                            <Vertex pos="-4 4 25" />
                            <Vertex pos="-4 4 -25" />
                            <Vertex pos="-4 -4 25" />
                            <Vertex pos="-4 -4 -25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank2" texgens="0 1 0 -256 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 -256 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -25" album="" material="bm_tile07_B" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -25" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="9 -113 8" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 -113 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 27.5" />
                            <Vertex pos="6 6 -27.5" />
                            <Vertex pos="6 -6 27.5" />
                            <Vertex pos="6 -6 -27.5" />
                            <Vertex pos="-6 6 27.5" />
                            <Vertex pos="-6 6 -27.5" />
                            <Vertex pos="-6 -6 27.5" />
                            <Vertex pos="-6 -6 -27.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 -512 0 0 -1 2880 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank2" texgens="0 -1 0 0 0 0 -1 2880 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 2880 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank2" texgens="1 0 0 -512 0 0 -1 2880 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27.5" album="" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27.5" album="" material="bm_grid_blank2" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="-51 -51 13.5" rot="1 0 0 0" scale="" transform="1 0 0 -51 0 1 0 -51 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 33" />
                            <Vertex pos="4 4 -33" />
                            <Vertex pos="4 -4 33" />
                            <Vertex pos="4 -4 -33" />
                            <Vertex pos="-4 4 33" />
                            <Vertex pos="-4 4 -33" />
                            <Vertex pos="-4 -4 33" />
                            <Vertex pos="-4 -4 -33" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank2" texgens="0 1 0 -256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank2" texgens="0 -1 0 -256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 -256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -33" album="" material="bm_tile07_B" texgens="1 0 0 1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -33" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="-17 -61 26" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -61 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 0.25 0.25" />
                            <Vertex pos="2.25 0.25 -0.25" />
                            <Vertex pos="1.75 -0.25 0.25" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                            <Vertex pos="-2.25 0.25 0.25" />
                            <Vertex pos="-2.25 0.25 -0.25" />
                            <Vertex pos="-1.75 -0.25 0.25" />
                            <Vertex pos="-1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.41421" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="-17 -65 26" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -65 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0.25 0.25" />
                            <Vertex pos="1.75 0.25 -0.25" />
                            <Vertex pos="2.25 -0.25 0.25" />
                            <Vertex pos="2.25 -0.25 -0.25" />
                            <Vertex pos="-1.75 0.25 0.25" />
                            <Vertex pos="-1.75 0.25 -0.25" />
                            <Vertex pos="-2.25 -0.25 0.25" />
                            <Vertex pos="-2.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41421" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="-19 -63 26" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 -63 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.25" />
                            <Vertex pos="0.25 1.75 -0.25" />
                            <Vertex pos="0.25 -1.75 0.25" />
                            <Vertex pos="0.25 -1.75 -0.25" />
                            <Vertex pos="-0.25 2.25 0.25" />
                            <Vertex pos="-0.25 2.25 -0.25" />
                            <Vertex pos="-0.25 -2.25 0.25" />
                            <Vertex pos="-0.25 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.25" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="-15 -63 26" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -63 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.25 0.25" />
                            <Vertex pos="0.25 2.25 -0.25" />
                            <Vertex pos="0.25 -2.25 0.25" />
                            <Vertex pos="0.25 -2.25 -0.25" />
                            <Vertex pos="-0.25 1.75 0.25" />
                            <Vertex pos="-0.25 1.75 -0.25" />
                            <Vertex pos="-0.25 -1.75 0.25" />
                            <Vertex pos="-0.25 -1.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="-41 -105 43" rot="1 0 0 0" scale="" transform="1 0 0 -41 0 1 0 -105 0 0 1 43 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 0.25 0.25" />
                            <Vertex pos="2.25 0.25 -0.25" />
                            <Vertex pos="1.75 -0.25 0.25" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                            <Vertex pos="-2.25 0.25 0.25" />
                            <Vertex pos="-2.25 0.25 -0.25" />
                            <Vertex pos="-1.75 -0.25 0.25" />
                            <Vertex pos="-1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.41421" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="-41 -109 43" rot="1 0 0 0" scale="" transform="1 0 0 -41 0 1 0 -109 0 0 1 43 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75001 0.25 0.25" />
                            <Vertex pos="1.75001 0.25 -0.25" />
                            <Vertex pos="2.25001 -0.25 0.25" />
                            <Vertex pos="2.25001 -0.25 -0.25" />
                            <Vertex pos="-1.75001 0.25 0.25" />
                            <Vertex pos="-1.75001 0.25 -0.25" />
                            <Vertex pos="-2.25001 -0.25 0.25" />
                            <Vertex pos="-2.25001 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41422" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.41422" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="-43 -107 43" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 -107 0 0 1 43 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.25" />
                            <Vertex pos="0.25 1.75 -0.25" />
                            <Vertex pos="0.25 -1.74999 0.25" />
                            <Vertex pos="0.25 -1.74999 -0.25" />
                            <Vertex pos="-0.25 2.25 0.25" />
                            <Vertex pos="-0.25 2.25 -0.25" />
                            <Vertex pos="-0.25 -2.24999 0.25" />
                            <Vertex pos="-0.25 -2.24999 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.25" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="-39 -107 43" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 -107 0 0 1 43 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.24999 0.25" />
                            <Vertex pos="0.25 2.24999 -0.25" />
                            <Vertex pos="0.25 -2.24999 0.25" />
                            <Vertex pos="0.25 -2.24999 -0.25" />
                            <Vertex pos="-0.25 1.74999 0.25" />
                            <Vertex pos="-0.25 1.74999 -0.25" />
                            <Vertex pos="-0.25 -1.74999 0.25" />
                            <Vertex pos="-0.25 -1.74999 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="-49 -97 43" rot="1 0 0 0" scale="" transform="1 0 0 -49 0 1 0 -97 0 0 1 43 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 0.25 0.25" />
                            <Vertex pos="2.25 0.25 -0.25" />
                            <Vertex pos="1.75 -0.25 0.25" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                            <Vertex pos="-2.25 0.25 0.25" />
                            <Vertex pos="-2.25 0.25 -0.25" />
                            <Vertex pos="-1.75 -0.25 0.25" />
                            <Vertex pos="-1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.41421" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="-49 -101 43" rot="1 0 0 0" scale="" transform="1 0 0 -49 0 1 0 -101 0 0 1 43 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0.25 0.25" />
                            <Vertex pos="1.75 0.25 -0.25" />
                            <Vertex pos="2.25 -0.25 0.25" />
                            <Vertex pos="2.25 -0.25 -0.25" />
                            <Vertex pos="-1.75 0.25 0.25" />
                            <Vertex pos="-1.75 0.25 -0.25" />
                            <Vertex pos="-2.25 -0.25 0.25" />
                            <Vertex pos="-2.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41421" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam" texgens="0 -1 0 128 1 0 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="-51 -99 43" rot="1 0 0 0" scale="" transform="1 0 0 -51 0 1 0 -99 0 0 1 43 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.25" />
                            <Vertex pos="0.25 1.75 -0.25" />
                            <Vertex pos="0.25 -1.74999 0.25" />
                            <Vertex pos="0.25 -1.74999 -0.25" />
                            <Vertex pos="-0.25 2.25 0.25" />
                            <Vertex pos="-0.25 2.25 -0.25" />
                            <Vertex pos="-0.25 -2.24999 0.25" />
                            <Vertex pos="-0.25 -2.24999 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.25" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="-47 -99 43" rot="1 0 0 0" scale="" transform="1 0 0 -47 0 1 0 -99 0 0 1 43 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.24999 0.25" />
                            <Vertex pos="0.25 2.24999 -0.25" />
                            <Vertex pos="0.25 -2.24999 0.25" />
                            <Vertex pos="0.25 -2.24999 -0.25" />
                            <Vertex pos="-0.25 1.74999 0.25" />
                            <Vertex pos="-0.25 1.74999 -0.25" />
                            <Vertex pos="-0.25 -1.74999 0.25" />
                            <Vertex pos="-0.25 -1.74999 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 896 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 -640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="-3.25 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="3.25 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="0 3.25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 3.25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.25" />
                            <Vertex pos="3.5 0.25 -0.25" />
                            <Vertex pos="3.5 -0.25 0.25" />
                            <Vertex pos="3.5 -0.25 -0.25" />
                            <Vertex pos="-3.5 0.25 0.25" />
                            <Vertex pos="-3.5 0.25 -0.25" />
                            <Vertex pos="-3.5 -0.25 0.25" />
                            <Vertex pos="-3.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="-3.25 -3.25 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -3.25 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="3.25 -3.25 0.5" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -3.25 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-3.25 -6 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -6 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="3.25 -6 1.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -6 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="-3.25 -9.25 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -9.25 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="3.25 -9.25 1.5" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -9.25 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="-3.25 -12 2.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -12 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="3.25 -12 2.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -12 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="-3.25 -15.25 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -15.25 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="3.25 -15.25 2.5" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -15.25 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="-3.25 -18 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -18 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="3.25 -18 3.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -18 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="-3.25 -21.25 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -21.25 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="3.25 -21.25 3.5" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -21.25 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="3.25 -27.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -27.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.25 0.25" />
                            <Vertex pos="0.25 6.25 -0.25" />
                            <Vertex pos="0.25 -6.25 0.25" />
                            <Vertex pos="0.25 -6.25 -0.25" />
                            <Vertex pos="-0.25 6.25 0.25" />
                            <Vertex pos="-0.25 6.25 -0.25" />
                            <Vertex pos="-0.25 -6.25 0.25" />
                            <Vertex pos="-0.25 -6.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.25" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="-3.25 -23.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 -23.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.75 0.25" />
                            <Vertex pos="0.25 2.75 -0.25" />
                            <Vertex pos="0.25 -2.75 0.25" />
                            <Vertex pos="0.25 -2.75 -0.25" />
                            <Vertex pos="-0.25 2.75 0.25" />
                            <Vertex pos="-0.25 2.75 -0.25" />
                            <Vertex pos="-0.25 -2.75 0.25" />
                            <Vertex pos="-0.25 -2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.75" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.75" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="-8 -26.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -26.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 0.25" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -0.25 0.25" />
                            <Vertex pos="5 -0.25 -0.25" />
                            <Vertex pos="-5 0.25 0.25" />
                            <Vertex pos="-5 0.25 -0.25" />
                            <Vertex pos="-5 -0.25 0.25" />
                            <Vertex pos="-5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -256 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="-5 -33.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -33.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.25 0.25" />
                            <Vertex pos="8 0.25 -0.25" />
                            <Vertex pos="8 -0.25 0.25" />
                            <Vertex pos="8 -0.25 -0.25" />
                            <Vertex pos="-8 0.25 0.25" />
                            <Vertex pos="-8 0.25 -0.25" />
                            <Vertex pos="-8 -0.25 0.25" />
                            <Vertex pos="-8 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="-14 -26.875 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -26.875 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.125 0.25" />
                            <Vertex pos="1 0.125 -0.25" />
                            <Vertex pos="1 -0.125 0.25" />
                            <Vertex pos="1 -0.125 -0.25" />
                            <Vertex pos="-1 0.125 0.25" />
                            <Vertex pos="-1 0.125 -0.25" />
                            <Vertex pos="-1 -0.125 0.25" />
                            <Vertex pos="-1 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 -1248 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 736 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 768 0 -1 0 992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -128 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="-14 -33.125 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -33.125 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.125 0.25" />
                            <Vertex pos="1 0.125 -0.25" />
                            <Vertex pos="1 -0.125 0.25" />
                            <Vertex pos="1 -0.125 -0.25" />
                            <Vertex pos="-1 0.125 0.25" />
                            <Vertex pos="-1 0.125 -0.25" />
                            <Vertex pos="-1 -0.125 0.25" />
                            <Vertex pos="-1 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 -1184 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 672 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 768 0 -1 0 928 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -128 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="-17 -26.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -26.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="-17 -33.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -33.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-20 -26.875 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -26.875 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.125 0.25" />
                            <Vertex pos="1 0.125 -0.25" />
                            <Vertex pos="1 -0.125 0.25" />
                            <Vertex pos="1 -0.125 -0.25" />
                            <Vertex pos="-1 0.125 0.25" />
                            <Vertex pos="-1 0.125 -0.25" />
                            <Vertex pos="-1 -0.125 0.25" />
                            <Vertex pos="-1 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 -1248 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 736 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 768 0 -1 0 992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -128 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-20 -33.125 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -33.125 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.125 0.25" />
                            <Vertex pos="1 0.125 -0.25" />
                            <Vertex pos="1 -0.125 0.25" />
                            <Vertex pos="1 -0.125 -0.25" />
                            <Vertex pos="-1 0.125 0.25" />
                            <Vertex pos="-1 0.125 -0.25" />
                            <Vertex pos="-1 -0.125 0.25" />
                            <Vertex pos="-1 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 -1184 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 672 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 768 0 -1 0 928 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -128 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-23 -26.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 -26.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-23 -33.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 -33.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-26 -26.875 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 -26.875 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.125 0.25" />
                            <Vertex pos="1 0.125 -0.25" />
                            <Vertex pos="1 -0.125 0.25" />
                            <Vertex pos="1 -0.125 -0.25" />
                            <Vertex pos="-1 0.125 0.25" />
                            <Vertex pos="-1 0.125 -0.25" />
                            <Vertex pos="-1 -0.125 0.25" />
                            <Vertex pos="-1 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 -1248 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 736 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 768 0 -1 0 992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -128 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="-26 -33.125 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 -33.125 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.125 0.25" />
                            <Vertex pos="1 0.125 -0.25" />
                            <Vertex pos="1 -0.125 0.25" />
                            <Vertex pos="1 -0.125 -0.25" />
                            <Vertex pos="-1 0.125 0.25" />
                            <Vertex pos="-1 0.125 -0.25" />
                            <Vertex pos="-1 -0.125 0.25" />
                            <Vertex pos="-1 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 -1184 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 672 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 768 0 -1 0 928 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -128 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="-39 -26.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 -26.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 0.25 0.25" />
                            <Vertex pos="12 0.25 -0.25" />
                            <Vertex pos="12 -0.25 0.25" />
                            <Vertex pos="12 -0.25 -0.25" />
                            <Vertex pos="-12 0.25 0.25" />
                            <Vertex pos="-12 0.25 -0.25" />
                            <Vertex pos="-12 -0.25 0.25" />
                            <Vertex pos="-12 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2816 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2048 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2944 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="-29 -33.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -33.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="-30.75 -34.5 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -30.75 0 1 0 -34.5 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="-35 -35.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 -35.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-43 -35.25 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 -35.25 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 -4.25" />
                            <Vertex pos="4 0.25 -4.75" />
                            <Vertex pos="4 -0.25 -4.25" />
                            <Vertex pos="4 -0.25 -4.75" />
                            <Vertex pos="-4 0.25 4.75" />
                            <Vertex pos="-4 0.25 4.25" />
                            <Vertex pos="-4 -0.25 4.75" />
                            <Vertex pos="-4 -0.25 4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 -1.125 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.747409 0 0.664364 -0.166091" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.747409 0 -0.664364 -0.166091" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="-48 -35.25 13.25" rot="1 0 0 0" scale="" transform="1 0 0 -48 0 1 0 -35.25 0 0 1 13.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="-50 -35.25 14.25" rot="1 0 0 0" scale="" transform="1 0 0 -50 0 1 0 -35.25 0 0 1 14.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="-57 -35.25 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -57 0 1 0 -35.25 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 2.75" />
                            <Vertex pos="6 0.25 2.25" />
                            <Vertex pos="6 -0.25 2.75" />
                            <Vertex pos="6 -0.25 2.25" />
                            <Vertex pos="-6 0.25 -2.25" />
                            <Vertex pos="-6 0.25 -2.75" />
                            <Vertex pos="-6 -0.25 -2.25" />
                            <Vertex pos="-6 -0.25 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1408 0.416667 0 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.384615 0 0.923077 -0.230769" album="" material="bm_edge_white" texgens="1 0 0 -512 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.384615 0 -0.923077 -0.230769" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-65 -35.25 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 -35.25 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-65 -26.75 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 -26.75 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-57 -26.75 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -57 0 1 0 -26.75 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 -2.25" />
                            <Vertex pos="6 0.25 -2.75" />
                            <Vertex pos="6 -0.25 -2.25" />
                            <Vertex pos="6 -0.25 -2.75" />
                            <Vertex pos="-6 0.25 2.75" />
                            <Vertex pos="-6 0.25 2.25" />
                            <Vertex pos="-6 -0.25 2.75" />
                            <Vertex pos="-6 -0.25 2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1408 -0.416667 0 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.384615 0 0.923077 -0.230769" album="" material="bm_edge_white" texgens="1 0 0 1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.384615 0 -0.923077 -0.230769" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-67.25 -31 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -67.25 0 1 0 -31 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.5 0.25" />
                            <Vertex pos="0.25 4.5 -0.25" />
                            <Vertex pos="0.25 -4.5 0.25" />
                            <Vertex pos="0.25 -4.5 -0.25" />
                            <Vertex pos="-0.25 4.5 0.25" />
                            <Vertex pos="-0.25 4.5 -0.25" />
                            <Vertex pos="-0.25 -4.5 0.25" />
                            <Vertex pos="-0.25 -4.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 960 0 -1 0 -1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="-49.25 -35.25 13.5" rot="1 0 0 0" scale="" transform="1 0 0 -49.25 0 1 0 -35.25 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1216 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1472 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
