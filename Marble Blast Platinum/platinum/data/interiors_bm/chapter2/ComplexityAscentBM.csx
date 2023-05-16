<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2023/05/11 17:03:14">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="3">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="5">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="58 35 40.75" direction="0 -0 -0">
                        <Properties next_time="2000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="54 35 40.75" direction="0 -0 -0">
                        <Properties next_time="2000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="58 35 40.75" direction="0 -0 -0">
                        <Properties next_time="2000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="892">
                    <Brush id="0" owner="0" type="0" pos="-3 0 0" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 1" />
                            <Vertex pos="6 3 -17" />
                            <Vertex pos="6 -3 1" />
                            <Vertex pos="6 -3 -17" />
                            <Vertex pos="-6 3 1" />
                            <Vertex pos="-6 3 -17" />
                            <Vertex pos="-6 -3 1" />
                            <Vertex pos="-6 -3 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="-9 6 1" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 6 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 2" />
                            <Vertex pos="6 3 -18" />
                            <Vertex pos="6 -3 2" />
                            <Vertex pos="6 -3 -18" />
                            <Vertex pos="-6 3 2" />
                            <Vertex pos="-6 3 -18" />
                            <Vertex pos="-6 -3 2" />
                            <Vertex pos="-6 -3 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="-12 0 1" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 0 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 2" />
                            <Vertex pos="3 3 -18" />
                            <Vertex pos="3 -3 2" />
                            <Vertex pos="3 -3 -18" />
                            <Vertex pos="-3 3 2" />
                            <Vertex pos="-3 3 -18" />
                            <Vertex pos="-3 -3 2" />
                            <Vertex pos="-3 -3 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1792 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-9 -6 1" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -6 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 2" />
                            <Vertex pos="6 3 -18" />
                            <Vertex pos="6 -3 2" />
                            <Vertex pos="6 -3 -18" />
                            <Vertex pos="-6 3 2" />
                            <Vertex pos="-6 3 -18" />
                            <Vertex pos="-6 -3 2" />
                            <Vertex pos="-6 -3 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-9 -12 2" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -12 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 3" />
                            <Vertex pos="6 3 -19" />
                            <Vertex pos="6 -3 3" />
                            <Vertex pos="6 -3 -19" />
                            <Vertex pos="-6 3 3" />
                            <Vertex pos="-6 3 -19" />
                            <Vertex pos="-6 -3 3" />
                            <Vertex pos="-6 -3 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-18 -9 3" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -9 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 4" />
                            <Vertex pos="3 6 -20" />
                            <Vertex pos="3 -6 4" />
                            <Vertex pos="3 -6 -20" />
                            <Vertex pos="-3 6 4" />
                            <Vertex pos="-3 6 -20" />
                            <Vertex pos="-3 -6 4" />
                            <Vertex pos="-3 -6 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-18 15 5" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 15 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 6" />
                            <Vertex pos="3 6 -22" />
                            <Vertex pos="3 -6 6" />
                            <Vertex pos="3 -6 -22" />
                            <Vertex pos="-3 6 6" />
                            <Vertex pos="-3 6 -22" />
                            <Vertex pos="-3 -6 6" />
                            <Vertex pos="-3 -6 -22" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-18 7 4" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 7 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 5" />
                            <Vertex pos="3 2 -21" />
                            <Vertex pos="3 -2 1" />
                            <Vertex pos="3 -2 -21" />
                            <Vertex pos="-3 2 5" />
                            <Vertex pos="-3 2 -21" />
                            <Vertex pos="-3 -2 1" />
                            <Vertex pos="-3 -2 -21" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -2.12132" album="" material="bm_friction_bounce_med" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -21" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-15 -18 3" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -18 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 4" />
                            <Vertex pos="6 3 -20" />
                            <Vertex pos="6 -3 4" />
                            <Vertex pos="6 -3 -20" />
                            <Vertex pos="-6 3 4" />
                            <Vertex pos="-6 3 -20" />
                            <Vertex pos="-6 -3 4" />
                            <Vertex pos="-6 -3 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-20 23 10" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 23 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 11" />
                            <Vertex pos="1 2 -27" />
                            <Vertex pos="1 -2 7" />
                            <Vertex pos="1 -2 -27" />
                            <Vertex pos="-1 2 11" />
                            <Vertex pos="-1 2 -27" />
                            <Vertex pos="-1 -2 7" />
                            <Vertex pos="-1 -2 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -6.36396" album="" material="bm_friction_grass" texgens="1 0 0 -5120 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-17 23 10" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 23 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 11" />
                            <Vertex pos="2 2 -27" />
                            <Vertex pos="2 -2 7" />
                            <Vertex pos="2 -2 -27" />
                            <Vertex pos="-2 2 11" />
                            <Vertex pos="-2 2 -27" />
                            <Vertex pos="-2 -2 7" />
                            <Vertex pos="-2 -2 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -6.36396" album="Blasted" material="bm_tile11_D" texgens="1 0 0 -2048 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-18 28 10" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 28 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 11" />
                            <Vertex pos="3 3 -27" />
                            <Vertex pos="3 -3 11" />
                            <Vertex pos="3 -3 -27" />
                            <Vertex pos="-3 3 11" />
                            <Vertex pos="-3 3 -27" />
                            <Vertex pos="-3 -3 11" />
                            <Vertex pos="-3 -3 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1792 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-19 33 12" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 33 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 13" />
                            <Vertex pos="2 2 -29" />
                            <Vertex pos="2 -2 9" />
                            <Vertex pos="2 -2 -29" />
                            <Vertex pos="-2 2 13" />
                            <Vertex pos="-2 2 -29" />
                            <Vertex pos="-2 -2 9" />
                            <Vertex pos="-2 -2 -29" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -7.77817" album="Blasted" material="bm_tile11_D" texgens="1 0 0 -2048 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -29" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-16 33 12" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 33 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 13" />
                            <Vertex pos="1 2 -29" />
                            <Vertex pos="1 -2 9" />
                            <Vertex pos="1 -2 -29" />
                            <Vertex pos="-1 2 13" />
                            <Vertex pos="-1 2 -29" />
                            <Vertex pos="-1 -2 9" />
                            <Vertex pos="-1 -2 -29" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -7.77817" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 -8448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -29" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-18 38 12" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 38 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 13" />
                            <Vertex pos="3 3 -29" />
                            <Vertex pos="3 -3 13" />
                            <Vertex pos="3 -3 -29" />
                            <Vertex pos="-3 3 13" />
                            <Vertex pos="-3 3 -29" />
                            <Vertex pos="-3 -3 13" />
                            <Vertex pos="-3 -3 -29" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1792 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -29" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-6 50 15" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 50 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 16" />
                            <Vertex pos="3 3 -32" />
                            <Vertex pos="3 -3 16" />
                            <Vertex pos="3 -3 -32" />
                            <Vertex pos="-3 3 16" />
                            <Vertex pos="-3 3 -32" />
                            <Vertex pos="-3 -3 16" />
                            <Vertex pos="-3 -3 -32" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1792 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="6 50 18" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 50 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 19" />
                            <Vertex pos="3 3 -35" />
                            <Vertex pos="3 -3 19" />
                            <Vertex pos="3 -3 -35" />
                            <Vertex pos="-3 3 19" />
                            <Vertex pos="-3 3 -35" />
                            <Vertex pos="-3 -3 19" />
                            <Vertex pos="-3 -3 -35" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -35" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="44 50 39" rot="1 0 0 0" scale="" transform="1 0 0 44 0 1 0 50 0 0 1 39 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 2" />
                            <Vertex pos="3 3 -2" />
                            <Vertex pos="3 -3 2" />
                            <Vertex pos="3 -3 -2" />
                            <Vertex pos="-3 3 2" />
                            <Vertex pos="-3 3 -2" />
                            <Vertex pos="-3 -3 2" />
                            <Vertex pos="-3 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_friction_sand" texgens="0 -1 0 -6400 0 0 -1 -4992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -1792 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="1" type="999" pos="58 35 40.75" rot="1 0 0 0" scale="" transform="1 0 0 58 0 1 0 35 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 0.25" />
                            <Vertex pos="1 6 -0.25" />
                            <Vertex pos="1 -6 0.25" />
                            <Vertex pos="1 -6 -0.25" />
                            <Vertex pos="-1 6 0.25" />
                            <Vertex pos="-1 6 -0.25" />
                            <Vertex pos="-1 -6 0.25" />
                            <Vertex pos="-1 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -4224 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile11_D" texgens="1 0 0 1792 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -1152 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="58 38 42" rot="1 0 0 0" scale="" transform="1 0 0 58 0 1 0 38 0 0 1 42 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 640 0 0 -1 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="54 32 42" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 32 0 0 1 42 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 640 0 0 -1 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_tile05_C" texgens="1 0 0 256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="18 20 20" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 20 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 21" />
                            <Vertex pos="3 3 -37" />
                            <Vertex pos="3 -3 21" />
                            <Vertex pos="3 -3 -37" />
                            <Vertex pos="-3 3 21" />
                            <Vertex pos="-3 3 -37" />
                            <Vertex pos="-3 -3 21" />
                            <Vertex pos="-3 -3 -37" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -21" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -37" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-20 44 24.75" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 44 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2304 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-8 55 30.75" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 55 0 0 1 30.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2304 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-19 62 28.75" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 62 0 0 1 28.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2560 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-27 62 26.75" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 62 0 0 1 26.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2560 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-23 62 27.75" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 62 0 0 1 27.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 1.25" />
                            <Vertex pos="2 1 0.75" />
                            <Vertex pos="2 -1 1.25" />
                            <Vertex pos="2 -1 0.75" />
                            <Vertex pos="-2 1 -0.75" />
                            <Vertex pos="-2 1 -1.25" />
                            <Vertex pos="-2 -1 -0.75" />
                            <Vertex pos="-2 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -1152 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -384 0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223607" album="" material="bm_friction_sand" texgens="1 0 0 -5888 0 -1 0 -15872 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-27 52 25.75" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 52 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 -0.75" />
                            <Vertex pos="2 1 -1.25" />
                            <Vertex pos="2 -1 -0.75" />
                            <Vertex pos="2 -1 -1.25" />
                            <Vertex pos="-2 1 1.25" />
                            <Vertex pos="-2 1 0.749998" />
                            <Vertex pos="-2 -1 1.25" />
                            <Vertex pos="-2 -1 0.749998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -1152 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -384 -0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -384 -0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223607" album="" material="bm_friction_sand" texgens="1 0 0 -6912 0 -1 0 -13312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447213 0 -0.894427 -0.223608" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-5 72 29.75" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 72 0 0 1 29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 1.25" />
                            <Vertex pos="2 1 0.749998" />
                            <Vertex pos="2 -1 1.25" />
                            <Vertex pos="2 -1 0.749998" />
                            <Vertex pos="-2 1 -0.75" />
                            <Vertex pos="-2 1 -1.25" />
                            <Vertex pos="-2 -1 -0.75" />
                            <Vertex pos="-2 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -1152 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -384 0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223607" album="" material="bm_friction_sand" texgens="1 0 0 -1280 0 -1 0 -18432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447213 0 -0.894427 -0.223608" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="644" owner="0" type="0" pos="35 50 17" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 50 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 20" />
                            <Vertex pos="6 -3 20" />
                            <Vertex pos="-6 3 20" />
                            <Vertex pos="-6 -3 20" />
                            <Vertex pos="6 3 -34" />
                            <Vertex pos="6 -3 -34" />
                            <Vertex pos="-6 3 -34" />
                            <Vertex pos="-6 -3 -34" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -20" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -34" album="" material="bm_grid_blank4" texgens="0 1 0 -128 1 0 0 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="646" owner="0" type="0" pos="44 50 17" rot="1 0 0 0" scale="" transform="1 0 0 44 0 1 0 50 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 20" />
                            <Vertex pos="3 -3 20" />
                            <Vertex pos="-3 3 20" />
                            <Vertex pos="-3 -3 20" />
                            <Vertex pos="3 3 -34" />
                            <Vertex pos="3 -3 -34" />
                            <Vertex pos="-3 3 -34" />
                            <Vertex pos="-3 -3 -34" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -20" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1792 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -34" album="" material="bm_grid_blank4" texgens="0 1 0 -128 1 0 0 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="648" owner="0" type="0" pos="53 50 19" rot="1 0 0 0" scale="" transform="1 0 0 53 0 1 0 50 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 22" />
                            <Vertex pos="6 -3 22" />
                            <Vertex pos="-6 3 22" />
                            <Vertex pos="-6 -3 22" />
                            <Vertex pos="6 3 -36" />
                            <Vertex pos="6 -3 -36" />
                            <Vertex pos="-6 3 -36" />
                            <Vertex pos="-6 -3 -36" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -22" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -36" album="" material="bm_grid_blank4" texgens="0 1 0 -128 1 0 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="650" owner="0" type="0" pos="56 44 19" rot="1 0 0 0" scale="" transform="1 0 0 56 0 1 0 44 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 22" />
                            <Vertex pos="3 -3 22" />
                            <Vertex pos="-3 3 22" />
                            <Vertex pos="-3 -3 22" />
                            <Vertex pos="3 3 -36" />
                            <Vertex pos="3 -3 -36" />
                            <Vertex pos="-3 3 -36" />
                            <Vertex pos="-3 -3 -36" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -22" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -36" album="" material="bm_grid_blank4" texgens="0 1 0 -128 1 0 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="652" owner="0" type="0" pos="56 26 19" rot="1 0 0 0" scale="" transform="1 0 0 56 0 1 0 26 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 22" />
                            <Vertex pos="3 -3 22" />
                            <Vertex pos="-3 3 22" />
                            <Vertex pos="-3 -3 22" />
                            <Vertex pos="3 3 -36" />
                            <Vertex pos="3 -3 -36" />
                            <Vertex pos="-3 3 -36" />
                            <Vertex pos="-3 -3 -36" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -22" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -36" album="" material="bm_grid_blank4" texgens="0 1 0 -128 1 0 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="654" owner="0" type="0" pos="53 20 19" rot="1 0 0 0" scale="" transform="1 0 0 53 0 1 0 20 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 22" />
                            <Vertex pos="6 -3 22" />
                            <Vertex pos="-6 3 22" />
                            <Vertex pos="-6 -3 22" />
                            <Vertex pos="6 3 -36" />
                            <Vertex pos="6 -3 -36" />
                            <Vertex pos="-6 3 -36" />
                            <Vertex pos="-6 -3 -36" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -22" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -36" album="" material="bm_grid_blank4" texgens="0 1 0 -128 1 0 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="661" owner="0" type="0" pos="0 -3.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="662" owner="0" type="0" pos="0 3.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 3.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="663" owner="0" type="0" pos="3.25 0 0.75" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 0 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.5 0.25" />
                            <Vertex pos="0.25 3.5 -0.25" />
                            <Vertex pos="0.25 -3.5 0.25" />
                            <Vertex pos="0.25 -3.5 -0.25" />
                            <Vertex pos="-0.25 3.5 0.25" />
                            <Vertex pos="-0.25 3.5 -0.25" />
                            <Vertex pos="-0.25 -3.5 0.25" />
                            <Vertex pos="-0.25 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="664" owner="0" type="0" pos="-8 2 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 2 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile11_D" texgens="1 0 0 -2304 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="665" owner="0" type="0" pos="-5 -8 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -8 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.5" />
                            <Vertex pos="2 1 -0.5" />
                            <Vertex pos="2 -1 0.5" />
                            <Vertex pos="2 -1 -0.5" />
                            <Vertex pos="-2 1 0.5" />
                            <Vertex pos="-2 1 -0.5" />
                            <Vertex pos="-2 -1 0.5" />
                            <Vertex pos="-2 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile11_D" texgens="1 0 0 -2048 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="666" owner="0" type="0" pos="-14 -14 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -14 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile11_D" texgens="1 0 0 -2304 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="667" owner="0" type="0" pos="-2.75 3.25 2" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 3.25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="668" owner="0" type="0" pos="-2.75 6.5 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 6.5 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="669" owner="0" type="0" pos="-2.75 -6.5 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 -6.5 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="670" owner="0" type="0" pos="-2.75 -3.25 2" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 -3.25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="671" owner="0" type="0" pos="-2.75 -9.25 4" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 -9.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="672" owner="0" type="0" pos="-2.75 -12.5 4.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 -12.5 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="673" owner="0" type="0" pos="-6 -15.25 4.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -15.25 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="674" owner="0" type="0" pos="-8.75 -18.5 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -8.75 0 1 0 -18.5 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="675" owner="0" type="0" pos="-8.75 -15.25 6" rot="1 0 0 0" scale="" transform="1 0 0 -8.75 0 1 0 -15.25 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="676" owner="0" type="0" pos="-15.25 -21.25 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 -21.25 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.25 0.25 0.25" />
                            <Vertex pos="6.25 0.25 -0.25" />
                            <Vertex pos="6.25 -0.25 0.25" />
                            <Vertex pos="6.25 -0.25 -0.25" />
                            <Vertex pos="-6.25 0.25 0.25" />
                            <Vertex pos="-6.25 0.25 -0.25" />
                            <Vertex pos="-6.25 -0.25 0.25" />
                            <Vertex pos="-6.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="677" owner="0" type="0" pos="-21.25 -12 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.25 0 1 0 -12 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 9 0.25" />
                            <Vertex pos="0.25 9 -0.25" />
                            <Vertex pos="0.25 -9 0.25" />
                            <Vertex pos="0.25 -9 -0.25" />
                            <Vertex pos="-0.25 9 0.25" />
                            <Vertex pos="-0.25 9 -0.25" />
                            <Vertex pos="-0.25 -9 0.25" />
                            <Vertex pos="-0.25 -9 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="678" owner="0" type="0" pos="-9 9.25 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 9.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="679" owner="0" type="0" pos="-15.25 1 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 1 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="680" owner="0" type="0" pos="-15.25 -2.75 4.75" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 -2.75 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1.75" />
                            <Vertex pos="0.25 0.25 -1.75" />
                            <Vertex pos="0.25 -0.25 1.75" />
                            <Vertex pos="0.25 -0.25 -1.75" />
                            <Vertex pos="-0.25 0.25 1.75" />
                            <Vertex pos="-0.25 0.25 -1.75" />
                            <Vertex pos="-0.25 -0.25 1.75" />
                            <Vertex pos="-0.25 -0.25 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -448 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 576 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="681" owner="0" type="0" pos="-18.25 -2.75 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -18.25 0 1 0 -2.75 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.25 0.25" />
                            <Vertex pos="3.25 0.25 -0.25" />
                            <Vertex pos="3.25 -0.25 0.25" />
                            <Vertex pos="3.25 -0.25 -0.25" />
                            <Vertex pos="-3.25 0.25 0.25" />
                            <Vertex pos="-3.25 0.25 -0.25" />
                            <Vertex pos="-3.25 -0.25 0.25" />
                            <Vertex pos="-3.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.25" album="" material="bm_edge_white" texgens="0 1 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="" material="bm_edge_white" texgens="0 -1 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -704 0 -1 0 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 832 0 -1 0 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="682" owner="0" type="0" pos="-14.75 9.25 12.5" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 9.25 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="0.25 0.25 -3.5" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="-0.25 0.25 4" />
                            <Vertex pos="-0.25 0.25 -3.5" />
                            <Vertex pos="-0.25 -0.25 4" />
                            <Vertex pos="-0.25 -0.25 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -448 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 576 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -2.65165" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="683" owner="0" type="0" pos="-21.25 9.25 12.5" rot="1 0 0 0" scale="" transform="1 0 0 -21.25 0 1 0 9.25 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="0.25 0.25 -3.5" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="-0.25 0.25 4" />
                            <Vertex pos="-0.25 0.25 -3.5" />
                            <Vertex pos="-0.25 -0.25 4" />
                            <Vertex pos="-0.25 -0.25 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -448 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 576 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -2.65165" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="684" owner="0" type="0" pos="-21.25 7 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.25 0 1 0 7 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2.25" />
                            <Vertex pos="0.25 2 1.75" />
                            <Vertex pos="0.25 -2 -1.75" />
                            <Vertex pos="0.25 -2 -2.25" />
                            <Vertex pos="-0.25 2 2.25" />
                            <Vertex pos="-0.25 2 1.75" />
                            <Vertex pos="-0.25 -2 -1.75" />
                            <Vertex pos="-0.25 -2 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 1 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="685" owner="0" type="0" pos="-14.75 7 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 7 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2.25" />
                            <Vertex pos="0.25 2 1.75" />
                            <Vertex pos="0.25 -2 -1.75" />
                            <Vertex pos="0.25 -2 -2.25" />
                            <Vertex pos="-0.25 2 2.25" />
                            <Vertex pos="-0.25 2 1.75" />
                            <Vertex pos="-0.25 -2 -1.75" />
                            <Vertex pos="-0.25 -2 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 1 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="686" owner="0" type="0" pos="-14.75 15 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 15 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="687" owner="0" type="0" pos="-21.25 15 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.25 0 1 0 15 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="688" owner="0" type="0" pos="-21.25 23 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.25 0 1 0 23 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2.25" />
                            <Vertex pos="0.25 2 1.75" />
                            <Vertex pos="0.25 -2 -1.75" />
                            <Vertex pos="0.25 -2 -2.25" />
                            <Vertex pos="-0.25 2 2.25" />
                            <Vertex pos="-0.25 2 1.75" />
                            <Vertex pos="-0.25 -2 -1.75" />
                            <Vertex pos="-0.25 -2 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 1 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="689" owner="0" type="0" pos="-14.75 23 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 23 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2.25" />
                            <Vertex pos="0.25 2 1.75" />
                            <Vertex pos="0.25 -2 -1.75" />
                            <Vertex pos="0.25 -2 -2.25" />
                            <Vertex pos="-0.25 2 2.25" />
                            <Vertex pos="-0.25 2 1.75" />
                            <Vertex pos="-0.25 -2 -1.75" />
                            <Vertex pos="-0.25 -2 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 1 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="690" owner="0" type="0" pos="-14.75 28 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 28 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="691" owner="0" type="0" pos="-21.25 28 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.25 0 1 0 28 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="692" owner="0" type="0" pos="-14.75 38 24.75" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 38 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="693" owner="0" type="0" pos="-21.25 40 24.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.25 0 1 0 40 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5 0.250002" />
                            <Vertex pos="0.25 5 -0.25" />
                            <Vertex pos="0.25 -5 0.25" />
                            <Vertex pos="0.25 -5 -0.25" />
                            <Vertex pos="-0.25 4.5 0.250002" />
                            <Vertex pos="-0.25 4.5 -0.25" />
                            <Vertex pos="-0.25 -5 0.25" />
                            <Vertex pos="-0.25 -5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -3.35876" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="2.10185e-007 -2.10185e-007 1 -0.250001" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="694" owner="0" type="0" pos="-21.25 33 22.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.25 0 1 0 33 0 0 1 22.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2.25" />
                            <Vertex pos="0.25 2 1.75" />
                            <Vertex pos="0.25 -2 -1.75" />
                            <Vertex pos="0.25 -2 -2.25" />
                            <Vertex pos="-0.25 2 2.25" />
                            <Vertex pos="-0.25 2 1.75" />
                            <Vertex pos="-0.25 -2 -1.75" />
                            <Vertex pos="-0.25 -2 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 1 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="695" owner="0" type="0" pos="-14.75 33 22.75" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 33 0 0 1 22.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 2.25" />
                            <Vertex pos="0.25 2 1.75" />
                            <Vertex pos="0.25 -2 -1.75" />
                            <Vertex pos="0.25 -2 -2.25" />
                            <Vertex pos="-0.25 2 2.25" />
                            <Vertex pos="-0.25 2 1.75" />
                            <Vertex pos="-0.25 -2 -1.75" />
                            <Vertex pos="-0.25 -2 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 1 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="696" owner="0" type="0" pos="-16.5 41.25 24.75" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 41.25 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="697" owner="0" type="0" pos="-18.75 43 24.75" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 43 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 0.250002" />
                            <Vertex pos="0.25 1.5 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.250002" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.23744" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-4.99189e-007 -4.99189e-007 1 -0.250001" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="698" owner="0" type="0" pos="-9.25 50.75 30.75" rot="1 0 0 0" scale="" transform="1 0 0 -9.25 0 1 0 50.75 0 0 1 30.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.249998" />
                            <Vertex pos="0.25 4.25 -0.249998" />
                            <Vertex pos="0.25 -4.25 0.25" />
                            <Vertex pos="0.25 -4.25 -0.25" />
                            <Vertex pos="-0.25 3.75 0.249998" />
                            <Vertex pos="-0.25 3.75 -0.249998" />
                            <Vertex pos="-0.25 -4.25 0.25" />
                            <Vertex pos="-0.25 -4.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2112 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-2.49594e-007 2.49594e-007 1 -0.249999" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 2.34912e-007 -1 -0.249999" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="699" owner="0" type="0" pos="-6.75 54.25 30.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 54.25 0 0 1 30.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.249996 0.249998" />
                            <Vertex pos="0.25 0.249996 -0.249998" />
                            <Vertex pos="0.25 -0.75 0.25" />
                            <Vertex pos="0.25 -0.75 -0.25" />
                            <Vertex pos="-0.25 0.749996 0.249998" />
                            <Vertex pos="-0.25 0.749996 -0.249998" />
                            <Vertex pos="-0.25 -0.75 0.25" />
                            <Vertex pos="-0.25 -0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0.353551" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="1.33117e-006 1.33117e-006 1 -0.249999" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 1.99676e-006 -1 -0.249998" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="700" owner="0" type="0" pos="-6 46.75 30.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 46.75 0 0 1 30.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="701" owner="0" type="0" pos="0 50 15" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 50 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 16" />
                            <Vertex pos="3 3 -32" />
                            <Vertex pos="3 -3 16" />
                            <Vertex pos="3 -3 -32" />
                            <Vertex pos="-3 3 16" />
                            <Vertex pos="-3 3 -32" />
                            <Vertex pos="-3 -3 16" />
                            <Vertex pos="-3 -3 -32" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="702" owner="0" type="0" pos="0 51.5 34" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 51.5 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1.5 3" />
                            <Vertex pos="3 1.5 -3" />
                            <Vertex pos="3 -1.5 3" />
                            <Vertex pos="3 -1.5 -3" />
                            <Vertex pos="-3 1.5 3" />
                            <Vertex pos="-3 1.5 -3" />
                            <Vertex pos="-3 -1.5 3" />
                            <Vertex pos="-3 -1.5 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 64 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_stripe_caution2" texgens="0 -1 -1 -32 0 0 -1 192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -256 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="703" owner="0" type="0" pos="-5 53.25 30.75" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 53.25 0 0 1 30.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="704" owner="0" type="0" pos="0 48.5 34" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 48.5 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1.5 3" />
                            <Vertex pos="3 1.5 -3" />
                            <Vertex pos="3 -1.5 3" />
                            <Vertex pos="3 -1.5 -3" />
                            <Vertex pos="-3 1.5 3" />
                            <Vertex pos="-3 1.5 -3" />
                            <Vertex pos="-3 -1.5 3" />
                            <Vertex pos="-3 -1.5 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -320 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_stripe_caution2" texgens="0 -1 1 352 0 0 -1 192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -256 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="705" owner="0" type="0" pos="3 46.75 36.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 46.75 0 0 1 36.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="5.5 -0.25 0.25" />
                            <Vertex pos="5.5 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -4.06586" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="706" owner="0" type="0" pos="3 53.25 36.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 53.25 0 0 1 36.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 0.25 0.25" />
                            <Vertex pos="5.5 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -4.06586" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="707" owner="0" type="0" pos="-2.75 53.25 33.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 53.25 0 0 1 33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 -0.25 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="708" owner="0" type="0" pos="-2.75 46.75 33.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 46.75 0 0 1 33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 -0.25 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="709" owner="0" type="0" pos="35 46.75 36.75" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 46.75 0 0 1 36.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-5.5 -0.25 0.25" />
                            <Vertex pos="-5.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -4.06586" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="710" owner="0" type="0" pos="35 53.25 36.75" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 53.25 0 0 1 36.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-5.5 0.25 0.25" />
                            <Vertex pos="-5.5 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -4.06586" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="711" owner="0" type="0" pos="46.75 46.75 40.75" rot="1 0 0 0" scale="" transform="1 0 0 46.75 0 1 0 46.75 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.75 0.25 0.25" />
                            <Vertex pos="5.75 0.25 -0.25" />
                            <Vertex pos="5.75 -0.25 0.25" />
                            <Vertex pos="5.75 -0.25 -0.25" />
                            <Vertex pos="-5.75 0.25 0.25" />
                            <Vertex pos="-5.75 0.25 -0.25" />
                            <Vertex pos="-5.75 -0.25 0.25" />
                            <Vertex pos="-5.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.75" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5.75" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 576 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="712" owner="0" type="0" pos="50.25 53.25 40.75" rot="1 0 0 0" scale="" transform="1 0 0 50.25 0 1 0 53.25 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9.25 0.25 0.25" />
                            <Vertex pos="9.25 0.25 -0.25" />
                            <Vertex pos="9.25 -0.25 0.25" />
                            <Vertex pos="9.25 -0.25 -0.25" />
                            <Vertex pos="-9.25 0.25 0.25" />
                            <Vertex pos="-9.25 0.25 -0.25" />
                            <Vertex pos="-9.25 -0.25 0.25" />
                            <Vertex pos="-9.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9.25" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9.25" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1472 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1344 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="713" owner="0" type="0" pos="52.75 44 40.75" rot="1 0 0 0" scale="" transform="1 0 0 52.75 0 1 0 44 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -2.5 0.25" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.94454" album="" material="bm_edge_white" texgens="1 0 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -832 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="714" owner="0" type="0" pos="59.25 47 40.75" rot="1 0 0 0" scale="" transform="1 0 0 59.25 0 1 0 47 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -5.5 0.25" />
                            <Vertex pos="0.25 -5.5 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -4.06586" album="" material="bm_edge_white" texgens="1 0 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -832 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="715" owner="0" type="0" pos="59.25 23 40.75" rot="1 0 0 0" scale="" transform="1 0 0 59.25 0 1 0 23 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5.49999 0.25" />
                            <Vertex pos="0.25 5.49999 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 5.99999 0.25" />
                            <Vertex pos="-0.25 5.99999 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.06586" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -832 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="716" owner="0" type="0" pos="52.75 26 40.75" rot="1 0 0 0" scale="" transform="1 0 0 52.75 0 1 0 26 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 2.5 0.25" />
                            <Vertex pos="-0.25 2.5 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.94454" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -832 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="717" owner="0" type="0" pos="53.25 16.75 40.75" rot="1 0 0 0" scale="" transform="1 0 0 53.25 0 1 0 16.75 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.25 0.25 0.25" />
                            <Vertex pos="6.25 0.25 -0.25" />
                            <Vertex pos="6.25 -0.25 0.25" />
                            <Vertex pos="6.25 -0.25 -0.25" />
                            <Vertex pos="-6.25 0.25 0.25" />
                            <Vertex pos="-6.25 0.25 -0.25" />
                            <Vertex pos="-5.75 -0.25 0.25" />
                            <Vertex pos="-5.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.25" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -4.24264" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2112 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 2240 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 2240 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2112 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="718" owner="0" type="0" pos="49.75 23.25 40.75" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 23.25 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.75 0.25 0.25" />
                            <Vertex pos="2.75 0.25 -0.25" />
                            <Vertex pos="2.75 -0.25 0.25" />
                            <Vertex pos="2.75 -0.25 -0.25" />
                            <Vertex pos="-2.25 0.25 0.25" />
                            <Vertex pos="-2.25 0.25 -0.25" />
                            <Vertex pos="-2.75 -0.25 0.25" />
                            <Vertex pos="-2.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.75" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.76777" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1344 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1216 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="719" owner="0" type="0" pos="18 23.25 40.75" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 23.25 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.94454" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1280 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1152 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="720" owner="0" type="0" pos="18 16.75 40.75" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 16.75 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="2.5 -0.25 0.25" />
                            <Vertex pos="2.5 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.94454" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1280 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1152 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="721" owner="0" type="0" pos="14.75 20 40.75" rot="1 0 0 0" scale="" transform="1 0 0 14.75 0 1 0 20 0 0 1 40.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.5 0.25" />
                            <Vertex pos="0.25 3.5 -0.25" />
                            <Vertex pos="0.25 -3.5 0.25" />
                            <Vertex pos="0.25 -3.5 -0.25" />
                            <Vertex pos="-0.25 3.5 0.25" />
                            <Vertex pos="-0.25 3.5 -0.25" />
                            <Vertex pos="-0.25 -3.5 0.25" />
                            <Vertex pos="-0.25 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.5" album="" material="bm_edge_white" texgens="-1 0 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_edge_white" texgens="1 0 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -832 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 960 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="722" owner="0" type="0" pos="41.25 53.25 38.5" rot="1 0 0 0" scale="" transform="1 0 0 41.25 0 1 0 53.25 0 0 1 38.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="723" owner="0" type="0" pos="41.25 46.75 38.5" rot="1 0 0 0" scale="" transform="1 0 0 41.25 0 1 0 46.75 0 0 1 38.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1088 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -960 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="724" owner="0" type="0" pos="-18 15 16" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 15 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 1" />
                            <Vertex pos="3 6 -1" />
                            <Vertex pos="3 -6 1" />
                            <Vertex pos="3 -6 -1" />
                            <Vertex pos="-3 6 1" />
                            <Vertex pos="-3 6 -1" />
                            <Vertex pos="-3 -6 1" />
                            <Vertex pos="-3 -6 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="725" owner="0" type="0" pos="-20 15 13" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 15 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 2" />
                            <Vertex pos="1 6 -2" />
                            <Vertex pos="1 -6 2" />
                            <Vertex pos="1 -6 -2" />
                            <Vertex pos="-1 6 2" />
                            <Vertex pos="-1 6 -2" />
                            <Vertex pos="-1 -6 2" />
                            <Vertex pos="-1 -6 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2304 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="726" owner="0" type="0" pos="-16 15 13" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 15 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 2" />
                            <Vertex pos="1 6 -2" />
                            <Vertex pos="1 -6 2" />
                            <Vertex pos="1 -6 -2" />
                            <Vertex pos="-1 6 2" />
                            <Vertex pos="-1 6 -2" />
                            <Vertex pos="-1 -6 2" />
                            <Vertex pos="-1 -6 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2304 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="727" owner="0" type="0" pos="-18.5 15 13" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 15 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 6 2" />
                            <Vertex pos="0.5 6 -2" />
                            <Vertex pos="0.5 -6 2" />
                            <Vertex pos="0.5 -6 -2" />
                            <Vertex pos="-0.5 6 2" />
                            <Vertex pos="-0.5 6 -2" />
                            <Vertex pos="-0.5 -6 2" />
                            <Vertex pos="-0.5 -6 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 960 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_stripe_caution2" texgens="1 0 -1 320 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2432 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 960 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="728" owner="0" type="0" pos="-17.5 15 13" rot="1 0 0 0" scale="" transform="1 0 0 -17.5 0 1 0 15 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 6 2" />
                            <Vertex pos="0.5 6 -2" />
                            <Vertex pos="0.5 -6 2" />
                            <Vertex pos="0.5 -6 -2" />
                            <Vertex pos="-0.5 6 2" />
                            <Vertex pos="-0.5 6 -2" />
                            <Vertex pos="-0.5 -6 2" />
                            <Vertex pos="-0.5 -6 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 832 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_stripe_caution2" texgens="1 0 1 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2176 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 832 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="777" owner="0" type="0" pos="-24.6084 51.9829 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.6084 0 1 0 51.9829 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.391578 1.01711 0.5" />
                            <Vertex pos="0.39158 0.965779 0.5" />
                            <Vertex pos="-0.39158 -0.982889 0.5" />
                            <Vertex pos="0.130526 -1.01711 0.5" />
                            <Vertex pos="-0.391579 1.01711 0" />
                            <Vertex pos="0.391581 0.965779 0" />
                            <Vertex pos="-0.391581 -0.982889 0" />
                            <Vertex pos="0.130526 -1.01711 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -923.754 0 -1 0 260.38 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -562.123 0 -1 0 130.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.0654033 0.997859 1.32543e-007 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 53.4262 0.997859 -0.0654021 0 128 -90 0.196205 0.125" texRot="-90" texScale="0.196205 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-1 9.98378e-007 2.02656e-006 -0.39158" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 1 0 159.453 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.991445 -0.130527 0 -0.26217" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 1 0 159.453 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.0654037 -0.997859 1.32544e-007 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 79.8637 0.997859 -0.065402 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="778" owner="0" type="0" pos="-23.9625 51.9062 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -23.9625 0 1 0 51.9062 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.254356 1.04249 0.5" />
                            <Vertex pos="0.51541 0.889366 0.5" />
                            <Vertex pos="-0.51541 -0.940404 0.5" />
                            <Vertex pos="-0.00223339 -1.04249 0.5" />
                            <Vertex pos="-0.254356 1.04249 2.98023e-008" />
                            <Vertex pos="0.515409 0.889366 2.98023e-008" />
                            <Vertex pos="-0.515409 -0.940404 2.98023e-008" />
                            <Vertex pos="-0.00223351 -1.04249 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -758.395 0 -1 0 280.017 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -644.802 0 -1 0 140.008 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.1951 0.980783 -3.95382e-007 -0.972832" album="Blasted" material="bm_edge_white" texgens="0 0 -1 54.1435 0.980784 -0.195095 0 128 -90 0.196217 0.125" texRot="-90" texScale="0.196217 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.991445 0.130526 0 -0.388252" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.130527 0.991445 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.965925 -0.258821 -2.31644e-007 -0.267661" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.130527 0.991445 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.195107 -0.980782 -3.95396e-007 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 78.7805 0.980784 -0.195098 0 128 90 0.130808 0.125" texRot="90" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="779" owner="0" type="0" pos="-23.3343 51.7455 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -23.3343 0 1 0 51.7455 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.112768 1.05002 0.5" />
                            <Vertex pos="0.630412 0.79774 0.5" />
                            <Vertex pos="-0.630412 -0.881833 0.5" />
                            <Vertex pos="-0.134959 -1.05002 0.5" />
                            <Vertex pos="-0.112768 1.05002 2.98023e-008" />
                            <Vertex pos="0.630411 0.79774 2.98023e-008" />
                            <Vertex pos="-0.630411 -0.881833 2.98023e-008" />
                            <Vertex pos="-0.13496 -1.05002 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -597.581 0 -1 0 321.144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -725.21 0 -1 0 160.572 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.321444 0.946928 -6.13107e-007 -0.958045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 55.5362 0.946929 -0.321444 0 128 -90 0.196212 0.125" texRot="-90" texScale="0.196212 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.965925 0.258821 0 -0.380693" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258822 0.965925 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.923879 -0.382685 -1.84476e-006 -0.27714" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258822 0.965925 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.321446 -0.946928 -6.1311e-007 -1.03768" album="Blasted" material="bm_edge_white" texgens="0 0 1 76.6924 0.946928 -0.321446 0 128 90 0.130805 0.125" texRot="90" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="780" owner="0" type="0" pos="-22.7346 51.5037 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -22.7346 0 1 0 51.5037 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0307353 1.03958 0.5" />
                            <Vertex pos="0.734636 0.692464 0.5" />
                            <Vertex pos="-0.734636 -0.808175 0.5" />
                            <Vertex pos="-0.265367 -1.03958 0.5" />
                            <Vertex pos="0.030735 1.03958 0" />
                            <Vertex pos="0.734636 0.692464 0" />
                            <Vertex pos="-0.734636 -0.808175 0" />
                            <Vertex pos="-0.265368 -1.03958 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -444.064 0 -1 0 383.056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -801.968 0 -1 0 191.528 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.442279 0.896877 0 -0.945969" album="Blasted" material="bm_edge_white" texgens="0 0 -1 57.5077 0.896875 -0.442284 0 128 -90 0.19621 0.125" texRot="-90" texScale="0.19621 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.923879 0.382686 5.57558e-007 -0.369437" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.382685 0.923879 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.866024 -0.500003 -1.75505e-006 -0.289978" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.382685 0.923879 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.44227 -0.896882 0 -1.04974" album="Blasted" material="bm_edge_white" texgens="0 0 1 73.7442 0.896879 -0.442276 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="781" owner="0" type="0" pos="-22.1737 51.1848 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -22.1737 0 1 0 51.1848 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.173717 1.01137 0.5" />
                            <Vertex pos="0.826287 0.575332 0.5" />
                            <Vertex pos="-0.826287 -0.720678 0.5" />
                            <Vertex pos="-0.39124 -1.01137 0.5" />
                            <Vertex pos="0.173717 1.01137 0" />
                            <Vertex pos="0.826286 0.575332 0" />
                            <Vertex pos="-0.826286 -0.720678 0" />
                            <Vertex pos="-0.391241 -1.01137 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -300.469 0 -1 0 464.696 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -873.766 0 -1 0 232.348 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.555574 0.831467 -1.05967e-006 -0.937433" album="Blasted" material="bm_edge_white" texgens="0 0 -1 59.9191 0.831466 -0.555576 0 128 -90 0.196205 0.125" texRot="-90" texScale="0.196205 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.866024 0.500002 0 -0.355244" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.500002 0.866025 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.793352 -0.608764 -1.60777e-006 -0.305294" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.500002 0.866025 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.555576 -0.831466 -1.05968e-006 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 70.121 0.831465 -0.555578 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="782" owner="0" type="0" pos="-21.6611 50.7943 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -21.6611 0 1 0 50.7943 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.313728 0.965846 0.5" />
                            <Vertex pos="0.903798 0.448366 0.5" />
                            <Vertex pos="-0.903798 -0.620857 0.5" />
                            <Vertex pos="-0.51042 -0.965846 0.5" />
                            <Vertex pos="0.313728 0.965846 0" />
                            <Vertex pos="0.903797 0.448366 0" />
                            <Vertex pos="-0.903799 -0.620857 0" />
                            <Vertex pos="-0.51042 -0.965846 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -169.254 0 -1 0 564.668 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -939.373 0 -1 0 282.334 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.659348 0.751838 -1.33621e-006 -0.933015" album="Blasted" material="bm_edge_white" texgens="0 0 -1 62.6066 0.751838 -0.659348 0 128 -90 0.196212 0.125" texRot="-90" texScale="0.196212 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.793352 0.608764 0 -0.339075" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.608763 0.793352 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.707105 -0.707108 0 -0.322037" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.608763 0.793352 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.659351 -0.751835 1.33621e-006 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 66.0874 0.751835 -0.659351 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="783" owner="0" type="0" pos="-21.2057 50.3388 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -21.2057 0 1 0 50.3388 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.448369 0.903797 0.5" />
                            <Vertex pos="0.965849 0.313717 0.5" />
                            <Vertex pos="-0.965849 -0.510415 0.5" />
                            <Vertex pos="-0.620857 -0.903797 0.5" />
                            <Vertex pos="0.448368 0.903797 5.96046e-008" />
                            <Vertex pos="0.965849 0.313716 5.96046e-008" />
                            <Vertex pos="-0.965849 -0.510415 5.96046e-008" />
                            <Vertex pos="-0.620857 -0.903797 5.96046e-008" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -52.6641 0 -1 0 681.259 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 5.96046e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -997.668 0 -1 0 340.629 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.751844 0.659341 -1.33619e-006 -0.933013" album="Blasted" material="bm_edge_white" texgens="0 0 -1 65.393 0.659341 -0.751844 0 128 -90 0.196208 0.125" texRot="-90" texScale="0.196208 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707106 0.707108 1.39084e-006 -0.322039" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707108 0.707105 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.608759 -0.793355 0 -0.33908" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707108 0.707105 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.751835 -0.659352 0 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 61.9135 0.659351 -0.751835 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="784" owner="0" type="0" pos="-20.8152 49.8263 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -20.8152 0 1 0 49.8263 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.575339 0.826281 0.5" />
                            <Vertex pos="1.01137 0.173711 0.5" />
                            <Vertex pos="-1.01137 -0.391235 0.5" />
                            <Vertex pos="-0.720681 -0.826281 0.5" />
                            <Vertex pos="0.57534 0.826281 0" />
                            <Vertex pos="1.01137 0.173711 0" />
                            <Vertex pos="-1.01137 -0.391234 0" />
                            <Vertex pos="-0.72068 -0.826282 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 47.3066 0 -1 0 812.475 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1047.65 0 -1 0 406.237 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.831471 0.555568 0 -0.937433" album="Blasted" material="bm_edge_white" texgens="0 0 -1 68.084 0.555567 -0.831472 0 128 -90 0.196204 0.125" texRot="-90" texScale="0.196204 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.608758 0.793356 -1.16111e-006 -0.305292" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.793355 0.608759 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.499997 -0.866027 2.76833e-006 -0.355245" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.793355 0.608759 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.831469 -0.55557 -1.09278e-006 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 57.877 0.555568 -0.831471 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="785" owner="0" type="0" pos="-20.4963 49.2654 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -20.4963 0 1 0 49.2654 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.69246 0.734631 0.5" />
                            <Vertex pos="1.03959 0.0307314 0.5" />
                            <Vertex pos="-1.03959 -0.26536 0.5" />
                            <Vertex pos="-0.808179 -0.734631 0.5" />
                            <Vertex pos="0.692459 0.734631 0" />
                            <Vertex pos="1.03959 0.0307317 0" />
                            <Vertex pos="-1.03959 -0.26536 0" />
                            <Vertex pos="-0.80818 -0.734631 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 128.947 0 -1 0 956.071 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1088.47 0 -1 0 478.035 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.89687 0.442294 2.65275e-007 -0.94597" album="Blasted" material="bm_edge_white" texgens="0 0 -1 70.4959 0.442294 -0.89687 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.499997 0.866027 1.01327e-006 -0.289983" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866027 0.499997 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.38268 -0.923881 -7.29904e-007 -0.369438" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866027 0.499997 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.896879 -0.442275 0 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 54.2577 0.442276 -0.896879 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="786" owner="0" type="0" pos="-20.2545 48.6657 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -20.2545 0 1 0 48.6657 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.79775 0.630409 0.5" />
                            <Vertex pos="1.05002 -0.11278 0.5" />
                            <Vertex pos="-1.05002 -0.134953 0.5" />
                            <Vertex pos="-0.881831 -0.630409 0.5" />
                            <Vertex pos="0.797749 0.630409 0" />
                            <Vertex pos="1.05002 -0.112781 0" />
                            <Vertex pos="-1.05002 -0.134953 0" />
                            <Vertex pos="-0.88183 -0.630409 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 190.858 0 -1 0 1109.59 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1119.43 0 -1 0 554.794 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.946934 0.32143 -6.46606e-007 -0.958048" album="Blasted" material="bm_edge_white" texgens="0 0 -1 72.462 0.321429 -0.946934 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.38268 0.923881 7.75522e-007 -0.277141" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.923881 0.38268 0 160.695 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.258815 -0.965927 5.24503e-007 -0.380698" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.923881 0.38268 0 160.695 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.946927 -0.321449 0 -1.03767" album="Blasted" material="bm_edge_white" texgens="0 0 1 51.3086 0.321446 -0.946928 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="787" owner="0" type="0" pos="-20.0938 48.0375 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -20.0938 0 1 0 48.0375 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.88937 0.515401 0.5" />
                            <Vertex pos="1.04248 -0.254357 0.5" />
                            <Vertex pos="-1.04248 -0.00222814 0.5" />
                            <Vertex pos="-0.94041 -0.515401 0.5" />
                            <Vertex pos="0.88937 0.515401 0" />
                            <Vertex pos="1.04248 -0.254357 0" />
                            <Vertex pos="-1.04248 -0.00222778 0" />
                            <Vertex pos="-0.940411 -0.515401 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 231.984 0 -1 0 1270.4 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1139.99 0 -1 0 635.201 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.980786 0.195085 0 -0.972829" album="Blasted" material="bm_edge_white" texgens="0 0 -1 73.8561 0.195085 -0.980786 0 128 -90 0.196205 0.125" texRot="-90" texScale="0.196205 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.258815 0.965927 0 -0.267657" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965927 0.258815 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.130522 -0.991445 -2.48951e-007 -0.388248" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965927 0.258815 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.980788 -0.195077 -1.40438e-007 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 49.2162 0.195079 -0.980787 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="788" owner="0" type="0" pos="-20.0171 47.3916 24.5" rot="1 0 0 0" scale="" transform="1 0 0 -20.0171 0 1 0 47.3916 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.96578 0.391566 0.5" />
                            <Vertex pos="1.01711 -0.391566 0.5" />
                            <Vertex pos="-1.01711 0.130522 0.5" />
                            <Vertex pos="-0.98289 -0.391566 0.5" />
                            <Vertex pos="0.96578 0.391566 0" />
                            <Vertex pos="1.01711 -0.391566 0" />
                            <Vertex pos="-1.01711 0.130522 0" />
                            <Vertex pos="-0.982891 -0.391566 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 251.62 0 -1 0 1435.76 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1149.81 0 -1 0 717.88 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.997859 0.0654041 0 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 74.5754 0.0654043 -0.997859 0 128 -90 0.196205 0.125" texRot="-90" texScale="0.196205 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.130522 0.991445 0 -0.262161" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.991445 0.130522 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 -0 -0.391566" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.991445 0.130522 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.997859 -0.0654022 0 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 48.1376 0.0654041 -0.997859 0 128 90 0.130802 0.125" texRot="90" texScale="0.130802 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="789" owner="0" type="0" pos="-29.3916 52.0171 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -29.3916 0 1 0 52.0171 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.391576 -1.01711 0.5" />
                            <Vertex pos="-0.391583 -0.965779 0.5" />
                            <Vertex pos="0.391583 0.982889 0.5" />
                            <Vertex pos="-0.130523 1.01711 0.5" />
                            <Vertex pos="0.391577 -1.01711 0" />
                            <Vertex pos="-0.391582 -0.965779 0" />
                            <Vertex pos="0.391582 0.982889 0" />
                            <Vertex pos="-0.130524 1.01711 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1124.25 0 -1 0 2811.62 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -461.876 0 -1 0 1405.81 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.0654032 -0.997859 -1.28645e-007 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 53.4268 -0.997859 0.065402 0 128 -90 0.196205 0.125" texRot="-90" texScale="0.196205 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="1 -2.5034e-006 2.02656e-006 -0.39158" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 -1 0 159.453 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.991444 0.13053 1.97967e-006 -0.262171" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 -1 0 159.453 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.0654038 0.997859 -1.28646e-007 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 79.8642 -0.997859 0.0654019 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="790" owner="0" type="0" pos="-30.0375 52.0938 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -30.0375 0 1 0 52.0938 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.254349 -1.04249 0.5" />
                            <Vertex pos="-0.51541 -0.889365 0.5" />
                            <Vertex pos="0.51541 0.940405 0.5" />
                            <Vertex pos="0.00223708 1.04249 0.5" />
                            <Vertex pos="0.254349 -1.04249 0" />
                            <Vertex pos="-0.515409 -0.889365 0" />
                            <Vertex pos="0.515409 0.940405 0" />
                            <Vertex pos="0.00223732 1.04249 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1289.61 0 -1 0 2791.98 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -379.196 0 -1 0 1395.99 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.195103 -0.980783 -3.95388e-007 -0.972832" album="Blasted" material="bm_edge_white" texgens="0 0 -1 54.1434 -0.980784 0.195097 0 128 -90 0.196215 0.125" texRot="-90" texScale="0.196215 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.991444 -0.13053 0 -0.388249" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.13053 -0.991444 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.965925 0.258823 -4.63737e-007 -0.267659" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.13053 -0.991444 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.195107 0.980782 -3.95395e-007 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 78.7811 -0.980784 0.195098 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="791" owner="0" type="0" pos="-30.6657 52.2545 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -30.6657 0 1 0 52.2545 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.112771 -1.05002 0.5" />
                            <Vertex pos="-0.630419 -0.79774 0.5" />
                            <Vertex pos="0.630419 0.881831 0.5" />
                            <Vertex pos="0.13496 1.05002 0.5" />
                            <Vertex pos="0.112772 -1.05002 5.96046e-008" />
                            <Vertex pos="-0.630419 -0.797741 5.96046e-008" />
                            <Vertex pos="0.630419 0.881831 5.96046e-008" />
                            <Vertex pos="0.13496 1.05002 5.96046e-008" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1450.42 0 -1 0 2750.86 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 5.96046e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -298.789 0 -1 0 1375.43 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.321441 -0.94693 1.91901e-006 -0.958047" album="Blasted" material="bm_edge_white" texgens="0 0 -1 55.5378 -0.94693 0.32144 0 128 -90 0.196212 0.125" texRot="-90" texScale="0.196212 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.965925 -0.258823 1.94311e-006 -0.380699" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258823 -0.965925 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.923877 0.382688 0 -0.277144" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258823 -0.965925 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.321445 0.946928 -0 -1.03768" album="Blasted" material="bm_edge_white" texgens="0 0 1 76.6932 -0.946928 0.321446 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="792" owner="0" type="0" pos="-31.2654 52.4963 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -31.2654 0 1 0 52.4963 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0307388 -1.03959 0.5" />
                            <Vertex pos="-0.734639 -0.692459 0.5" />
                            <Vertex pos="0.734639 0.808171 0.5" />
                            <Vertex pos="0.265372 1.03959 0.5" />
                            <Vertex pos="-0.0307388 -1.03959 0" />
                            <Vertex pos="-0.734639 -0.692459 0" />
                            <Vertex pos="0.734638 0.808171 0" />
                            <Vertex pos="0.265371 1.03959 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1603.94 0 -1 0 2688.94 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -222.03 0 -1 0 1344.47 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.442295 -0.89687 -0 -0.945972" album="Blasted" material="bm_edge_white" texgens="0 0 -1 57.506 -0.89687 0.442294 0 128 -90 0.196212 0.125" texRot="-90" texScale="0.196212 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.923878 -0.382687 0 -0.369439" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.382688 -0.923878 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866023 0.500005 1.75505e-006 -0.289982" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.382688 -0.923878 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.442292 0.896871 -8.9633e-007 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 73.7406 -0.896872 0.442291 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="793" owner="0" type="0" pos="-31.8263 52.8152 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -31.8263 0 1 0 52.8152 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.173746 -1.01136 0.5" />
                            <Vertex pos="-0.826266 -0.57536 0.5" />
                            <Vertex pos="0.826265 0.720689 0.5" />
                            <Vertex pos="0.391255 1.01136 0.5" />
                            <Vertex pos="-0.173746 -1.01136 2.98023e-008" />
                            <Vertex pos="-0.826265 -0.575359 2.98023e-008" />
                            <Vertex pos="0.826265 0.720689 2.98023e-008" />
                            <Vertex pos="0.391255 1.01136 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1747.53 0 -1 0 2607.3 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -150.236 0 -1 0 1303.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.55557 -0.83147 -2.81092e-006 -0.937442" album="Blasted" material="bm_edge_white" texgens="0 0 -1 59.9177 -0.83147 0.55557 0 128 -90 0.196196 0.125" texRot="-90" texScale="0.196196 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.866023 -0.500004 0 -0.355217" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.500005 -0.866023 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.793356 0.608758 0 -0.305269" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.500005 -0.866023 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.555579 0.831464 -0 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 70.1212 -0.831465 0.555577 0 128 90 0.130796 0.125" texRot="90" texScale="0.130796 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="794" owner="0" type="0" pos="-32.3388 53.2057 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -32.3388 0 1 0 53.2057 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.313725 -0.965852 0.5" />
                            <Vertex pos="-0.903796 -0.448372 0.5" />
                            <Vertex pos="0.903796 0.620869 0.5" />
                            <Vertex pos="0.510413 0.965852 0.5" />
                            <Vertex pos="-0.313725 -0.965852 0" />
                            <Vertex pos="-0.903796 -0.448372 0" />
                            <Vertex pos="0.903796 0.620869 0" />
                            <Vertex pos="0.510413 0.965852 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1878.74 0 -1 0 2507.34 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -84.6306 0 -1 0 1253.67 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.659347 -0.751839 -0 -0.933019" album="Blasted" material="bm_edge_white" texgens="0 0 -1 62.6053 -0.751838 0.659348 0 128 -90 0.196214 0.125" texRot="-90" texScale="0.196214 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.793356 -0.608757 0 -0.339074" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.608758 -0.793356 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.707111 0.707103 0 -0.322039" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.608758 -0.793356 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.659341 0.751844 -0 -1.06271" album="Blasted" material="bm_edge_white" texgens="0 0 1 66.0889 -0.751845 0.65934 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="795" owner="0" type="0" pos="-32.7943 53.6611 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -32.7943 0 1 0 53.6611 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.448359 -0.903802 0.5" />
                            <Vertex pos="-0.965849 -0.313732 0.5" />
                            <Vertex pos="0.965849 0.51042 0.5" />
                            <Vertex pos="0.620859 0.903802 0.5" />
                            <Vertex pos="-0.448359 -0.903802 0" />
                            <Vertex pos="-0.965849 -0.313732 0" />
                            <Vertex pos="0.965849 0.51042 0" />
                            <Vertex pos="0.620859 0.903802 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1995.33 0 -1 0 2390.75 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -26.3347 0 -1 0 1195.37 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.751832 -0.659355 -0 -0.933017" album="Blasted" material="bm_edge_white" texgens="0 0 -1 65.3946 -0.659355 0.751832 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.70711 -0.707103 0 -0.322042" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707103 -0.70711 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.608765 0.793351 0 -0.339075" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707103 -0.70711 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.751837 0.659349 -0 -1.06271" album="Blasted" material="bm_edge_white" texgens="0 0 1 61.9128 -0.659351 0.751835 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="796" owner="0" type="0" pos="-33.1848 54.1737 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.1848 0 1 0 54.1737 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.575339 -0.82629 0.5" />
                            <Vertex pos="-1.01137 -0.17372 0.5" />
                            <Vertex pos="1.01137 0.391244 0.5" />
                            <Vertex pos="0.720682 0.82629 0.5" />
                            <Vertex pos="-0.575339 -0.82629 0" />
                            <Vertex pos="-1.01137 -0.173719 0" />
                            <Vertex pos="1.01137 0.391245 0" />
                            <Vertex pos="0.720682 0.82629 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2095.3 0 -1 0 2259.53 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 23.6506 0 -1 0 1129.77 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.831471 -0.555568 -1.10933e-006 -0.937438" album="Blasted" material="bm_edge_white" texgens="0 0 -1 68.0821 -0.555567 0.831472 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.608765 -0.793351 0 -0.305292" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.793351 -0.608765 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.500004 0.866023 0 -0.355243" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.793351 -0.608765 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.83147 0.55557 1.1259e-006 -1.05829" album="Blasted" material="bm_edge_white" texgens="0 0 1 57.8756 -0.555569 0.83147 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="797" owner="0" type="0" pos="-33.5037 54.7346 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.5037 0 1 0 54.7346 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.69246 -0.734637 0.5" />
                            <Vertex pos="-1.03959 -0.0307369 0.5" />
                            <Vertex pos="1.03959 0.265371 0.5" />
                            <Vertex pos="0.808167 0.734637 0.5" />
                            <Vertex pos="-0.69246 -0.734636 0" />
                            <Vertex pos="-1.03959 -0.0307369 0" />
                            <Vertex pos="1.03959 0.265371 0" />
                            <Vertex pos="0.808167 0.734636 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2176.94 0 -1 0 2115.94 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 64.4709 0 -1 0 1057.97 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.89687 -0.442294 -0 -0.945972" album="Blasted" material="bm_edge_white" texgens="0 0 -1 70.4947 -0.442294 0.89687 0 128 -90 0.196208 0.125" texRot="-90" texScale="0.196208 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.500003 -0.866024 -1.75505e-006 -0.28998" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866024 -0.500004 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.382687 0.923878 -1.87229e-006 -0.369439" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866024 -0.500004 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.896867 0.4423 -0 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 0.999999 54.2616 -0.442298 0.896868 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="798" owner="0" type="0" pos="-33.7455 55.3343 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.7455 0 1 0 55.3343 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.79774 -0.630417 0.5" />
                            <Vertex pos="-1.05002 0.112773 0.5" />
                            <Vertex pos="1.05002 0.134958 0.5" />
                            <Vertex pos="0.88183 0.630417 0.5" />
                            <Vertex pos="-0.79774 -0.630417 0" />
                            <Vertex pos="-1.05002 0.112773 0" />
                            <Vertex pos="1.05002 0.134957 0" />
                            <Vertex pos="0.88183 0.630417 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2238.86 0 -1 0 1962.42 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 95.428 0 -1 0 981.21 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.94693 -0.321441 -0 -0.958045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 72.4628 -0.32144 0.94693 0 128 -90 0.196208 0.125" texRot="-90" texScale="0.196208 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.382686 -0.923878 0 -0.277144" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.923878 -0.382687 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.258822 0.965925 0 -0.380699" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.923878 -0.382687 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.946928 0.321446 -6.4185e-007 -1.03767" album="Blasted" material="bm_edge_white" texgens="0 0 1 51.3072 -0.321446 0.946928 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="799" owner="0" type="0" pos="-33.9062 55.9625 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.9062 0 1 0 55.9625 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.889365 -0.515407 0.5" />
                            <Vertex pos="-1.04249 0.254348 0.5" />
                            <Vertex pos="1.04249 0.00223684 0.5" />
                            <Vertex pos="0.940407 0.515407 0.5" />
                            <Vertex pos="-0.889365 -0.515407 0" />
                            <Vertex pos="-1.04249 0.254349 0" />
                            <Vertex pos="1.04249 0.00223732 0" />
                            <Vertex pos="0.940407 0.515407 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2279.98 0 -1 0 1801.61 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 115.992 0 -1 0 900.803 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.980783 -0.195104 -3.83761e-007 -0.972832" album="Blasted" material="bm_edge_white" texgens="0 0 -1 73.8576 -0.195098 0.980784 0 128 -90 0.196204 0.125" texRot="-90" texScale="0.196204 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.258822 -0.965925 0 -0.267658" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965925 -0.258822 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.130529 0.991445 0 -0.388247" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965925 -0.258822 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.980783 0.195104 1.87246e-007 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 49.219 -0.195097 0.980784 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="800" owner="0" type="0" pos="-33.9829 56.6084 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.9829 0 1 0 56.6084 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.96578 -0.391583 0.5" />
                            <Vertex pos="-1.01711 0.391577 0.5" />
                            <Vertex pos="1.01711 -0.130524 0.5" />
                            <Vertex pos="0.98289 0.391583 0.5" />
                            <Vertex pos="-0.96578 -0.391582 0" />
                            <Vertex pos="-1.01711 0.391578 0" />
                            <Vertex pos="1.01711 -0.130525 0" />
                            <Vertex pos="0.98289 0.391582 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2299.62 0 -1 0 1636.25 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 125.81 0 -1 0 818.124 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.997859 -0.0654018 -1.28642e-007 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 74.5752 -0.065402 0.997859 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.130528 -0.991445 -1.95013e-006 -0.26217" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.991444 -0.130529 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-2.99513e-006 1 -1.96695e-006 -0.391579" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.991444 -0.130529 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.997859 0.0654018 -1.30591e-007 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 48.1359 -0.0654018 0.997859 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="801" owner="0" type="0" pos="-33.9829 57.3916 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.9829 0 1 0 57.3916 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.01711 -0.391579 0.5" />
                            <Vertex pos="-0.96578 0.391579 0.5" />
                            <Vertex pos="0.98289 -0.391574 0.5" />
                            <Vertex pos="1.01711 0.130531 0.5" />
                            <Vertex pos="-1.01711 -0.39158 0" />
                            <Vertex pos="-0.96578 0.39158 0" />
                            <Vertex pos="0.98289 -0.391574 0" />
                            <Vertex pos="1.01711 0.130531 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2299.62 0 -1 0 1435.76 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 125.81 0 -1 0 717.88 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.997859 0.065402 1.28643e-007 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 53.4244 0.065402 0.997859 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="2.99513e-006 -1 1.96695e-006 -0.391577" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -1 0 0 159.452 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.130524 0.991445 0 -0.262172" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -1 0 0 159.452 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.997859 -0.065402 0 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 79.8622 0.0654019 0.997859 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="802" owner="0" type="0" pos="-33.9062 58.0375 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.9062 0 1 0 58.0375 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.04248 -0.254355 0.5" />
                            <Vertex pos="-0.88937 0.515402 0.5" />
                            <Vertex pos="0.94041 -0.515402 0.5" />
                            <Vertex pos="1.04248 -0.00223005 0.5" />
                            <Vertex pos="-1.04248 -0.254354 0" />
                            <Vertex pos="-0.88937 0.515403 0" />
                            <Vertex pos="0.940411 -0.515403 0" />
                            <Vertex pos="1.04248 -0.00222969 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2279.98 0 -1 0 1270.4 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 115.992 0 -1 0 635.2 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.980786 0.195085 3.72095e-007 -0.972829" album="Blasted" material="bm_edge_white" texgens="0 0 -1 54.1463 0.195085 0.980786 0 128 -90 0.196208 0.125" texRot="-90" texScale="0.196208 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.130524 -0.991445 -2.00922e-006 -0.388247" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.991445 0.130524 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.258816 0.965927 6.95382e-007 -0.267657" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.991445 0.130524 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.980788 -0.195077 2.24278e-006 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 78.7845 0.195078 0.980788 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="803" owner="0" type="0" pos="-33.7455 58.6657 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.7455 0 1 0 58.6657 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.05002 -0.112779 0.5" />
                            <Vertex pos="-0.79774 0.630411 0.5" />
                            <Vertex pos="0.88183 -0.630411 0.5" />
                            <Vertex pos="1.05002 -0.134952 0.5" />
                            <Vertex pos="-1.05002 -0.112779 0" />
                            <Vertex pos="-0.79774 0.630411 0" />
                            <Vertex pos="0.88183 -0.630411 0" />
                            <Vertex pos="1.05002 -0.134952 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2238.86 0 -1 0 1109.59 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 95.429 0 -1 0 554.793 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.94693 0.321441 0 -0.958043" album="Blasted" material="bm_edge_white" texgens="0 0 -1 55.5371 0.32144 0.94693 0 128 -90 0.19621 0.125" texRot="-90" texScale="0.19621 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.258816 -0.965927 0 -0.380699" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965927 0.258817 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.382682 0.92388 0 -0.277144" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965927 0.258817 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.946928 -0.321447 0 -1.03767" album="Blasted" material="bm_edge_white" texgens="0 0 1 76.6914 0.321446 0.946928 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="804" owner="0" type="0" pos="-33.5037 59.2654 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.5037 0 1 0 59.2654 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.03959 0.0307312 0.5" />
                            <Vertex pos="-0.69247 0.734631 0.5" />
                            <Vertex pos="0.808168 -0.734631 0.5" />
                            <Vertex pos="1.03959 -0.265369 0.5" />
                            <Vertex pos="-1.03959 0.0307312 0" />
                            <Vertex pos="-0.69247 0.734632 0" />
                            <Vertex pos="0.808168 -0.734632 0" />
                            <Vertex pos="1.03959 -0.265368 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2176.94 0 -1 0 956.068 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 64.4724 0 -1 0 478.034 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.896875 0.442284 8.96313e-007 -0.945975" album="Blasted" material="bm_edge_white" texgens="0 0 -1 57.5068 0.442284 0.896875 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.382682 -0.92388 0 -0.36944" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.92388 0.382682 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.499998 0.866027 1.70343e-006 -0.289977" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.92388 0.382682 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.896868 -0.442299 8.96344e-007 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 73.7373 0.442299 0.896868 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="805" owner="0" type="0" pos="-33.1848 59.8263 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.1848 0 1 0 59.8263 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.01137 0.173716 0.5" />
                            <Vertex pos="-0.575332 0.826286 0.5" />
                            <Vertex pos="0.72069 -0.826286 0.5" />
                            <Vertex pos="1.01137 -0.391232 0.5" />
                            <Vertex pos="-1.01137 0.173716 0" />
                            <Vertex pos="-0.575332 0.826286 0" />
                            <Vertex pos="0.72069 -0.826286 0" />
                            <Vertex pos="1.01137 -0.391232 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2095.31 0 -1 0 812.474 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 23.6531 0 -1 0 406.237 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.831467 0.555574 0 -0.937433" album="Blasted" material="bm_edge_white" texgens="0 0 -1 59.9174 0.555576 0.831466 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.499999 -0.866026 0 -0.355241" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866026 0.499998 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.608761 0.793354 0 -0.305297" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866026 0.499998 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.831482 -0.555552 0 -1.05829" album="Blasted" material="bm_edge_white" texgens="0 0 1 70.1264 0.555555 0.83148 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="806" owner="0" type="0" pos="-32.7943 60.3388 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -32.7943 0 1 0 60.3388 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.965847 0.313718 0.5" />
                            <Vertex pos="-0.448367 0.903798 0.5" />
                            <Vertex pos="0.620855 -0.903798 0.5" />
                            <Vertex pos="0.965847 -0.510416 0.5" />
                            <Vertex pos="-0.965847 0.313718 0" />
                            <Vertex pos="-0.448367 0.903798 0" />
                            <Vertex pos="0.620855 -0.903799 0" />
                            <Vertex pos="0.965847 -0.510417 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1995.33 0 -1 0 681.256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -26.3333 0 -1 0 340.628 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.751844 0.659341 0 -0.933013" album="Blasted" material="bm_edge_white" texgens="0 0 -1 62.6079 0.659341 0.751844 0 128 -90 0.196212 0.125" texRot="-90" texScale="0.196212 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.608761 -0.793354 0 -0.33908" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.793354 0.608761 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.707107 0.707107 -1.43299e-006 -0.322038" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.793354 0.608761 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.751835 -0.659352 1.33621e-006 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 66.087 0.659351 0.751835 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="807" owner="0" type="0" pos="-32.3388 60.7943 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -32.3388 0 1 0 60.7943 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.903797 0.448368 0.5" />
                            <Vertex pos="-0.313727 0.965848 0.5" />
                            <Vertex pos="0.510419 -0.965848 0.5" />
                            <Vertex pos="0.903797 -0.620859 0.5" />
                            <Vertex pos="-0.903797 0.448368 0" />
                            <Vertex pos="-0.313726 0.965848 0" />
                            <Vertex pos="0.510419 -0.965848 0" />
                            <Vertex pos="0.903797 -0.620859 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1878.74 0 -1 0 564.666 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -84.6282 0 -1 0 282.333 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.659348 0.751838 -1.29691e-006 -0.933016" album="Blasted" material="bm_edge_white" texgens="0 0 -1 65.3938 0.751838 0.659348 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 0 -0.322037" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707107 0.707107 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.793353 0.608762 0 -0.339075" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707107 0.707107 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.659352 -0.751834 0 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 61.9132 0.751835 0.659351 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="808" owner="0" type="0" pos="-31.8263 61.1848 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -31.8263 0 1 0 61.1848 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.826285 0.575338 0.5" />
                            <Vertex pos="-0.173715 1.01137 0.5" />
                            <Vertex pos="0.391239 -1.01137 0.5" />
                            <Vertex pos="0.826285 -0.720682 0.5" />
                            <Vertex pos="-0.826285 0.575338 0" />
                            <Vertex pos="-0.173715 1.01137 0" />
                            <Vertex pos="0.391239 -1.01137 0" />
                            <Vertex pos="0.826285 -0.720682 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1747.53 0 -1 0 464.696 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -150.236 0 -1 0 232.348 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.555569 0.83147 0 -0.937435" album="Blasted" material="bm_edge_white" texgens="0 0 -1 68.0809 0.831472 0.555567 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.793353 -0.608761 0 -0.305292" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.608762 0.793353 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.866026 0.5 0 -0.355243" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.608762 0.793353 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.55557 -0.83147 0 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 57.8764 0.831471 0.555569 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="809" owner="0" type="0" pos="-31.2654 61.5037 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -31.2654 0 1 0 61.5037 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.734634 0.69246 0.5" />
                            <Vertex pos="-0.0307338 1.03959 0.5" />
                            <Vertex pos="0.265366 -1.03959 0.5" />
                            <Vertex pos="0.734633 -0.808171 0.5" />
                            <Vertex pos="-0.734633 0.69246 0" />
                            <Vertex pos="-0.0307341 1.03959 0" />
                            <Vertex pos="0.265366 -1.03959 0" />
                            <Vertex pos="0.734634 -0.808171 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1603.93 0 -1 0 383.055 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -222.033 0 -1 0 191.528 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.442294 0.89687 2.65275e-007 -0.945971" album="Blasted" material="bm_edge_white" texgens="0 0 -1 70.4933 0.89687 0.442294 0 128 -90 0.196213 0.125" texRot="-90" texScale="0.196213 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.866026 -0.5 -1.65181e-006 -0.289981" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.5 0.866025 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.92388 0.382683 1.76216e-006 -0.36944" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.5 0.866025 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.442291 -0.896872 0 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 54.2607 0.896871 0.442291 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="810" owner="0" type="0" pos="-30.6657 61.7455 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -30.6657 0 1 0 61.7455 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.630414 0.797741 0.5" />
                            <Vertex pos="0.112776 1.05002 0.5" />
                            <Vertex pos="0.134953 -1.05002 0.5" />
                            <Vertex pos="0.630414 -0.88184 0.5" />
                            <Vertex pos="-0.630415 0.797741 2.98023e-008" />
                            <Vertex pos="0.112776 1.05002 2.98023e-008" />
                            <Vertex pos="0.134953 -1.05002 2.98023e-008" />
                            <Vertex pos="0.630415 -0.881841 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1450.42 0 -1 0 321.142 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -298.792 0 -1 0 160.571 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.321439 0.94693 0 -0.958045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 72.4634 0.94693 0.32144 0 128 -90 0.196208 0.125" texRot="-90" texScale="0.196208 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.92388 -0.382684 1.8723e-006 -0.277145" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.382683 0.92388 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.965926 0.258818 1.433e-006 -0.380698" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.382683 0.92388 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.321426 -0.946935 0 -1.03768" album="Blasted" material="bm_edge_white" texgens="0 0 1 51.3039 0.946934 0.321429 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="811" owner="0" type="0" pos="-30.0375 61.9062 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -30.0375 0 1 0 61.9062 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.515404 0.889376 0.5" />
                            <Vertex pos="0.254353 1.04249 0.5" />
                            <Vertex pos="0.0022347 -1.04249 0.5" />
                            <Vertex pos="0.515404 -0.940405 0.5" />
                            <Vertex pos="-0.515404 0.889376 0" />
                            <Vertex pos="0.254353 1.04249 0" />
                            <Vertex pos="0.00223541 -1.04249 0" />
                            <Vertex pos="0.515404 -0.940405 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1289.6 0 -1 0 280.017 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -379.199 0 -1 0 140.008 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.19509 0.980785 0 -0.972837" album="Blasted" material="bm_edge_white" texgens="0 0 -1 73.8554 0.980786 0.195085 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.965926 -0.258818 0 -0.267656" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258818 0.965926 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.991445 0.130525 0 -0.388248" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258818 0.965926 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.195108 -0.980782 2.77105e-007 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 49.22 0.980784 0.195099 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="812" owner="0" type="0" pos="-29.3916 61.9829 26.5" rot="1 0 0 0" scale="" transform="1 0 0 -29.3916 0 1 0 61.9829 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.391579 0.96578 0.5" />
                            <Vertex pos="0.391579 1.01711 0.5" />
                            <Vertex pos="-0.130529 -1.01711 0.5" />
                            <Vertex pos="0.391577 -0.98289 0.5" />
                            <Vertex pos="-0.391579 0.96578 0" />
                            <Vertex pos="0.391579 1.01711 0" />
                            <Vertex pos="-0.130529 -1.01711 0" />
                            <Vertex pos="0.391577 -0.98289 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1124.24 0 -1 0 260.38 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -461.879 0 -1 0 130.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.065402 0.997859 0 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 74.5735 0.997859 0.065402 0 128 -90 0.196214 0.125" texRot="-90" texScale="0.196214 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.991445 -0.130525 0 -0.262171" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.130525 0.991445 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="1 -9.98378e-007 0 -0.391578" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.130525 0.991445 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.0654019 -0.997859 0 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 48.1371 0.997859 0.0654019 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="813" owner="0" type="0" pos="-12.0171 66.6084 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -12.0171 0 1 0 66.6084 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.01711 0.39158 0.5" />
                            <Vertex pos="0.96578 -0.39158 0.5" />
                            <Vertex pos="-0.98289 0.39158 0.5" />
                            <Vertex pos="-1.01711 -0.130527 0.5" />
                            <Vertex pos="1.01711 0.39158 0" />
                            <Vertex pos="0.96578 -0.39158 0" />
                            <Vertex pos="-0.982891 0.39158 0" />
                            <Vertex pos="-1.01711 -0.130527 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 251.62 0 -1 0 1636.24 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1149.81 0 -1 0 818.122 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.997859 -0.0654018 0 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 53.4244 -0.065402 -0.997859 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.39158" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 1 0 0 159.452 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.130526 -0.991445 -0 -0.26217" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 1 0 0 159.452 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.997859 0.0653998 2.02222e-006 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 79.8634 -0.0654019 -0.997859 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="814" owner="0" type="0" pos="-12.0938 65.9625 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -12.0938 0 1 0 65.9625 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.04249 0.254349 0.5" />
                            <Vertex pos="0.889376 -0.515402 0.5" />
                            <Vertex pos="-0.940404 0.515402 0.5" />
                            <Vertex pos="-1.04248 0.0022366 0.5" />
                            <Vertex pos="1.04248 0.254349 2.98023e-008" />
                            <Vertex pos="0.889376 -0.515402 2.98023e-008" />
                            <Vertex pos="-0.940405 0.515402 2.98023e-008" />
                            <Vertex pos="-1.04248 0.00223637 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 231.983 0 -1 0 1801.6 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -1139.99 0 -1 0 900.801 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.980785 -0.195092 0 -0.972837" album="Blasted" material="bm_edge_white" texgens="0 0 -1 54.1459 -0.195087 -0.980786 0 128 -90 0.196207 0.125" texRot="-90" texScale="0.196207 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.130527 0.991445 -2.61408e-006 -0.388245" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.991445 -0.130526 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.258819 -0.965926 4.44397e-007 -0.267653" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.991445 -0.130526 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.980785 0.19509 1.98762e-006 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 78.7798 -0.1951 -0.980783 0 128 90 0.130805 0.125" texRot="90" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="815" owner="0" type="0" pos="-12.2545 65.3343 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -12.2545 0 1 0 65.3343 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.05002 0.112776 0.5" />
                            <Vertex pos="0.797741 -0.630414 0.5" />
                            <Vertex pos="-0.88184 0.630415 0.5" />
                            <Vertex pos="-1.05002 0.134953 0.5" />
                            <Vertex pos="1.05002 0.112776 2.98023e-008" />
                            <Vertex pos="0.797741 -0.630414 2.98023e-008" />
                            <Vertex pos="-0.88184 0.630415 2.98023e-008" />
                            <Vertex pos="-1.05002 0.134953 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 190.858 0 -1 0 1962.42 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -1119.43 0 -1 0 981.208 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.94693 -0.321439 0 -0.958045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 55.5378 -0.32144 -0.94693 0 128 -90 0.19621 0.125" texRot="-90" texScale="0.19621 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.258818 0.965926 -0 -0.380698" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965926 -0.258818 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.382683 -0.92388 -0 -0.277145" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965926 -0.258818 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.946934 0.321428 0 -1.03768" album="Blasted" material="bm_edge_white" texgens="0 0 1 76.6962 -0.321429 -0.946934 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="816" owner="0" type="0" pos="-12.4963 64.7346 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -12.4963 0 1 0 64.7346 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.03959 -0.0307338 0.5" />
                            <Vertex pos="0.69246 -0.734634 0.5" />
                            <Vertex pos="-0.808171 0.734633 0.5" />
                            <Vertex pos="-1.03959 0.265366 0.5" />
                            <Vertex pos="1.03959 -0.0307341 0" />
                            <Vertex pos="0.692459 -0.734633 0" />
                            <Vertex pos="-0.80817 0.734633 0" />
                            <Vertex pos="-1.03959 0.265367 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 128.944 0 -1 0 2115.93 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1088.47 0 -1 0 1057.97 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.89687 -0.442294 -2.66117e-006 -0.945969" album="Blasted" material="bm_edge_white" texgens="0 0 -1 57.5057 -0.442294 -0.89687 0 128 -90 0.19621 0.125" texRot="-90" texScale="0.19621 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.382683 0.92388 -5.54117e-007 -0.369439" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.92388 -0.382683 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.5 -0.866025 -1.75505e-006 -0.289981" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.92388 -0.382683 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.89687 0.442294 -1.71064e-006 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 73.7393 -0.442291 -0.896871 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="817" owner="0" type="0" pos="-12.8152 64.1737 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -12.8152 0 1 0 64.1737 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.01137 -0.173715 0.5" />
                            <Vertex pos="0.575341 -0.826285 0.5" />
                            <Vertex pos="-0.72068 0.826285 0.5" />
                            <Vertex pos="-1.01137 0.391243 0.5" />
                            <Vertex pos="1.01137 -0.173715 0" />
                            <Vertex pos="0.57534 -0.826285 0" />
                            <Vertex pos="-0.72068 0.826285 0" />
                            <Vertex pos="-1.01137 0.391242 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 47.3037 0 -1 0 2259.53 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1047.65 0 -1 0 1129.76 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.831472 -0.555566 -1.68503e-006 -0.937435" album="Blasted" material="bm_edge_white" texgens="0 0 -1 59.9186 -0.555567 -0.831472 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.5 0.866025 -0 -0.355244" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866025 -0.5 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.608762 -0.793353 1.60778e-006 -0.305291" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866025 -0.5 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.831467 0.555575 0 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 70.1209 -0.555578 -0.831465 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="818" owner="0" type="0" pos="-13.2057 63.6612 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -13.2057 0 1 0 63.6612 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.965845 -0.313729 0.5" />
                            <Vertex pos="0.448365 -0.903799 0.5" />
                            <Vertex pos="-0.620868 0.903799 0.5" />
                            <Vertex pos="-0.965845 0.510411 0.5" />
                            <Vertex pos="0.965845 -0.313729 0" />
                            <Vertex pos="0.448364 -0.903799 0" />
                            <Vertex pos="-0.620867 0.903799 0" />
                            <Vertex pos="-0.965845 0.510411 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -52.666 0 -1 0 2390.74 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -997.667 0 -1 0 1195.37 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.751838 -0.659348 -1.52364e-006 -0.933015" album="Blasted" material="bm_edge_white" texgens="0 0 -1 62.608 -0.659348 -0.751838 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.608762 0.793353 -0 -0.339072" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.793353 -0.608762 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.707107 -0.707107 -0 -0.32204" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.793353 -0.608762 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.751853 0.659331 -1.52367e-006 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 66.0928 -0.659331 -0.751853 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="819" owner="0" type="0" pos="-13.6612 63.2057 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -13.6612 0 1 0 63.2057 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.903797 -0.448365 0.5" />
                            <Vertex pos="0.313727 -0.965846 0.5" />
                            <Vertex pos="-0.510414 0.965846 0.5" />
                            <Vertex pos="-0.903797 0.620863 0.5" />
                            <Vertex pos="0.903797 -0.448365 0" />
                            <Vertex pos="0.313726 -0.965845 0" />
                            <Vertex pos="-0.510414 0.965846 0" />
                            <Vertex pos="-0.903797 0.620863 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -169.256 0 -1 0 2507.33 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -939.372 0 -1 0 1253.67 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.659348 -0.751838 -2.82055e-006 -0.933013" album="Blasted" material="bm_edge_white" texgens="0 0 -1 65.3933 -0.751838 -0.659348 0 128 -90 0.196207 0.125" texRot="-90" texScale="0.196207 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 0.707107 -0 -0.322039" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707107 -0.707107 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.793354 -0.608761 -0 -0.339073" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707107 -0.707107 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.659341 0.751844 0 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 61.9101 -0.751845 -0.659341 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="820" owner="0" type="0" pos="-14.1737 62.8152 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -14.1737 0 1 0 62.8152 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.826289 -0.575334 0.5" />
                            <Vertex pos="0.173708 -1.01137 0.5" />
                            <Vertex pos="-0.391236 1.01137 0.5" />
                            <Vertex pos="-0.826289 0.72068 0.5" />
                            <Vertex pos="0.826288 -0.575335 0" />
                            <Vertex pos="0.173708 -1.01137 0" />
                            <Vertex pos="-0.391235 1.01137 0" />
                            <Vertex pos="-0.826288 0.720679 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -300.472 0 -1 0 2607.31 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -873.764 0 -1 0 1303.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.555566 -0.831472 0 -0.937433" album="Blasted" material="bm_edge_white" texgens="0 0 -1 68.0828 -0.831469 -0.55557 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.793353 0.608762 -2.84147e-006 -0.305296" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.608762 -0.793353 0 161.298 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866026 -0.499999 -7.41775e-007 -0.355248" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.608762 -0.793353 0 161.298 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.555567 0.831472 -1.12589e-006 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 57.8781 -0.831468 -0.555573 0 128 90 0.130809 0.125" texRot="90" texScale="0.130809 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="821" owner="0" type="0" pos="-14.7346 62.4963 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -14.7346 0 1 0 62.4963 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.734632 -0.692466 0.5" />
                            <Vertex pos="0.0307319 -1.03959 0.5" />
                            <Vertex pos="-0.265364 1.03959 0.5" />
                            <Vertex pos="-0.734632 0.808177 0.5" />
                            <Vertex pos="0.734632 -0.692466 0" />
                            <Vertex pos="0.0307312 -1.03959 0" />
                            <Vertex pos="-0.265364 1.03959 0" />
                            <Vertex pos="-0.734632 0.808177 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -444.068 0 -1 0 2688.95 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -801.966 0 -1 0 1344.47 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.442288 -0.896873 -6.19516e-007 -0.945973" album="Blasted" material="bm_edge_white" texgens="0 0 -1 70.4932 -0.896875 -0.442284 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.866027 0.499997 -0 -0.28998" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.499998 -0.866026 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.923881 -0.382681 -0 -0.369438" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.499998 -0.866026 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.442282 0.896876 0 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 54.2568 -0.896879 -0.442276 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="822" owner="0" type="0" pos="-15.3343 62.2545 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.3343 0 1 0 62.2545 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.630412 -0.797742 0.5" />
                            <Vertex pos="-0.112779 -1.05002 0.5" />
                            <Vertex pos="-0.134953 1.05002 0.5" />
                            <Vertex pos="-0.630412 0.881831 0.5" />
                            <Vertex pos="0.630411 -0.797742 0" />
                            <Vertex pos="-0.11278 -1.05002 0" />
                            <Vertex pos="-0.134953 1.05002 0" />
                            <Vertex pos="-0.630411 0.881831 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -597.586 0 -1 0 2750.86 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -725.207 0 -1 0 1375.43 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.321438 -0.946931 -6.41833e-007 -0.958044" album="Blasted" material="bm_edge_white" texgens="0 0 -1 72.4644 -0.94693 -0.32144 0 128 -90 0.196207 0.125" texRot="-90" texScale="0.196207 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.92388 0.382682 -1.76216e-006 -0.277143" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.382682 -0.92388 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.965926 -0.258817 -1.84236e-006 -0.380698" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.382682 -0.92388 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.321446 0.946928 0 -1.03767" album="Blasted" material="bm_edge_white" texgens="0 0 1 51.3085 -0.946928 -0.321446 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="823" owner="0" type="0" pos="-15.9625 62.0938 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.9625 0 1 0 62.0938 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.515404 -0.889371 0.5" />
                            <Vertex pos="-0.254359 -1.04248 0.5" />
                            <Vertex pos="-0.0022285 1.04248 0.5" />
                            <Vertex pos="-0.515404 0.940409 0.5" />
                            <Vertex pos="0.515404 -0.889371 0" />
                            <Vertex pos="-0.254358 -1.04248 0" />
                            <Vertex pos="-0.00222778 1.04248 0" />
                            <Vertex pos="-0.515404 0.94041 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -758.4 0 -1 0 2791.98 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -644.799 0 -1 0 1395.99 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.195083 -0.980787 3.95346e-007 -0.97283" album="Blasted" material="bm_edge_white" texgens="0 0 -1 73.8558 -0.980787 -0.195084 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.965927 0.258816 -0 -0.267659" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258817 -0.965927 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.991445 -0.130523 -2.64512e-007 -0.38825" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258817 -0.965927 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.195077 0.980788 -2.80968e-007 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 49.2161 -0.980787 -0.19508 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="824" owner="0" type="0" pos="-16.6084 62.0171 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -16.6084 0 1 0 62.0171 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.391579 -0.96578 0.5" />
                            <Vertex pos="-0.391579 -1.01711 0.5" />
                            <Vertex pos="0.130534 1.01711 0.5" />
                            <Vertex pos="-0.391572 0.98289 0.5" />
                            <Vertex pos="0.391579 -0.96578 0" />
                            <Vertex pos="-0.391579 -1.01711 0" />
                            <Vertex pos="0.130533 1.01711 0" />
                            <Vertex pos="-0.391573 0.98289 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -923.762 0 -1 0 2811.62 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -562.119 0 -1 0 1405.81 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.065402 -0.997859 0 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 74.5735 -0.997859 -0.065402 0 128 -90 0.196214 0.125" texRot="-90" texScale="0.196214 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.991445 0.130523 -0 -0.262173" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.130523 -0.991445 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-1 3.50177e-006 2.02656e-006 -0.391576" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.130523 -0.991445 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.0654019 0.997859 1.30592e-007 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 48.1382 -0.997859 -0.065402 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="825" owner="0" type="0" pos="-11.9829 67.3916 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -11.9829 0 1 0 67.3916 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.01711 -0.391579 0.5" />
                            <Vertex pos="-0.96578 0.391579 0.5" />
                            <Vertex pos="0.98289 -0.391574 0.5" />
                            <Vertex pos="1.01711 0.130531 0.5" />
                            <Vertex pos="-1.01711 -0.39158 0" />
                            <Vertex pos="-0.96578 0.39158 0" />
                            <Vertex pos="0.98289 -0.391574 0" />
                            <Vertex pos="1.01711 0.130531 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2299.62 0 -1 0 1435.76 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 125.81 0 -1 0 717.88 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.997859 0.065402 1.28643e-007 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 53.4244 0.065402 0.997859 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="2.99513e-006 -1 1.96695e-006 -0.391577" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -1 0 0 159.452 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.130524 0.991445 0 -0.262172" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -1 0 0 159.452 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.997859 -0.065402 0 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 79.8622 0.0654019 0.997859 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="826" owner="0" type="0" pos="-11.9062 68.0375 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -11.9062 0 1 0 68.0375 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.04248 -0.254355 0.5" />
                            <Vertex pos="-0.88937 0.515402 0.5" />
                            <Vertex pos="0.94041 -0.515402 0.5" />
                            <Vertex pos="1.04248 -0.00223005 0.5" />
                            <Vertex pos="-1.04248 -0.254354 0" />
                            <Vertex pos="-0.88937 0.515403 0" />
                            <Vertex pos="0.940411 -0.515403 0" />
                            <Vertex pos="1.04248 -0.00222969 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2279.98 0 -1 0 1270.4 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 115.992 0 -1 0 635.2 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.980786 0.195085 3.72095e-007 -0.972829" album="Blasted" material="bm_edge_white" texgens="0 0 -1 54.1463 0.195085 0.980786 0 128 -90 0.196208 0.125" texRot="-90" texScale="0.196208 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.130524 -0.991445 -2.00922e-006 -0.388247" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.991445 0.130524 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.258816 0.965927 6.95382e-007 -0.267657" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.991445 0.130524 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.980788 -0.195077 2.24278e-006 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 78.7845 0.195078 0.980788 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="827" owner="0" type="0" pos="-11.7455 68.6657 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -11.7455 0 1 0 68.6657 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.05002 -0.112779 0.5" />
                            <Vertex pos="-0.79774 0.630411 0.5" />
                            <Vertex pos="0.88183 -0.630411 0.5" />
                            <Vertex pos="1.05002 -0.134952 0.5" />
                            <Vertex pos="-1.05002 -0.112779 0" />
                            <Vertex pos="-0.79774 0.630411 0" />
                            <Vertex pos="0.88183 -0.630411 0" />
                            <Vertex pos="1.05002 -0.134952 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2238.86 0 -1 0 1109.59 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 95.429 0 -1 0 554.793 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.94693 0.321441 0 -0.958043" album="Blasted" material="bm_edge_white" texgens="0 0 -1 55.5371 0.32144 0.94693 0 128 -90 0.19621 0.125" texRot="-90" texScale="0.19621 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.258816 -0.965927 0 -0.380699" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965927 0.258817 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.382682 0.92388 0 -0.277144" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965927 0.258817 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.946928 -0.321447 0 -1.03767" album="Blasted" material="bm_edge_white" texgens="0 0 1 76.6914 0.321446 0.946928 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="828" owner="0" type="0" pos="-11.5037 69.2654 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -11.5037 0 1 0 69.2654 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.03959 0.0307312 0.5" />
                            <Vertex pos="-0.69247 0.734631 0.5" />
                            <Vertex pos="0.808168 -0.734631 0.5" />
                            <Vertex pos="1.03959 -0.265369 0.5" />
                            <Vertex pos="-1.03959 0.0307312 0" />
                            <Vertex pos="-0.69247 0.734632 0" />
                            <Vertex pos="0.808168 -0.734632 0" />
                            <Vertex pos="1.03959 -0.265368 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2176.94 0 -1 0 956.068 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 64.4724 0 -1 0 478.034 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.896875 0.442284 8.96313e-007 -0.945975" album="Blasted" material="bm_edge_white" texgens="0 0 -1 57.5068 0.442284 0.896875 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.382682 -0.92388 0 -0.36944" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.92388 0.382682 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.499998 0.866027 1.70343e-006 -0.289977" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.92388 0.382682 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.896868 -0.442299 8.96344e-007 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 73.7373 0.442299 0.896868 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="829" owner="0" type="0" pos="-11.1848 69.8263 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -11.1848 0 1 0 69.8263 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.01137 0.173716 0.5" />
                            <Vertex pos="-0.575332 0.826286 0.5" />
                            <Vertex pos="0.72069 -0.826286 0.5" />
                            <Vertex pos="1.01137 -0.391232 0.5" />
                            <Vertex pos="-1.01137 0.173716 0" />
                            <Vertex pos="-0.575332 0.826286 0" />
                            <Vertex pos="0.72069 -0.826286 0" />
                            <Vertex pos="1.01137 -0.391232 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2095.31 0 -1 0 812.474 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 23.6531 0 -1 0 406.237 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.831467 0.555574 0 -0.937433" album="Blasted" material="bm_edge_white" texgens="0 0 -1 59.9174 0.555576 0.831466 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.499999 -0.866026 0 -0.355241" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866026 0.499998 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.608761 0.793354 0 -0.305297" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866026 0.499998 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.831482 -0.555552 0 -1.05829" album="Blasted" material="bm_edge_white" texgens="0 0 1 70.1264 0.555555 0.83148 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="830" owner="0" type="0" pos="-10.7943 70.3388 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -10.7943 0 1 0 70.3388 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.965847 0.313718 0.5" />
                            <Vertex pos="-0.448367 0.903798 0.5" />
                            <Vertex pos="0.620855 -0.903798 0.5" />
                            <Vertex pos="0.965847 -0.510416 0.5" />
                            <Vertex pos="-0.965847 0.313718 0" />
                            <Vertex pos="-0.448367 0.903798 0" />
                            <Vertex pos="0.620855 -0.903799 0" />
                            <Vertex pos="0.965847 -0.510417 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1995.33 0 -1 0 681.256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -26.3333 0 -1 0 340.628 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.751844 0.659341 0 -0.933013" album="Blasted" material="bm_edge_white" texgens="0 0 -1 62.6079 0.659341 0.751844 0 128 -90 0.196212 0.125" texRot="-90" texScale="0.196212 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.608761 -0.793354 0 -0.33908" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.793354 0.608761 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.707107 0.707107 -1.43299e-006 -0.322038" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.793354 0.608761 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.751835 -0.659352 1.33621e-006 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 66.087 0.659351 0.751835 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="831" owner="0" type="0" pos="-10.3388 70.7943 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -10.3388 0 1 0 70.7943 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.903797 0.448368 0.5" />
                            <Vertex pos="-0.313727 0.965848 0.5" />
                            <Vertex pos="0.510419 -0.965848 0.5" />
                            <Vertex pos="0.903797 -0.620859 0.5" />
                            <Vertex pos="-0.903797 0.448368 0" />
                            <Vertex pos="-0.313726 0.965848 0" />
                            <Vertex pos="0.510419 -0.965848 0" />
                            <Vertex pos="0.903797 -0.620859 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1878.74 0 -1 0 564.666 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -84.6282 0 -1 0 282.333 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.659348 0.751838 -1.29691e-006 -0.933016" album="Blasted" material="bm_edge_white" texgens="0 0 -1 65.3938 0.751838 0.659348 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 0 -0.322037" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707107 0.707107 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.793353 0.608762 0 -0.339075" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707107 0.707107 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.659352 -0.751834 0 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 61.9132 0.751835 0.659351 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="832" owner="0" type="0" pos="-9.82629 71.1848 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.82629 0 1 0 71.1848 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.826285 0.575338 0.5" />
                            <Vertex pos="-0.173715 1.01137 0.5" />
                            <Vertex pos="0.391239 -1.01137 0.5" />
                            <Vertex pos="0.826285 -0.720682 0.5" />
                            <Vertex pos="-0.826285 0.575338 0" />
                            <Vertex pos="-0.173715 1.01137 0" />
                            <Vertex pos="0.391239 -1.01137 0" />
                            <Vertex pos="0.826285 -0.720682 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1747.53 0 -1 0 464.696 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -150.236 0 -1 0 232.348 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.555569 0.83147 0 -0.937435" album="Blasted" material="bm_edge_white" texgens="0 0 -1 68.0809 0.831472 0.555567 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.793353 -0.608761 0 -0.305292" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.608762 0.793353 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.866026 0.5 0 -0.355243" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.608762 0.793353 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.55557 -0.83147 0 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 57.8764 0.831471 0.555569 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="833" owner="0" type="0" pos="-9.26537 71.5037 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.26537 0 1 0 71.5037 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.734634 0.69246 0.5" />
                            <Vertex pos="-0.0307338 1.03959 0.5" />
                            <Vertex pos="0.265366 -1.03959 0.5" />
                            <Vertex pos="0.734633 -0.808171 0.5" />
                            <Vertex pos="-0.734633 0.69246 0" />
                            <Vertex pos="-0.0307341 1.03959 0" />
                            <Vertex pos="0.265366 -1.03959 0" />
                            <Vertex pos="0.734634 -0.808171 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1603.93 0 -1 0 383.055 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -222.033 0 -1 0 191.528 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.442294 0.89687 2.65275e-007 -0.945971" album="Blasted" material="bm_edge_white" texgens="0 0 -1 70.4933 0.89687 0.442294 0 128 -90 0.196213 0.125" texRot="-90" texScale="0.196213 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.866026 -0.5 -1.65181e-006 -0.289981" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.5 0.866025 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.92388 0.382683 1.76216e-006 -0.36944" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.5 0.866025 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.442291 -0.896872 0 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 54.2607 0.896871 0.442291 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="834" owner="0" type="0" pos="-8.66569 71.7455 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -8.66569 0 1 0 71.7455 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.630414 0.797741 0.5" />
                            <Vertex pos="0.112776 1.05002 0.5" />
                            <Vertex pos="0.134953 -1.05002 0.5" />
                            <Vertex pos="0.630414 -0.88184 0.5" />
                            <Vertex pos="-0.630415 0.797741 2.98023e-008" />
                            <Vertex pos="0.112776 1.05002 2.98023e-008" />
                            <Vertex pos="0.134953 -1.05002 2.98023e-008" />
                            <Vertex pos="0.630415 -0.881841 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1450.42 0 -1 0 321.142 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -298.792 0 -1 0 160.571 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.321439 0.94693 0 -0.958045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 72.4634 0.94693 0.32144 0 128 -90 0.196208 0.125" texRot="-90" texScale="0.196208 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.92388 -0.382684 1.8723e-006 -0.277145" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.382683 0.92388 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.965926 0.258818 1.433e-006 -0.380698" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.382683 0.92388 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.321426 -0.946935 0 -1.03768" album="Blasted" material="bm_edge_white" texgens="0 0 1 51.3039 0.946934 0.321429 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="835" owner="0" type="0" pos="-8.03751 71.9062 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -8.03751 0 1 0 71.9062 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.515404 0.889376 0.5" />
                            <Vertex pos="0.254353 1.04249 0.5" />
                            <Vertex pos="0.0022347 -1.04249 0.5" />
                            <Vertex pos="0.515404 -0.940405 0.5" />
                            <Vertex pos="-0.515404 0.889376 0" />
                            <Vertex pos="0.254353 1.04249 0" />
                            <Vertex pos="0.00223541 -1.04249 0" />
                            <Vertex pos="0.515404 -0.940405 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1289.6 0 -1 0 280.017 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -379.199 0 -1 0 140.008 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.19509 0.980785 0 -0.972837" album="Blasted" material="bm_edge_white" texgens="0 0 -1 73.8554 0.980786 0.195085 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.965926 -0.258818 0 -0.267656" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258818 0.965926 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.991445 0.130525 0 -0.388248" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258818 0.965926 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.195108 -0.980782 2.77105e-007 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 49.22 0.980784 0.195099 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="836" owner="0" type="0" pos="-7.39157 71.9829 28.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.39157 0 1 0 71.9829 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.391579 0.96578 0.5" />
                            <Vertex pos="0.391579 1.01711 0.5" />
                            <Vertex pos="-0.130529 -1.01711 0.5" />
                            <Vertex pos="0.391577 -0.98289 0.5" />
                            <Vertex pos="-0.391579 0.96578 0" />
                            <Vertex pos="0.391579 1.01711 0" />
                            <Vertex pos="-0.130529 -1.01711 0" />
                            <Vertex pos="0.391577 -0.98289 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1124.24 0 -1 0 260.38 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -461.879 0 -1 0 130.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.065402 0.997859 0 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 74.5735 0.997859 0.065402 0 128 -90 0.196214 0.125" texRot="-90" texScale="0.196214 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.991445 -0.130525 0 -0.262171" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.130525 0.991445 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="1 -9.98378e-007 0 -0.391578" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.130525 0.991445 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.0654019 -0.997859 0 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 48.1371 0.997859 0.0654019 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="837" owner="0" type="0" pos="1.98289 66.6084 30.5" rot="1 0 0 0" scale="" transform="1 0 0 1.98289 0 1 0 66.6084 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.01711 0.39158 0.5" />
                            <Vertex pos="0.96578 -0.39158 0.5" />
                            <Vertex pos="-0.98289 0.39158 0.5" />
                            <Vertex pos="-1.01711 -0.130527 0.5" />
                            <Vertex pos="1.01711 0.39158 0" />
                            <Vertex pos="0.96578 -0.39158 0" />
                            <Vertex pos="-0.982891 0.39158 0" />
                            <Vertex pos="-1.01711 -0.130527 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 251.62 0 -1 0 1636.24 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1149.81 0 -1 0 818.122 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.997859 -0.0654018 0 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 53.4244 -0.065402 -0.997859 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.39158" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 1 0 0 159.452 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.130526 -0.991445 -0 -0.26217" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 1 0 0 159.452 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.997859 0.0653998 2.02222e-006 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 79.8634 -0.0654019 -0.997859 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="838" owner="0" type="0" pos="1.90619 65.9625 30.5" rot="1 0 0 0" scale="" transform="1 0 0 1.90619 0 1 0 65.9625 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.04249 0.254349 0.5" />
                            <Vertex pos="0.889376 -0.515402 0.5" />
                            <Vertex pos="-0.940404 0.515402 0.5" />
                            <Vertex pos="-1.04248 0.0022366 0.5" />
                            <Vertex pos="1.04248 0.254349 2.98023e-008" />
                            <Vertex pos="0.889376 -0.515402 2.98023e-008" />
                            <Vertex pos="-0.940405 0.515402 2.98023e-008" />
                            <Vertex pos="-1.04248 0.00223637 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 231.983 0 -1 0 1801.6 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -1139.99 0 -1 0 900.801 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.980785 -0.195092 0 -0.972837" album="Blasted" material="bm_edge_white" texgens="0 0 -1 54.1459 -0.195087 -0.980786 0 128 -90 0.196207 0.125" texRot="-90" texScale="0.196207 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.130527 0.991445 -2.61408e-006 -0.388245" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.991445 -0.130526 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.258819 -0.965926 4.44397e-007 -0.267653" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.991445 -0.130526 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.980785 0.19509 1.98762e-006 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 78.7798 -0.1951 -0.980783 0 128 90 0.130805 0.125" texRot="90" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="839" owner="0" type="0" pos="1.74554 65.3343 30.5" rot="1 0 0 0" scale="" transform="1 0 0 1.74554 0 1 0 65.3343 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.05002 0.112776 0.5" />
                            <Vertex pos="0.797741 -0.630414 0.5" />
                            <Vertex pos="-0.88184 0.630415 0.5" />
                            <Vertex pos="-1.05002 0.134953 0.5" />
                            <Vertex pos="1.05002 0.112776 2.98023e-008" />
                            <Vertex pos="0.797741 -0.630414 2.98023e-008" />
                            <Vertex pos="-0.88184 0.630415 2.98023e-008" />
                            <Vertex pos="-1.05002 0.134953 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 190.858 0 -1 0 1962.42 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -1119.43 0 -1 0 981.208 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.94693 -0.321439 0 -0.958045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 55.5378 -0.32144 -0.94693 0 128 -90 0.19621 0.125" texRot="-90" texScale="0.19621 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.258818 0.965926 -0 -0.380698" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965926 -0.258818 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.382683 -0.92388 -0 -0.277145" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965926 -0.258818 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.946934 0.321428 0 -1.03768" album="Blasted" material="bm_edge_white" texgens="0 0 1 76.6962 -0.321429 -0.946934 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="840" owner="0" type="0" pos="1.50369 64.7346 30.5" rot="1 0 0 0" scale="" transform="1 0 0 1.50369 0 1 0 64.7346 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.03959 -0.0307338 0.5" />
                            <Vertex pos="0.69246 -0.734634 0.5" />
                            <Vertex pos="-0.808171 0.734633 0.5" />
                            <Vertex pos="-1.03959 0.265366 0.5" />
                            <Vertex pos="1.03959 -0.0307341 0" />
                            <Vertex pos="0.692459 -0.734633 0" />
                            <Vertex pos="-0.80817 0.734633 0" />
                            <Vertex pos="-1.03959 0.265367 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 128.944 0 -1 0 2115.93 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1088.47 0 -1 0 1057.97 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.89687 -0.442294 -2.66117e-006 -0.945969" album="Blasted" material="bm_edge_white" texgens="0 0 -1 57.5057 -0.442294 -0.89687 0 128 -90 0.19621 0.125" texRot="-90" texScale="0.19621 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.382683 0.92388 -5.54117e-007 -0.369439" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.92388 -0.382683 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.5 -0.866025 -1.75505e-006 -0.289981" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.92388 -0.382683 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.89687 0.442294 -1.71064e-006 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 73.7393 -0.442291 -0.896871 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="841" owner="0" type="0" pos="1.18478 64.1737 30.5" rot="1 0 0 0" scale="" transform="1 0 0 1.18478 0 1 0 64.1737 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.01137 -0.173715 0.5" />
                            <Vertex pos="0.575341 -0.826285 0.5" />
                            <Vertex pos="-0.72068 0.826285 0.5" />
                            <Vertex pos="-1.01137 0.391243 0.5" />
                            <Vertex pos="1.01137 -0.173715 0" />
                            <Vertex pos="0.57534 -0.826285 0" />
                            <Vertex pos="-0.72068 0.826285 0" />
                            <Vertex pos="-1.01137 0.391242 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 47.3037 0 -1 0 2259.53 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1047.65 0 -1 0 1129.76 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.831472 -0.555566 -1.68503e-006 -0.937435" album="Blasted" material="bm_edge_white" texgens="0 0 -1 59.9186 -0.555567 -0.831472 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.5 0.866025 -0 -0.355244" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866025 -0.5 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.608762 -0.793353 1.60778e-006 -0.305291" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866025 -0.5 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.831467 0.555575 0 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 70.1209 -0.555578 -0.831465 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="842" owner="0" type="0" pos="0.794275 63.6612 30.5" rot="1 0 0 0" scale="" transform="1 0 0 0.794275 0 1 0 63.6612 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.965845 -0.313729 0.5" />
                            <Vertex pos="0.448365 -0.903799 0.5" />
                            <Vertex pos="-0.620868 0.903799 0.5" />
                            <Vertex pos="-0.965845 0.510411 0.5" />
                            <Vertex pos="0.965845 -0.313729 0" />
                            <Vertex pos="0.448364 -0.903799 0" />
                            <Vertex pos="-0.620867 0.903799 0" />
                            <Vertex pos="-0.965845 0.510411 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -52.666 0 -1 0 2390.74 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -997.667 0 -1 0 1195.37 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.751838 -0.659348 -1.52364e-006 -0.933015" album="Blasted" material="bm_edge_white" texgens="0 0 -1 62.608 -0.659348 -0.751838 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.608762 0.793353 -0 -0.339072" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.793353 -0.608762 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.707107 -0.707107 -0 -0.32204" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.793353 -0.608762 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.751853 0.659331 -1.52367e-006 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 66.0928 -0.659331 -0.751853 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="843" owner="0" type="0" pos="0.338844 63.2057 30.5" rot="1 0 0 0" scale="" transform="1 0 0 0.338844 0 1 0 63.2057 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.903797 -0.448365 0.5" />
                            <Vertex pos="0.313727 -0.965846 0.5" />
                            <Vertex pos="-0.510414 0.965846 0.5" />
                            <Vertex pos="-0.903797 0.620863 0.5" />
                            <Vertex pos="0.903797 -0.448365 0" />
                            <Vertex pos="0.313726 -0.965845 0" />
                            <Vertex pos="-0.510414 0.965846 0" />
                            <Vertex pos="-0.903797 0.620863 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -169.256 0 -1 0 2507.33 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -939.372 0 -1 0 1253.67 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.659348 -0.751838 -2.82055e-006 -0.933013" album="Blasted" material="bm_edge_white" texgens="0 0 -1 65.3933 -0.751838 -0.659348 0 128 -90 0.196207 0.125" texRot="-90" texScale="0.196207 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 0.707107 -0 -0.322039" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707107 -0.707107 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.793354 -0.608761 -0 -0.339073" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707107 -0.707107 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.659341 0.751844 0 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 61.9101 -0.751845 -0.659341 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="844" owner="0" type="0" pos="-0.173717 62.8152 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -0.173717 0 1 0 62.8152 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.826289 -0.575334 0.5" />
                            <Vertex pos="0.173708 -1.01137 0.5" />
                            <Vertex pos="-0.391236 1.01137 0.5" />
                            <Vertex pos="-0.826289 0.72068 0.5" />
                            <Vertex pos="0.826288 -0.575335 0" />
                            <Vertex pos="0.173708 -1.01137 0" />
                            <Vertex pos="-0.391235 1.01137 0" />
                            <Vertex pos="-0.826288 0.720679 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -300.472 0 -1 0 2607.31 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -873.764 0 -1 0 1303.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.555566 -0.831472 0 -0.937433" album="Blasted" material="bm_edge_white" texgens="0 0 -1 68.0828 -0.831469 -0.55557 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.793353 0.608762 -2.84147e-006 -0.305296" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.608762 -0.793353 0 161.298 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866026 -0.499999 -7.41775e-007 -0.355248" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.608762 -0.793353 0 161.298 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.555567 0.831472 -1.12589e-006 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 57.8781 -0.831468 -0.555573 0 128 90 0.130809 0.125" texRot="90" texScale="0.130809 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="845" owner="0" type="0" pos="-0.734642 62.4963 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -0.734642 0 1 0 62.4963 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.734632 -0.692466 0.5" />
                            <Vertex pos="0.0307319 -1.03959 0.5" />
                            <Vertex pos="-0.265364 1.03959 0.5" />
                            <Vertex pos="-0.734632 0.808177 0.5" />
                            <Vertex pos="0.734632 -0.692466 0" />
                            <Vertex pos="0.0307312 -1.03959 0" />
                            <Vertex pos="-0.265364 1.03959 0" />
                            <Vertex pos="-0.734632 0.808177 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -444.068 0 -1 0 2688.95 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -801.966 0 -1 0 1344.47 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.442288 -0.896873 -6.19516e-007 -0.945973" album="Blasted" material="bm_edge_white" texgens="0 0 -1 70.4932 -0.896875 -0.442284 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.866027 0.499997 -0 -0.28998" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.499998 -0.866026 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.923881 -0.382681 -0 -0.369438" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.499998 -0.866026 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.442282 0.896876 0 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 54.2568 -0.896879 -0.442276 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="846" owner="0" type="0" pos="-1.33432 62.2545 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -1.33432 0 1 0 62.2545 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.630412 -0.797742 0.5" />
                            <Vertex pos="-0.112779 -1.05002 0.5" />
                            <Vertex pos="-0.134953 1.05002 0.5" />
                            <Vertex pos="-0.630412 0.881831 0.5" />
                            <Vertex pos="0.630411 -0.797742 0" />
                            <Vertex pos="-0.11278 -1.05002 0" />
                            <Vertex pos="-0.134953 1.05002 0" />
                            <Vertex pos="-0.630411 0.881831 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -597.586 0 -1 0 2750.86 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -725.207 0 -1 0 1375.43 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.321438 -0.946931 -6.41833e-007 -0.958044" album="Blasted" material="bm_edge_white" texgens="0 0 -1 72.4644 -0.94693 -0.32144 0 128 -90 0.196207 0.125" texRot="-90" texScale="0.196207 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.92388 0.382682 -1.76216e-006 -0.277143" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.382682 -0.92388 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.965926 -0.258817 -1.84236e-006 -0.380698" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.382682 -0.92388 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.321446 0.946928 0 -1.03767" album="Blasted" material="bm_edge_white" texgens="0 0 1 51.3085 -0.946928 -0.321446 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="847" owner="0" type="0" pos="-1.9625 62.0938 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -1.9625 0 1 0 62.0938 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.515404 -0.889371 0.5" />
                            <Vertex pos="-0.254359 -1.04248 0.5" />
                            <Vertex pos="-0.0022285 1.04248 0.5" />
                            <Vertex pos="-0.515404 0.940409 0.5" />
                            <Vertex pos="0.515404 -0.889371 0" />
                            <Vertex pos="-0.254358 -1.04248 0" />
                            <Vertex pos="-0.00222778 1.04248 0" />
                            <Vertex pos="-0.515404 0.94041 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -758.4 0 -1 0 2791.98 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -644.799 0 -1 0 1395.99 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.195083 -0.980787 3.95346e-007 -0.97283" album="Blasted" material="bm_edge_white" texgens="0 0 -1 73.8558 -0.980787 -0.195084 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.965927 0.258816 -0 -0.267659" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258817 -0.965927 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.991445 -0.130523 -2.64512e-007 -0.38825" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258817 -0.965927 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.195077 0.980788 -2.80968e-007 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 49.2161 -0.980787 -0.19508 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="848" owner="0" type="0" pos="-2.60844 62.0171 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.60844 0 1 0 62.0171 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.391579 -0.96578 0.5" />
                            <Vertex pos="-0.391579 -1.01711 0.5" />
                            <Vertex pos="0.130534 1.01711 0.5" />
                            <Vertex pos="-0.391572 0.98289 0.5" />
                            <Vertex pos="0.391579 -0.96578 0" />
                            <Vertex pos="-0.391579 -1.01711 0" />
                            <Vertex pos="0.130533 1.01711 0" />
                            <Vertex pos="-0.391573 0.98289 0" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -923.762 0 -1 0 2811.62 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -562.119 0 -1 0 1405.81 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.065402 -0.997859 0 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 74.5735 -0.997859 -0.065402 0 128 -90 0.196214 0.125" texRot="-90" texScale="0.196214 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.991445 0.130523 -0 -0.262173" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.130523 -0.991445 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-1 3.50177e-006 2.02656e-006 -0.391576" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.130523 -0.991445 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.0654019 0.997859 1.30592e-007 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 48.1382 -0.997859 -0.065402 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="849" owner="0" type="0" pos="-2.60842 71.9829 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.60842 0 1 0 71.9829 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.391578 1.01711 0.5" />
                            <Vertex pos="0.39158 0.965779 0.5" />
                            <Vertex pos="-0.39158 -0.982889 0.5" />
                            <Vertex pos="0.130526 -1.01711 0.5" />
                            <Vertex pos="-0.391579 1.01711 0" />
                            <Vertex pos="0.391581 0.965779 0" />
                            <Vertex pos="-0.391581 -0.982889 0" />
                            <Vertex pos="0.130526 -1.01711 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -923.754 0 -1 0 260.38 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -562.123 0 -1 0 130.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.0654033 0.997859 1.32543e-007 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 53.4262 0.997859 -0.0654021 0 128 -90 0.196205 0.125" texRot="-90" texScale="0.196205 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-1 9.98378e-007 2.02656e-006 -0.39158" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 1 0 159.453 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.991445 -0.130527 0 -0.26217" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 1 0 159.453 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.0654037 -0.997859 1.32544e-007 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 79.8637 0.997859 -0.065402 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="850" owner="0" type="0" pos="-1.96248 71.9062 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -1.96248 0 1 0 71.9062 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.254356 1.04249 0.5" />
                            <Vertex pos="0.51541 0.889366 0.5" />
                            <Vertex pos="-0.51541 -0.940404 0.5" />
                            <Vertex pos="-0.00223339 -1.04249 0.5" />
                            <Vertex pos="-0.254356 1.04249 2.98023e-008" />
                            <Vertex pos="0.515409 0.889366 2.98023e-008" />
                            <Vertex pos="-0.515409 -0.940404 2.98023e-008" />
                            <Vertex pos="-0.00223351 -1.04249 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -758.395 0 -1 0 280.017 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -644.802 0 -1 0 140.008 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.1951 0.980783 -3.95382e-007 -0.972832" album="Blasted" material="bm_edge_white" texgens="0 0 -1 54.1435 0.980784 -0.195095 0 128 -90 0.196217 0.125" texRot="-90" texScale="0.196217 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.991445 0.130526 0 -0.388252" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.130527 0.991445 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.965925 -0.258821 -2.31644e-007 -0.267661" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.130527 0.991445 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.195107 -0.980782 -3.95396e-007 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 78.7805 0.980784 -0.195098 0 128 90 0.130808 0.125" texRot="90" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="851" owner="0" type="0" pos="-1.3343 71.7455 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -1.3343 0 1 0 71.7455 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.112768 1.05002 0.5" />
                            <Vertex pos="0.630412 0.79774 0.5" />
                            <Vertex pos="-0.630412 -0.881833 0.5" />
                            <Vertex pos="-0.134959 -1.05002 0.5" />
                            <Vertex pos="-0.112768 1.05002 2.98023e-008" />
                            <Vertex pos="0.630411 0.79774 2.98023e-008" />
                            <Vertex pos="-0.630411 -0.881833 2.98023e-008" />
                            <Vertex pos="-0.13496 -1.05002 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -597.581 0 -1 0 321.144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -725.21 0 -1 0 160.572 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.321444 0.946928 -6.13107e-007 -0.958045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 55.5362 0.946929 -0.321444 0 128 -90 0.196212 0.125" texRot="-90" texScale="0.196212 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.965925 0.258821 0 -0.380693" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258822 0.965925 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.923879 -0.382685 -1.84476e-006 -0.27714" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258822 0.965925 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.321446 -0.946928 -6.1311e-007 -1.03768" album="Blasted" material="bm_edge_white" texgens="0 0 1 76.6924 0.946928 -0.321446 0 128 90 0.130805 0.125" texRot="90" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="852" owner="0" type="0" pos="-0.734625 71.5037 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -0.734625 0 1 0 71.5037 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0307353 1.03958 0.5" />
                            <Vertex pos="0.734636 0.692464 0.5" />
                            <Vertex pos="-0.734636 -0.808175 0.5" />
                            <Vertex pos="-0.265367 -1.03958 0.5" />
                            <Vertex pos="0.030735 1.03958 0" />
                            <Vertex pos="0.734636 0.692464 0" />
                            <Vertex pos="-0.734636 -0.808175 0" />
                            <Vertex pos="-0.265368 -1.03958 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -444.064 0 -1 0 383.056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -801.968 0 -1 0 191.528 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.442279 0.896877 0 -0.945969" album="Blasted" material="bm_edge_white" texgens="0 0 -1 57.5077 0.896875 -0.442284 0 128 -90 0.19621 0.125" texRot="-90" texScale="0.19621 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.923879 0.382686 5.57558e-007 -0.369437" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.382685 0.923879 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.866024 -0.500003 -1.75505e-006 -0.289978" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.382685 0.923879 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.44227 -0.896882 0 -1.04974" album="Blasted" material="bm_edge_white" texgens="0 0 1 73.7442 0.896879 -0.442276 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="853" owner="0" type="0" pos="-0.173706 71.1848 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -0.173706 0 1 0 71.1848 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.173717 1.01137 0.5" />
                            <Vertex pos="0.826287 0.575332 0.5" />
                            <Vertex pos="-0.826287 -0.720678 0.5" />
                            <Vertex pos="-0.39124 -1.01137 0.5" />
                            <Vertex pos="0.173717 1.01137 0" />
                            <Vertex pos="0.826286 0.575332 0" />
                            <Vertex pos="-0.826286 -0.720678 0" />
                            <Vertex pos="-0.391241 -1.01137 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -300.469 0 -1 0 464.696 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -873.766 0 -1 0 232.348 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.555574 0.831467 -1.05967e-006 -0.937433" album="Blasted" material="bm_edge_white" texgens="0 0 -1 59.9191 0.831466 -0.555576 0 128 -90 0.196205 0.125" texRot="-90" texScale="0.196205 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.866024 0.500002 0 -0.355244" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.500002 0.866025 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.793352 -0.608764 -1.60777e-006 -0.305294" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.500002 0.866025 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.555576 -0.831466 -1.05968e-006 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 70.121 0.831465 -0.555578 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="854" owner="0" type="0" pos="0.338852 70.7943 30.5" rot="1 0 0 0" scale="" transform="1 0 0 0.338852 0 1 0 70.7943 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.313728 0.965846 0.5" />
                            <Vertex pos="0.903798 0.448366 0.5" />
                            <Vertex pos="-0.903798 -0.620857 0.5" />
                            <Vertex pos="-0.51042 -0.965846 0.5" />
                            <Vertex pos="0.313728 0.965846 0" />
                            <Vertex pos="0.903797 0.448366 0" />
                            <Vertex pos="-0.903799 -0.620857 0" />
                            <Vertex pos="-0.51042 -0.965846 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -169.254 0 -1 0 564.668 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -939.373 0 -1 0 282.334 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.659348 0.751838 -1.33621e-006 -0.933015" album="Blasted" material="bm_edge_white" texgens="0 0 -1 62.6066 0.751838 -0.659348 0 128 -90 0.196212 0.125" texRot="-90" texScale="0.196212 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.793352 0.608764 0 -0.339075" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.608763 0.793352 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.707105 -0.707108 0 -0.322037" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.608763 0.793352 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.659351 -0.751835 1.33621e-006 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 66.0874 0.751835 -0.659351 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="855" owner="0" type="0" pos="0.794281 70.3388 30.5" rot="1 0 0 0" scale="" transform="1 0 0 0.794281 0 1 0 70.3388 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.448369 0.903797 0.5" />
                            <Vertex pos="0.965849 0.313717 0.5" />
                            <Vertex pos="-0.965849 -0.510415 0.5" />
                            <Vertex pos="-0.620857 -0.903797 0.5" />
                            <Vertex pos="0.448368 0.903797 5.96046e-008" />
                            <Vertex pos="0.965849 0.313716 5.96046e-008" />
                            <Vertex pos="-0.965849 -0.510415 5.96046e-008" />
                            <Vertex pos="-0.620857 -0.903797 5.96046e-008" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -52.6641 0 -1 0 681.259 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 5.96046e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -997.668 0 -1 0 340.629 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.751844 0.659341 -1.33619e-006 -0.933013" album="Blasted" material="bm_edge_white" texgens="0 0 -1 65.393 0.659341 -0.751844 0 128 -90 0.196208 0.125" texRot="-90" texScale="0.196208 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707106 0.707108 1.39084e-006 -0.322039" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707108 0.707105 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.608759 -0.793355 0 -0.33908" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707108 0.707105 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.751835 -0.659352 0 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 61.9135 0.659351 -0.751835 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="856" owner="0" type="0" pos="1.18479 69.8263 30.5" rot="1 0 0 0" scale="" transform="1 0 0 1.18479 0 1 0 69.8263 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.575339 0.826281 0.5" />
                            <Vertex pos="1.01137 0.173711 0.5" />
                            <Vertex pos="-1.01137 -0.391235 0.5" />
                            <Vertex pos="-0.720681 -0.826281 0.5" />
                            <Vertex pos="0.57534 0.826281 0" />
                            <Vertex pos="1.01137 0.173711 0" />
                            <Vertex pos="-1.01137 -0.391234 0" />
                            <Vertex pos="-0.72068 -0.826282 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 47.3066 0 -1 0 812.475 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1047.65 0 -1 0 406.237 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.831471 0.555568 0 -0.937433" album="Blasted" material="bm_edge_white" texgens="0 0 -1 68.084 0.555567 -0.831472 0 128 -90 0.196204 0.125" texRot="-90" texScale="0.196204 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.608758 0.793356 -1.16111e-006 -0.305292" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.793355 0.608759 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.499997 -0.866027 2.76833e-006 -0.355245" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.793355 0.608759 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.831469 -0.55557 -1.09278e-006 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 57.877 0.555568 -0.831471 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="857" owner="0" type="0" pos="1.5037 69.2654 30.5" rot="1 0 0 0" scale="" transform="1 0 0 1.5037 0 1 0 69.2654 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.69246 0.734631 0.5" />
                            <Vertex pos="1.03959 0.0307314 0.5" />
                            <Vertex pos="-1.03959 -0.26536 0.5" />
                            <Vertex pos="-0.808179 -0.734631 0.5" />
                            <Vertex pos="0.692459 0.734631 0" />
                            <Vertex pos="1.03959 0.0307317 0" />
                            <Vertex pos="-1.03959 -0.26536 0" />
                            <Vertex pos="-0.80818 -0.734631 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 128.947 0 -1 0 956.071 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1088.47 0 -1 0 478.035 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.89687 0.442294 2.65275e-007 -0.94597" album="Blasted" material="bm_edge_white" texgens="0 0 -1 70.4959 0.442294 -0.89687 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.499997 0.866027 1.01327e-006 -0.289983" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866027 0.499997 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.38268 -0.923881 -7.29904e-007 -0.369438" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866027 0.499997 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.896879 -0.442275 0 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 54.2577 0.442276 -0.896879 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="858" owner="0" type="0" pos="1.74554 68.6657 30.5" rot="1 0 0 0" scale="" transform="1 0 0 1.74554 0 1 0 68.6657 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.79775 0.630409 0.5" />
                            <Vertex pos="1.05002 -0.11278 0.5" />
                            <Vertex pos="-1.05002 -0.134953 0.5" />
                            <Vertex pos="-0.881831 -0.630409 0.5" />
                            <Vertex pos="0.797749 0.630409 0" />
                            <Vertex pos="1.05002 -0.112781 0" />
                            <Vertex pos="-1.05002 -0.134953 0" />
                            <Vertex pos="-0.88183 -0.630409 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 190.858 0 -1 0 1109.59 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1119.43 0 -1 0 554.794 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.946934 0.32143 -6.46606e-007 -0.958048" album="Blasted" material="bm_edge_white" texgens="0 0 -1 72.462 0.321429 -0.946934 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.38268 0.923881 7.75522e-007 -0.277141" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.923881 0.38268 0 160.695 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.258815 -0.965927 5.24503e-007 -0.380698" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.923881 0.38268 0 160.695 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.946927 -0.321449 0 -1.03767" album="Blasted" material="bm_edge_white" texgens="0 0 1 51.3086 0.321446 -0.946928 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="859" owner="0" type="0" pos="1.90619 68.0375 30.5" rot="1 0 0 0" scale="" transform="1 0 0 1.90619 0 1 0 68.0375 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.88937 0.515401 0.5" />
                            <Vertex pos="1.04248 -0.254357 0.5" />
                            <Vertex pos="-1.04248 -0.00222814 0.5" />
                            <Vertex pos="-0.94041 -0.515401 0.5" />
                            <Vertex pos="0.88937 0.515401 0" />
                            <Vertex pos="1.04248 -0.254357 0" />
                            <Vertex pos="-1.04248 -0.00222778 0" />
                            <Vertex pos="-0.940411 -0.515401 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 231.984 0 -1 0 1270.4 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1139.99 0 -1 0 635.201 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.980786 0.195085 0 -0.972829" album="Blasted" material="bm_edge_white" texgens="0 0 -1 73.8561 0.195085 -0.980786 0 128 -90 0.196205 0.125" texRot="-90" texScale="0.196205 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.258815 0.965927 0 -0.267657" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965927 0.258815 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.130522 -0.991445 -2.48951e-007 -0.388248" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965927 0.258815 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.980788 -0.195077 -1.40438e-007 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 49.2162 0.195079 -0.980787 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="860" owner="0" type="0" pos="1.98289 67.3916 30.5" rot="1 0 0 0" scale="" transform="1 0 0 1.98289 0 1 0 67.3916 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.96578 0.391566 0.5" />
                            <Vertex pos="1.01711 -0.391566 0.5" />
                            <Vertex pos="-1.01711 0.130522 0.5" />
                            <Vertex pos="-0.98289 -0.391566 0.5" />
                            <Vertex pos="0.96578 0.391566 0" />
                            <Vertex pos="1.01711 -0.391566 0" />
                            <Vertex pos="-1.01711 0.130522 0" />
                            <Vertex pos="-0.982891 -0.391566 0" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 251.62 0 -1 0 1435.76 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -1149.81 0 -1 0 717.88 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.997859 0.0654041 0 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 74.5754 0.0654043 -0.997859 0 128 -90 0.196205 0.125" texRot="-90" texScale="0.196205 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.130522 0.991445 0 -0.262161" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.991445 0.130522 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 -0 -0.391566" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.991445 0.130522 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0.997859 -0.0654022 0 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 48.1376 0.0654041 -0.997859 0 128 90 0.130802 0.125" texRot="90" texScale="0.130802 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="861" owner="0" type="0" pos="-7.98289 57.3916 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.98289 0 1 0 57.3916 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.01711 -0.391579 0.5" />
                            <Vertex pos="-0.96578 0.391579 0.5" />
                            <Vertex pos="0.98289 -0.391574 0.5" />
                            <Vertex pos="1.01711 0.130531 0.5" />
                            <Vertex pos="-1.01711 -0.39158 0" />
                            <Vertex pos="-0.96578 0.39158 0" />
                            <Vertex pos="0.98289 -0.391574 0" />
                            <Vertex pos="1.01711 0.130531 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2299.62 0 -1 0 1435.76 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 125.81 0 -1 0 717.88 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.997859 0.065402 1.28643e-007 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 53.4244 0.065402 0.997859 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="2.99513e-006 -1 1.96695e-006 -0.391577" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -1 0 0 159.452 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.130524 0.991445 0 -0.262172" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -1 0 0 159.452 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.997859 -0.065402 0 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 79.8622 0.0654019 0.997859 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="862" owner="0" type="0" pos="-7.90619 58.0375 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.90619 0 1 0 58.0375 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.04248 -0.254355 0.5" />
                            <Vertex pos="-0.88937 0.515402 0.5" />
                            <Vertex pos="0.94041 -0.515402 0.5" />
                            <Vertex pos="1.04248 -0.00223005 0.5" />
                            <Vertex pos="-1.04248 -0.254354 0" />
                            <Vertex pos="-0.88937 0.515403 0" />
                            <Vertex pos="0.940411 -0.515403 0" />
                            <Vertex pos="1.04248 -0.00222969 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2279.98 0 -1 0 1270.4 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 115.992 0 -1 0 635.2 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.980786 0.195085 3.72095e-007 -0.972829" album="Blasted" material="bm_edge_white" texgens="0 0 -1 54.1463 0.195085 0.980786 0 128 -90 0.196208 0.125" texRot="-90" texScale="0.196208 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.130524 -0.991445 -2.00922e-006 -0.388247" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.991445 0.130524 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.258816 0.965927 6.95382e-007 -0.267657" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.991445 0.130524 0 159.988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.980788 -0.195077 2.24278e-006 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 78.7845 0.195078 0.980788 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="863" owner="0" type="0" pos="-7.74554 58.6657 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.74554 0 1 0 58.6657 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.05002 -0.112779 0.5" />
                            <Vertex pos="-0.79774 0.630411 0.5" />
                            <Vertex pos="0.88183 -0.630411 0.5" />
                            <Vertex pos="1.05002 -0.134952 0.5" />
                            <Vertex pos="-1.05002 -0.112779 0" />
                            <Vertex pos="-0.79774 0.630411 0" />
                            <Vertex pos="0.88183 -0.630411 0" />
                            <Vertex pos="1.05002 -0.134952 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2238.86 0 -1 0 1109.59 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 95.429 0 -1 0 554.793 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.94693 0.321441 0 -0.958043" album="Blasted" material="bm_edge_white" texgens="0 0 -1 55.5371 0.32144 0.94693 0 128 -90 0.19621 0.125" texRot="-90" texScale="0.19621 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.258816 -0.965927 0 -0.380699" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965927 0.258817 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.382682 0.92388 0 -0.277144" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965927 0.258817 0 160.478 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.946928 -0.321447 0 -1.03767" album="Blasted" material="bm_edge_white" texgens="0 0 1 76.6914 0.321446 0.946928 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="864" owner="0" type="0" pos="-7.50369 59.2654 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.50369 0 1 0 59.2654 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.03959 0.0307312 0.5" />
                            <Vertex pos="-0.69247 0.734631 0.5" />
                            <Vertex pos="0.808168 -0.734631 0.5" />
                            <Vertex pos="1.03959 -0.265369 0.5" />
                            <Vertex pos="-1.03959 0.0307312 0" />
                            <Vertex pos="-0.69247 0.734632 0" />
                            <Vertex pos="0.808168 -0.734632 0" />
                            <Vertex pos="1.03959 -0.265368 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2176.94 0 -1 0 956.068 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 64.4724 0 -1 0 478.034 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.896875 0.442284 8.96313e-007 -0.945975" album="Blasted" material="bm_edge_white" texgens="0 0 -1 57.5068 0.442284 0.896875 0 128 -90 0.196209 0.125" texRot="-90" texScale="0.196209 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.382682 -0.92388 0 -0.36944" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.92388 0.382682 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.499998 0.866027 1.70343e-006 -0.289977" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.92388 0.382682 0 160.889 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.896868 -0.442299 8.96344e-007 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 73.7373 0.442299 0.896868 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="865" owner="0" type="0" pos="-7.18479 59.8263 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.18479 0 1 0 59.8263 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.01137 0.173716 0.5" />
                            <Vertex pos="-0.575332 0.826286 0.5" />
                            <Vertex pos="0.72069 -0.826286 0.5" />
                            <Vertex pos="1.01137 -0.391232 0.5" />
                            <Vertex pos="-1.01137 0.173716 0" />
                            <Vertex pos="-0.575332 0.826286 0" />
                            <Vertex pos="0.72069 -0.826286 0" />
                            <Vertex pos="1.01137 -0.391232 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -2095.31 0 -1 0 812.474 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 23.6531 0 -1 0 406.237 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.831467 0.555574 0 -0.937433" album="Blasted" material="bm_edge_white" texgens="0 0 -1 59.9174 0.555576 0.831466 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.499999 -0.866026 0 -0.355241" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866026 0.499998 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.608761 0.793354 0 -0.305297" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866026 0.499998 0 161.193 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.831482 -0.555552 0 -1.05829" album="Blasted" material="bm_edge_white" texgens="0 0 1 70.1264 0.555555 0.83148 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="866" owner="0" type="0" pos="-6.79427 60.3388 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -6.79427 0 1 0 60.3388 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.965847 0.313718 0.5" />
                            <Vertex pos="-0.448367 0.903798 0.5" />
                            <Vertex pos="0.620855 -0.903798 0.5" />
                            <Vertex pos="0.965847 -0.510416 0.5" />
                            <Vertex pos="-0.965847 0.313718 0" />
                            <Vertex pos="-0.448367 0.903798 0" />
                            <Vertex pos="0.620855 -0.903799 0" />
                            <Vertex pos="0.965847 -0.510417 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1995.33 0 -1 0 681.256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -26.3333 0 -1 0 340.628 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.751844 0.659341 0 -0.933013" album="Blasted" material="bm_edge_white" texgens="0 0 -1 62.6079 0.659341 0.751844 0 128 -90 0.196212 0.125" texRot="-90" texScale="0.196212 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.608761 -0.793354 0 -0.33908" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.793354 0.608761 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.707107 0.707107 -1.43299e-006 -0.322038" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.793354 0.608761 0 161.368 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.751835 -0.659352 1.33621e-006 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 66.087 0.659351 0.751835 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="867" owner="0" type="0" pos="-6.33884 60.7943 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -6.33884 0 1 0 60.7943 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.903797 0.448368 0.5" />
                            <Vertex pos="-0.313727 0.965848 0.5" />
                            <Vertex pos="0.510419 -0.965848 0.5" />
                            <Vertex pos="0.903797 -0.620859 0.5" />
                            <Vertex pos="-0.903797 0.448368 0" />
                            <Vertex pos="-0.313726 0.965848 0" />
                            <Vertex pos="0.510419 -0.965848 0" />
                            <Vertex pos="0.903797 -0.620859 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1878.74 0 -1 0 564.666 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -84.6282 0 -1 0 282.333 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.659348 0.751838 -1.29691e-006 -0.933016" album="Blasted" material="bm_edge_white" texgens="0 0 -1 65.3938 0.751838 0.659348 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 0 -0.322037" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707107 0.707107 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.793353 0.608762 0 -0.339075" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707107 0.707107 0 161.404 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.659352 -0.751834 0 -1.0627" album="Blasted" material="bm_edge_white" texgens="0 0 1 61.9132 0.751835 0.659351 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="868" owner="0" type="0" pos="-5.82629 61.1848 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -5.82629 0 1 0 61.1848 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.826285 0.575338 0.5" />
                            <Vertex pos="-0.173715 1.01137 0.5" />
                            <Vertex pos="0.391239 -1.01137 0.5" />
                            <Vertex pos="0.826285 -0.720682 0.5" />
                            <Vertex pos="-0.826285 0.575338 0" />
                            <Vertex pos="-0.173715 1.01137 0" />
                            <Vertex pos="0.391239 -1.01137 0" />
                            <Vertex pos="0.826285 -0.720682 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1747.53 0 -1 0 464.696 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -150.236 0 -1 0 232.348 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.555569 0.83147 0 -0.937435" album="Blasted" material="bm_edge_white" texgens="0 0 -1 68.0809 0.831472 0.555567 0 128 -90 0.196211 0.125" texRot="-90" texScale="0.196211 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.793353 -0.608761 0 -0.305292" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.608762 0.793353 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.866026 0.5 0 -0.355243" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.608762 0.793353 0 161.297 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.55557 -0.83147 0 -1.05828" album="Blasted" material="bm_edge_white" texgens="0 0 1 57.8764 0.831471 0.555569 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="869" owner="0" type="0" pos="-5.26537 61.5037 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -5.26537 0 1 0 61.5037 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.734634 0.69246 0.5" />
                            <Vertex pos="-0.0307338 1.03959 0.5" />
                            <Vertex pos="0.265366 -1.03959 0.5" />
                            <Vertex pos="0.734633 -0.808171 0.5" />
                            <Vertex pos="-0.734633 0.69246 0" />
                            <Vertex pos="-0.0307341 1.03959 0" />
                            <Vertex pos="0.265366 -1.03959 0" />
                            <Vertex pos="0.734634 -0.808171 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1603.93 0 -1 0 383.055 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 0" album="" material="bm_grid_blank4" texgens="-1 0 0 -222.033 0 -1 0 191.528 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.442294 0.89687 2.65275e-007 -0.945971" album="Blasted" material="bm_edge_white" texgens="0 0 -1 70.4933 0.89687 0.442294 0 128 -90 0.196213 0.125" texRot="-90" texScale="0.196213 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.866026 -0.5 -1.65181e-006 -0.289981" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.5 0.866025 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.92388 0.382683 1.76216e-006 -0.36944" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.5 0.866025 0 161.056 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.442291 -0.896872 0 -1.04975" album="Blasted" material="bm_edge_white" texgens="0 0 1 54.2607 0.896871 0.442291 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="870" owner="0" type="0" pos="-4.66569 61.7455 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -4.66569 0 1 0 61.7455 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.630414 0.797741 0.5" />
                            <Vertex pos="0.112776 1.05002 0.5" />
                            <Vertex pos="0.134953 -1.05002 0.5" />
                            <Vertex pos="0.630414 -0.88184 0.5" />
                            <Vertex pos="-0.630415 0.797741 2.98023e-008" />
                            <Vertex pos="0.112776 1.05002 2.98023e-008" />
                            <Vertex pos="0.134953 -1.05002 2.98023e-008" />
                            <Vertex pos="0.630415 -0.881841 2.98023e-008" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1450.42 0 -1 0 321.142 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 2.98023e-008" album="" material="bm_grid_blank4" texgens="-1 0 0 -298.792 0 -1 0 160.571 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.321439 0.94693 0 -0.958045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 72.4634 0.94693 0.32144 0 128 -90 0.196208 0.125" texRot="-90" texScale="0.196208 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.92388 -0.382684 1.8723e-006 -0.277145" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.382683 0.92388 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.965926 0.258818 1.433e-006 -0.380698" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.382683 0.92388 0 160.696 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.321426 -0.946935 0 -1.03768" album="Blasted" material="bm_edge_white" texgens="0 0 1 51.3039 0.946934 0.321429 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="871" owner="0" type="0" pos="-4.03751 61.9062 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -4.03751 0 1 0 61.9062 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.515404 0.889376 0.5" />
                            <Vertex pos="0.254353 1.04249 0.5" />
                            <Vertex pos="0.0022347 -1.04249 0.5" />
                            <Vertex pos="0.515404 -0.940405 0.5" />
                            <Vertex pos="-0.515404 0.889376 0" />
                            <Vertex pos="0.254353 1.04249 0" />
                            <Vertex pos="0.00223541 -1.04249 0" />
                            <Vertex pos="0.515404 -0.940405 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1289.6 0 -1 0 280.017 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -379.199 0 -1 0 140.008 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.19509 0.980785 0 -0.972837" album="Blasted" material="bm_edge_white" texgens="0 0 -1 73.8554 0.980786 0.195085 0 128 -90 0.196206 0.125" texRot="-90" texScale="0.196206 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.965926 -0.258818 0 -0.267656" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258818 0.965926 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.991445 0.130525 0 -0.388248" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258818 0.965926 0 160.241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.195108 -0.980782 2.77105e-007 -1.02289" album="Blasted" material="bm_edge_white" texgens="0 0 1 49.22 0.980784 0.195099 0 128 90 0.130806 0.125" texRot="90" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="872" owner="0" type="0" pos="-3.39157 61.9829 30.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.39157 0 1 0 61.9829 0 0 1 30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.391579 0.96578 0.5" />
                            <Vertex pos="0.391579 1.01711 0.5" />
                            <Vertex pos="-0.130529 -1.01711 0.5" />
                            <Vertex pos="0.391577 -0.98289 0.5" />
                            <Vertex pos="-0.391579 0.96578 0" />
                            <Vertex pos="0.391579 1.01711 0" />
                            <Vertex pos="-0.130529 -1.01711 0" />
                            <Vertex pos="0.391577 -0.98289 0" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_tile10_C" texgens="1 0 0 -1124.24 0 -1 0 260.38 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -461.879 0 -1 0 130.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.065402 0.997859 0 -0.989322" album="Blasted" material="bm_edge_white" texgens="0 0 -1 74.5735 0.997859 0.065402 0 128 -90 0.196214 0.125" texRot="-90" texScale="0.196214 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.991445 -0.130525 0 -0.262171" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.130525 0.991445 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="1 -9.98378e-007 0 -0.391578" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.130525 0.991445 0 159.724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.0654019 -0.997859 0 -1.0064" album="Blasted" material="bm_edge_white" texgens="0 0 1 48.1371 0.997859 0.0654019 0 128 90 0.130807 0.125" texRot="90" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="873" owner="0" type="0" pos="-35 1 -11" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 1 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12131 2.12126 -6" />
                            <Vertex pos="2.12131 2.12126 6" />
                            <Vertex pos="3 4.76837e-007 -6" />
                            <Vertex pos="3 4.76837e-007 6" />
                            <Vertex pos="5.72205e-006 3 -6" />
                            <Vertex pos="5.72205e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 6.67572e-006 -6" />
                            <Vertex pos="-3 6.67572e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="-1.90735e-006 -3 -6" />
                            <Vertex pos="-1.90735e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12125 -6" />
                            <Vertex pos="2.12134 -2.12125 6" />
                        </Vertices>
                        <Face id="0" plane="0.923874 0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.984 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382709 0.923869 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.005 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.007 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.984 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382706 -0.92387 0 -2.77161" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.002 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923878 -0.382687 0 -2.77163" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.006 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="874" owner="0" type="0" pos="-35 1 14" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 1 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692902 0.28685 -19" />
                            <Vertex pos="0.692902 0.28685 19" />
                            <Vertex pos="0.75 -8.58307e-006 -19" />
                            <Vertex pos="0.75 -8.58307e-006 19" />
                            <Vertex pos="0.530313 0.530311 -19" />
                            <Vertex pos="0.530313 0.530311 19" />
                            <Vertex pos="0.287004 0.69281 -19" />
                            <Vertex pos="0.287004 0.69281 19" />
                            <Vertex pos="2.47955e-005 0.75 -19" />
                            <Vertex pos="2.47955e-005 0.75 19" />
                            <Vertex pos="-0.287098 0.692781 -19" />
                            <Vertex pos="-0.287098 0.692781 19" />
                            <Vertex pos="-0.53031 0.530316 -19" />
                            <Vertex pos="-0.53031 0.530316 19" />
                            <Vertex pos="-0.692905 0.286874 -19" />
                            <Vertex pos="-0.692905 0.286874 19" />
                            <Vertex pos="-0.750002 -4.29153e-006 -19" />
                            <Vertex pos="-0.750002 -4.29153e-006 19" />
                            <Vertex pos="-0.692909 -0.286873 -19" />
                            <Vertex pos="-0.692909 -0.286873 19" />
                            <Vertex pos="-0.530378 -0.530278 -19" />
                            <Vertex pos="-0.530378 -0.530278 19" />
                            <Vertex pos="-0.286968 -0.692812 -19" />
                            <Vertex pos="-0.286968 -0.692812 19" />
                            <Vertex pos="0 -0.75 -19" />
                            <Vertex pos="0 -0.75 19" />
                            <Vertex pos="0.286997 -0.692813 -19" />
                            <Vertex pos="0.286997 -0.692813 19" />
                            <Vertex pos="0.530346 -0.53031 -19" />
                            <Vertex pos="0.530346 -0.53031 19" />
                            <Vertex pos="0.692907 -0.28687 -19" />
                            <Vertex pos="0.692907 -0.28687 19" />
                        </Vertices>
                        <Face id="0" plane="0.98076 0.195216 0 -0.735569" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.68346 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831606 0.555366 -0 -0.735528" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0439 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555393 0.831588 -0 -0.735532" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.19544 0.980716 -0 -0.735542" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7748 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195441 0.980715 0 -0.735532" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1393 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555466 0.831539 0 -0.735548" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5059 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831576 0.55541 0 -0.735536" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8663 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980763 0.1952 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2357 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.195193 0 -0.735576" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.5961 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831638 -0.555317 0 -0.735555" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9572 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555317 -0.831639 0 -0.735528" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3257 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.19544 -0.980716 0 -0.735537" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.691 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195418 -0.98072 0 -0.73554" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.55534 -0.831624 0 -0.73554" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831628 -0.555333 0 -0.735549" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.787 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980764 -0.195198 0 -0.735575" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -19" album="" material="solid_bm" texgens="-1 0 0 0.499878 0 -1 0 0.499985 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -19" album="" material="solid_bm" texgens="1 0 0 0.500122 0 -1 0 0.499985 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="875" owner="0" type="0" pos="-16 55 -11" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 55 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12131 2.12126 -6" />
                            <Vertex pos="2.12131 2.12126 6" />
                            <Vertex pos="3 4.76837e-007 -6" />
                            <Vertex pos="3 4.76837e-007 6" />
                            <Vertex pos="5.72205e-006 3 -6" />
                            <Vertex pos="5.72205e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 6.67572e-006 -6" />
                            <Vertex pos="-3 6.67572e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="-1.90735e-006 -3 -6" />
                            <Vertex pos="-1.90735e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12125 -6" />
                            <Vertex pos="2.12134 -2.12125 6" />
                        </Vertices>
                        <Face id="0" plane="0.923874 0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.984 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382709 0.923869 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.005 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.007 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.984 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382706 -0.92387 0 -2.77161" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.002 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923878 -0.382687 0 -2.77163" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.006 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="876" owner="0" type="0" pos="-16 55 14" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 55 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692902 0.28685 -19" />
                            <Vertex pos="0.692902 0.28685 39" />
                            <Vertex pos="0.75 -8.58307e-006 -19" />
                            <Vertex pos="0.75 -7.62939e-006 39" />
                            <Vertex pos="0.530313 0.530311 -19" />
                            <Vertex pos="0.530313 0.530312 39" />
                            <Vertex pos="0.287004 0.69281 -19" />
                            <Vertex pos="0.287004 0.69281 39" />
                            <Vertex pos="2.47955e-005 0.75 -19" />
                            <Vertex pos="2.47955e-005 0.75 39" />
                            <Vertex pos="-0.287098 0.692781 -19" />
                            <Vertex pos="-0.287098 0.69278 39" />
                            <Vertex pos="-0.53031 0.530316 -19" />
                            <Vertex pos="-0.53031 0.530315 39" />
                            <Vertex pos="-0.692905 0.286874 -19" />
                            <Vertex pos="-0.692905 0.286873 39" />
                            <Vertex pos="-0.750002 -4.29153e-006 -19" />
                            <Vertex pos="-0.750002 -3.8147e-006 39" />
                            <Vertex pos="-0.692909 -0.286873 -19" />
                            <Vertex pos="-0.692909 -0.286873 39" />
                            <Vertex pos="-0.530378 -0.530278 -19" />
                            <Vertex pos="-0.530378 -0.530277 39" />
                            <Vertex pos="-0.286968 -0.692812 -19" />
                            <Vertex pos="-0.286968 -0.69281 39" />
                            <Vertex pos="0 -0.75 -19" />
                            <Vertex pos="0 -0.75 39" />
                            <Vertex pos="0.286997 -0.692813 -19" />
                            <Vertex pos="0.286997 -0.692814 39" />
                            <Vertex pos="0.530346 -0.53031 -19" />
                            <Vertex pos="0.530346 -0.530312 39" />
                            <Vertex pos="0.692907 -0.28687 -19" />
                            <Vertex pos="0.692907 -0.286869 39" />
                        </Vertices>
                        <Face id="0" plane="0.98076 0.195217 0 -0.735569" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.68346 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831606 0.555366 -9.70243e-009 -0.735528" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0439 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555393 0.831588 -0 -0.735532" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.19544 0.980716 -0 -0.735542" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7748 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195441 0.980715 1.61256e-008 -0.735531" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1393 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555466 0.831539 1.45273e-008 -0.735547" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5059 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831577 0.55541 9.41781e-009 -0.735536" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8663 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980763 0.1952 -1.60478e-009 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2357 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.195193 0 -0.735576" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.5961 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831638 -0.555317 9.70158e-009 -0.735555" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9572 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555317 -0.831639 2.9058e-008 -0.735527" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3257 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.19544 -0.980716 0 -0.735537" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.691 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195418 -0.98072 -1.71335e-008 -0.73554" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.55534 -0.831624 -2.90575e-008 -0.735541" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831628 -0.555333 9.70185e-009 -0.735549" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.787 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980764 -0.195198 3.20959e-009 -0.735575" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -19" album="" material="solid_bm" texgens="-1 0 0 0.499878 0 -1 0 0.499985 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -39" album="" material="solid_bm" texgens="1 0 0 0.500122 0 -1 0 0.499985 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="877" owner="0" type="0" pos="26 35 -11" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 35 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12131 2.12126 -6" />
                            <Vertex pos="2.12131 2.12126 6" />
                            <Vertex pos="3 4.76837e-007 -6" />
                            <Vertex pos="3 4.76837e-007 6" />
                            <Vertex pos="5.72205e-006 3 -6" />
                            <Vertex pos="5.72205e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 6.67572e-006 -6" />
                            <Vertex pos="-3 6.67572e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="-1.90735e-006 -3 -6" />
                            <Vertex pos="-1.90735e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12125 -6" />
                            <Vertex pos="2.12134 -2.12125 6" />
                        </Vertices>
                        <Face id="0" plane="0.923874 0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.984 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382709 0.923869 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.005 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.007 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.984 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382706 -0.92387 0 -2.77161" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.002 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923878 -0.382687 0 -2.77163" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.006 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="878" owner="0" type="0" pos="26 35 14" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 35 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692902 0.28685 -19" />
                            <Vertex pos="0.692902 0.28685 47" />
                            <Vertex pos="0.75 -8.58307e-006 -19" />
                            <Vertex pos="0.75 -7.62939e-006 47" />
                            <Vertex pos="0.530313 0.530311 -19" />
                            <Vertex pos="0.530313 0.530312 47" />
                            <Vertex pos="0.287004 0.69281 -19" />
                            <Vertex pos="0.287004 0.69281 47" />
                            <Vertex pos="2.47955e-005 0.75 -19" />
                            <Vertex pos="2.47955e-005 0.75 47" />
                            <Vertex pos="-0.287098 0.692781 -19" />
                            <Vertex pos="-0.287098 0.69278 47" />
                            <Vertex pos="-0.53031 0.530316 -19" />
                            <Vertex pos="-0.53031 0.530315 47" />
                            <Vertex pos="-0.692905 0.286874 -19" />
                            <Vertex pos="-0.692905 0.286873 47" />
                            <Vertex pos="-0.750002 -4.29153e-006 -19" />
                            <Vertex pos="-0.750002 -3.8147e-006 47" />
                            <Vertex pos="-0.692909 -0.286873 -19" />
                            <Vertex pos="-0.692909 -0.286873 47" />
                            <Vertex pos="-0.530378 -0.530278 -19" />
                            <Vertex pos="-0.530378 -0.530277 47" />
                            <Vertex pos="-0.286968 -0.692812 -19" />
                            <Vertex pos="-0.286968 -0.69281 47" />
                            <Vertex pos="0 -0.75 -19" />
                            <Vertex pos="0 -0.75 47" />
                            <Vertex pos="0.286997 -0.692813 -19" />
                            <Vertex pos="0.286997 -0.692814 47" />
                            <Vertex pos="0.530346 -0.53031 -19" />
                            <Vertex pos="0.530346 -0.530312 47" />
                            <Vertex pos="0.692907 -0.28687 -19" />
                            <Vertex pos="0.692907 -0.286869 47" />
                        </Vertices>
                        <Face id="0" plane="0.98076 0.195217 0 -0.735569" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.68346 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831606 0.555366 -8.52638e-009 -0.735528" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0439 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555393 0.831588 -0 -0.735532" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.19544 0.980716 -0 -0.735542" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7748 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195441 0.980715 1.4171e-008 -0.735531" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1393 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555466 0.831539 1.27664e-008 -0.735547" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5059 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831576 0.55541 8.27626e-009 -0.735536" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8663 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980763 0.1952 -1.41026e-009 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2357 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.195193 0 -0.735576" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.5961 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831639 -0.555317 8.52563e-009 -0.735555" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9572 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555317 -0.831639 2.55358e-008 -0.735527" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3257 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.19544 -0.980716 0 -0.735537" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.691 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195418 -0.98072 -1.50567e-008 -0.73554" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.55534 -0.831624 -2.55354e-008 -0.735541" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831628 -0.555333 8.52587e-009 -0.735549" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.787 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980764 -0.195198 2.82055e-009 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -19" album="" material="solid_bm" texgens="-1 0 0 0.499878 0 -1 0 0.499985 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -47" album="" material="solid_bm" texgens="1 0 0 0.500122 0 -1 0 0.499985 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="879" owner="0" type="0" pos="27 -7 -11" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 -7 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12131 2.12126 -6" />
                            <Vertex pos="2.12131 2.12126 6" />
                            <Vertex pos="3 4.76837e-007 -6" />
                            <Vertex pos="3 4.76837e-007 6" />
                            <Vertex pos="5.72205e-006 3 -6" />
                            <Vertex pos="5.72205e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 6.67572e-006 -6" />
                            <Vertex pos="-3 6.67572e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="-1.90735e-006 -3 -6" />
                            <Vertex pos="-1.90735e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12125 -6" />
                            <Vertex pos="2.12134 -2.12125 6" />
                        </Vertices>
                        <Face id="0" plane="0.923874 0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.984 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 -0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 128 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382709 0.923869 0 -2.77161" album="" material="bm_grid_blank4" texgens="-0.92388 -0.382683 0 128.005 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128.007 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank4" texgens="0.382682 -0.92388 0 127.984 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382706 -0.92387 0 -2.77161" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.002 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923878 -0.382687 0 -2.77163" album="" material="bm_grid_blank4" texgens="0.382681 0.92388 0 128.006 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="880" owner="0" type="0" pos="27 -7 14" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 -7 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692902 0.28685 -19" />
                            <Vertex pos="0.692902 0.28685 31" />
                            <Vertex pos="0.75 -8.58307e-006 -19" />
                            <Vertex pos="0.75 -8.58307e-006 31" />
                            <Vertex pos="0.530313 0.530311 -19" />
                            <Vertex pos="0.530313 0.530311 31" />
                            <Vertex pos="0.287004 0.69281 -19" />
                            <Vertex pos="0.287004 0.69281 31" />
                            <Vertex pos="2.47955e-005 0.75 -19" />
                            <Vertex pos="2.47955e-005 0.75 31" />
                            <Vertex pos="-0.287098 0.692781 -19" />
                            <Vertex pos="-0.287098 0.692781 31" />
                            <Vertex pos="-0.53031 0.530316 -19" />
                            <Vertex pos="-0.53031 0.530316 31" />
                            <Vertex pos="-0.692905 0.286874 -19" />
                            <Vertex pos="-0.692905 0.286874 31" />
                            <Vertex pos="-0.750002 -4.29153e-006 -19" />
                            <Vertex pos="-0.750002 -4.29153e-006 31" />
                            <Vertex pos="-0.692909 -0.286873 -19" />
                            <Vertex pos="-0.692909 -0.286873 31" />
                            <Vertex pos="-0.530378 -0.530278 -19" />
                            <Vertex pos="-0.530378 -0.530278 31" />
                            <Vertex pos="-0.286968 -0.692812 -19" />
                            <Vertex pos="-0.286968 -0.692812 31" />
                            <Vertex pos="0 -0.75 -19" />
                            <Vertex pos="0 -0.75 31" />
                            <Vertex pos="0.286997 -0.692813 -19" />
                            <Vertex pos="0.286997 -0.692813 31" />
                            <Vertex pos="0.530346 -0.53031 -19" />
                            <Vertex pos="0.530346 -0.53031 31" />
                            <Vertex pos="0.692907 -0.28687 -19" />
                            <Vertex pos="0.692907 -0.28687 31" />
                        </Vertices>
                        <Face id="0" plane="0.98076 0.195216 0 -0.735568" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.68346 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831606 0.555366 -0 -0.735528" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0439 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555393 0.831588 -0 -0.735532" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.19544 0.980716 -0 -0.735542" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7748 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195441 0.980715 0 -0.735532" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1393 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555466 0.831539 0 -0.735548" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5059 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831576 0.55541 0 -0.735536" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8663 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980763 0.1952 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2357 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.195193 0 -0.735576" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.5961 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831639 -0.555317 0 -0.735555" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9572 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555317 -0.831639 0 -0.735528" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3257 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.19544 -0.980716 0 -0.735537" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.691 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195418 -0.98072 0 -0.73554" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.55534 -0.831624 0 -0.73554" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831628 -0.555333 0 -0.735549" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.787 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980764 -0.195198 0 -0.735575" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -19" album="" material="solid_bm" texgens="-1 0 0 0.499878 0 -1 0 0.499985 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -31" album="" material="solid_bm" texgens="1 0 0 0.500122 0 -1 0 0.499985 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="881" owner="0" type="0" pos="21 49.5 37.75" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 49.5 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 3 -0.75" />
                            <Vertex pos="-6 3 -1.25" />
                            <Vertex pos="-7.5 1.5 0.25" />
                            <Vertex pos="-7.5 1.5 -0.25" />
                            <Vertex pos="-9 3 -0.75" />
                            <Vertex pos="-9 3 -1.25" />
                            <Vertex pos="-7.5 1.5 0.25" />
                            <Vertex pos="-7.5 1.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 6.36396" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -4.24264" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.5547 0.83205 -1.04006" album="" material="bm_friction_ice" texgens="1 0 0 5376 0 -1 0 -12672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.5547 -0.83205 0.624038" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="882" owner="0" type="0" pos="21 48 37.75" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 48 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.5 3 0.25" />
                            <Vertex pos="-7.5 3 -0.25" />
                            <Vertex pos="-6 1.5 -0.75" />
                            <Vertex pos="-6 1.5 -1.25" />
                            <Vertex pos="-7.5 3 0.25" />
                            <Vertex pos="-7.5 3 -0.25" />
                            <Vertex pos="-9 1.5 -0.75" />
                            <Vertex pos="-9 1.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 3.18198" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -7.42462" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.5547 0.83205 1.45609" album="" material="bm_friction_ice" texgens="1 0 0 5376 0 -1 0 -12288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.5547 -0.83205 -1.87211" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="883" owner="0" type="0" pos="19.5 48 37.75" rot="1 0 0 0" scale="" transform="1 0 0 19.5 0 1 0 48 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 3 0.25" />
                            <Vertex pos="-6 3 -0.25" />
                            <Vertex pos="-6 3 0.25" />
                            <Vertex pos="-6 3 -0.25" />
                            <Vertex pos="-7.5 4.5 -0.75" />
                            <Vertex pos="-7.5 4.5 -1.25" />
                            <Vertex pos="-7.5 1.5 -0.75" />
                            <Vertex pos="-7.5 1.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 6" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7.5" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 2.12132" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 6.36396" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.5547 0 0.83205 -3.53621" album="" material="bm_friction_ice" texgens="1 0 0 4992 0 -1 0 -12288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.5547 0 -0.83205 3.12019" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="884" owner="0" type="0" pos="21 48 37.75" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 48 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 4.5 -0.75" />
                            <Vertex pos="-6 4.5 -1.25" />
                            <Vertex pos="-6 1.5 -0.75" />
                            <Vertex pos="-6 1.5 -1.25" />
                            <Vertex pos="-7.5 3 0.25" />
                            <Vertex pos="-7.5 3 -0.25" />
                            <Vertex pos="-7.5 3 0.25" />
                            <Vertex pos="-7.5 3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 6" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7.5" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -7.42462" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -3.18198" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.5547 0 0.83205 3.95224" album="" material="bm_friction_ice" texgens="1 0 0 5376 0 -1 0 -12288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.5547 0 -0.83205 -4.36826" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="885" owner="0" type="0" pos="31.5 48 37.75" rot="1 0 0 0" scale="" transform="1 0 0 31.5 0 1 0 48 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 3 -0.75" />
                            <Vertex pos="-6 3 -1.25" />
                            <Vertex pos="-7.5 1.5 0.25" />
                            <Vertex pos="-7.5 1.5 -0.25" />
                            <Vertex pos="-9 3 -0.75" />
                            <Vertex pos="-9 3 -1.25" />
                            <Vertex pos="-7.5 1.5 0.25" />
                            <Vertex pos="-7.5 1.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 6.36396" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -4.24264" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.5547 0.83205 -1.04006" album="" material="bm_friction_ice" texgens="1 0 0 7552 0 -1 0 -12288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.5547 -0.83205 0.624038" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="886" owner="0" type="0" pos="31.5 46.5 37.75" rot="1 0 0 0" scale="" transform="1 0 0 31.5 0 1 0 46.5 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.5 3 0.25" />
                            <Vertex pos="-7.5 3 -0.25" />
                            <Vertex pos="-6 1.5 -0.75" />
                            <Vertex pos="-6 1.5 -1.25" />
                            <Vertex pos="-7.5 3 0.25" />
                            <Vertex pos="-7.5 3 -0.25" />
                            <Vertex pos="-9 1.5 -0.75" />
                            <Vertex pos="-9 1.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 3.18198" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -7.42462" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.5547 0.83205 1.45609" album="" material="bm_friction_ice" texgens="1 0 0 7552 0 -1 0 -11904 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.5547 -0.83205 -1.87211" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="887" owner="0" type="0" pos="30 46.5 37.75" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 46.5 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 3 0.25" />
                            <Vertex pos="-6 3 -0.25" />
                            <Vertex pos="-6 3 0.25" />
                            <Vertex pos="-6 3 -0.25" />
                            <Vertex pos="-7.5 4.5 -0.75" />
                            <Vertex pos="-7.5 4.5 -1.25" />
                            <Vertex pos="-7.5 1.5 -0.75" />
                            <Vertex pos="-7.5 1.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 6" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7.5" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 2.12132" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 6.36396" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.5547 0 0.83205 -3.53621" album="" material="bm_friction_ice" texgens="1 0 0 7168 0 -1 0 -11904 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.5547 0 -0.83205 3.12019" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="888" owner="0" type="0" pos="31.5 46.5 37.75" rot="1 0 0 0" scale="" transform="1 0 0 31.5 0 1 0 46.5 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 4.5 -0.75" />
                            <Vertex pos="-6 4.5 -1.25" />
                            <Vertex pos="-6 1.5 -0.75" />
                            <Vertex pos="-6 1.5 -1.25" />
                            <Vertex pos="-7.5 3 0.25" />
                            <Vertex pos="-7.5 3 -0.25" />
                            <Vertex pos="-7.5 3 0.25" />
                            <Vertex pos="-7.5 3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 6" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7.5" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -7.42462" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -3.18198" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.5547 0 0.83205 3.95224" album="" material="bm_friction_ice" texgens="1 0 0 7552 0 -1 0 -11904 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.5547 0 -0.83205 -4.36826" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="889" owner="0" type="0" pos="12 50 18" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 50 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 19" />
                            <Vertex pos="1 3 -35" />
                            <Vertex pos="1 -3 19" />
                            <Vertex pos="1 -3 -35" />
                            <Vertex pos="-3 3 19" />
                            <Vertex pos="-3 3 -35" />
                            <Vertex pos="-3 -3 19" />
                            <Vertex pos="-3 -3 -35" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_friction_ice" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -35" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="890" owner="0" type="0" pos="28 50 18" rot="1 0 0 0" scale="" transform="1 0 0 28 0 1 0 50 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 19" />
                            <Vertex pos="1 3 -35" />
                            <Vertex pos="1 -3 19" />
                            <Vertex pos="1 -3 -35" />
                            <Vertex pos="-3 3 19" />
                            <Vertex pos="-3 3 -35" />
                            <Vertex pos="-3 -3 19" />
                            <Vertex pos="-3 -3 -35" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_friction_ice" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -35" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="891" owner="0" type="0" pos="22 50 18" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 50 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 19" />
                            <Vertex pos="3 3 15" />
                            <Vertex pos="3 -3 19" />
                            <Vertex pos="3 -3 15" />
                            <Vertex pos="-9 3 19" />
                            <Vertex pos="-9 3 15" />
                            <Vertex pos="-9 -3 19" />
                            <Vertex pos="-9 -3 15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_friction_ice" texgens="1 0 0 -256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 15" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
