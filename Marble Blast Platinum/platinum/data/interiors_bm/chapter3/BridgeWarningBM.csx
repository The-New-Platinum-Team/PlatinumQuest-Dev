<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2023/04/13 15:57:45">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="5">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="7" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="9">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="32" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="11 3 0" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="11 -3 0" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="11 3 0" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="168 0 -1" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="216 0 -1" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="459">
                    <Brush id="0" owner="0" type="0" pos="2 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 2" />
                            <Vertex pos="6 4 -2" />
                            <Vertex pos="6 -4 2" />
                            <Vertex pos="6 -4 -2" />
                            <Vertex pos="-6 4 2" />
                            <Vertex pos="-6 4 -2" />
                            <Vertex pos="-6 -4 2" />
                            <Vertex pos="-6 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="6 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="1" type="999" pos="20 3 0" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 1 1" />
                            <Vertex pos="-6 1 -1" />
                            <Vertex pos="-6 -1 1" />
                            <Vertex pos="-6 -1 -1" />
                            <Vertex pos="-12 1 1" />
                            <Vertex pos="-12 1 -1" />
                            <Vertex pos="-12 -1 1" />
                            <Vertex pos="-12 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 6" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile08_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="36 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 2" />
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 -4 2" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="-4 4 2" />
                            <Vertex pos="-4 4 -2" />
                            <Vertex pos="-4 -4 2" />
                            <Vertex pos="-4 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="34 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 34 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="41 0 4.76837e-007" rot="1 0 0 0" scale="" transform="1 0 0 41 0 1 0 0 0 0 1 4.76837e-007 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 3" />
                            <Vertex pos="1 4 -3" />
                            <Vertex pos="1 -4 3" />
                            <Vertex pos="1 -4 -3" />
                            <Vertex pos="-1 4 1" />
                            <Vertex pos="-1 4 -3" />
                            <Vertex pos="-1 -4 1" />
                            <Vertex pos="-1 -4 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -1.41421" album="" material="bm_friction_sand" texgens="1 0 0 10496 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="45 0 0" rot="1 0 0 0" scale="" transform="1 0 0 45 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 3" />
                            <Vertex pos="3 4 -3" />
                            <Vertex pos="3 -4 3" />
                            <Vertex pos="3 -4 -3" />
                            <Vertex pos="-3 4 3" />
                            <Vertex pos="-3 4 -3" />
                            <Vertex pos="-3 -4 3" />
                            <Vertex pos="-3 -4 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile07_C" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 384 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="49 1.19209e-007 1" rot="1 0 0 0" scale="" transform="1 0 0 49 0 1 0 1.19209e-007 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 4" />
                            <Vertex pos="1 4 -4" />
                            <Vertex pos="1 -4 4" />
                            <Vertex pos="1 -4 -4" />
                            <Vertex pos="-1 4 1.99999" />
                            <Vertex pos="-1 4 -4" />
                            <Vertex pos="-1 -4 1.99999" />
                            <Vertex pos="-1 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -384 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707108 0 0.707105 -2.12131" album="" material="bm_friction_sand" texgens="1 0 0 12544 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="53 0 1" rot="1 0 0 0" scale="" transform="1 0 0 53 0 1 0 0 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 4" />
                            <Vertex pos="3 4 -4" />
                            <Vertex pos="3 -4 4" />
                            <Vertex pos="3 -4 -4" />
                            <Vertex pos="-3 4 4" />
                            <Vertex pos="-3 4 -4" />
                            <Vertex pos="-3 -4 4" />
                            <Vertex pos="-3 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 384 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile07_C" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 384 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="54 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="58 0 4" rot="1 0 0 0" scale="" transform="1 0 0 58 0 1 0 0 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 1" />
                            <Vertex pos="2 4 -1" />
                            <Vertex pos="2 -4 1" />
                            <Vertex pos="2 -4 -1" />
                            <Vertex pos="-2 4 1" />
                            <Vertex pos="-2 4 -1" />
                            <Vertex pos="-2 -4 1" />
                            <Vertex pos="-2 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="86 0 0" rot="1 0 0 0" scale="" transform="1 0 0 86 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 1" />
                            <Vertex pos="2 4 -1" />
                            <Vertex pos="2 -4 1" />
                            <Vertex pos="2 -4 -1" />
                            <Vertex pos="-2 4 1" />
                            <Vertex pos="-2 4 -1" />
                            <Vertex pos="-2 -4 1" />
                            <Vertex pos="-2 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="90 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 90 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="92 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 92 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 2" />
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 -4 2" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="-4 4 2" />
                            <Vertex pos="-4 4 -2" />
                            <Vertex pos="-4 -4 2" />
                            <Vertex pos="-4 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="116 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 116 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="20 4 2" />
                            <Vertex pos="20 4 -2" />
                            <Vertex pos="20 -4 2" />
                            <Vertex pos="20 -4 -2" />
                            <Vertex pos="-20 4 2" />
                            <Vertex pos="-20 4 -2" />
                            <Vertex pos="-20 -4 2" />
                            <Vertex pos="-20 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -20" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -20" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -1792 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 2048 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_friction_ice" texgens="1 0 0 29696 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -1792 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="112 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 112 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 17" />
                            <Vertex pos="4 4 -17" />
                            <Vertex pos="4 -4 17" />
                            <Vertex pos="4 -4 -17" />
                            <Vertex pos="-4 4 17" />
                            <Vertex pos="-4 4 -17" />
                            <Vertex pos="-4 -4 17" />
                            <Vertex pos="-4 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 2048 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="134 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 134 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="138 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 138 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 -4 2" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="-2 4 2" />
                            <Vertex pos="-2 4 -2" />
                            <Vertex pos="-2 -4 2" />
                            <Vertex pos="-2 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="158 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 158 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 2" />
                            <Vertex pos="6 4 -2" />
                            <Vertex pos="6 -4 2" />
                            <Vertex pos="6 -4 -2" />
                            <Vertex pos="-2 4 2" />
                            <Vertex pos="-2 4 -2" />
                            <Vertex pos="-2 -4 2" />
                            <Vertex pos="-2 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="162 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 162 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -1024 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 1280 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 2560 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="5" type="999" pos="168 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 168 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 2" />
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 -4 2" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="-4 4 2" />
                            <Vertex pos="-4 4 -2" />
                            <Vertex pos="-4 -4 2" />
                            <Vertex pos="-4 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile01_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="226 0 -1" rot="1 0 0 0" scale="" transform="1 0 0 226 0 1 0 0 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 2" />
                            <Vertex pos="6 4 -2" />
                            <Vertex pos="6 -4 2" />
                            <Vertex pos="6 -4 -2" />
                            <Vertex pos="-6 4 2" />
                            <Vertex pos="-6 4 -2" />
                            <Vertex pos="-6 -4 2" />
                            <Vertex pos="-6 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile07_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="222 0 -20" rot="1 0 0 0" scale="" transform="1 0 0 222 0 1 0 0 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 17" />
                            <Vertex pos="2 4 -17" />
                            <Vertex pos="2 -4 17" />
                            <Vertex pos="2 -4 -17" />
                            <Vertex pos="-2 4 17" />
                            <Vertex pos="-2 4 -17" />
                            <Vertex pos="-2 -4 17" />
                            <Vertex pos="-2 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile07_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="15 4 3" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 4 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 2" />
                            <Vertex pos="1 2 -2" />
                            <Vertex pos="1 -2 2" />
                            <Vertex pos="1 -2 -2" />
                            <Vertex pos="-1 2 2" />
                            <Vertex pos="-1 2 -2" />
                            <Vertex pos="-1 -2 2" />
                            <Vertex pos="-1 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="21 -3 3" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -3 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 2" />
                            <Vertex pos="1 3 -2" />
                            <Vertex pos="1 -3 2" />
                            <Vertex pos="1 -3 -2" />
                            <Vertex pos="-1 3 2" />
                            <Vertex pos="-1 3 -2" />
                            <Vertex pos="-1 -3 2" />
                            <Vertex pos="-1 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="27 1 3" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 1 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="27 -4 3" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 -4 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 2" />
                            <Vertex pos="1 2 -2" />
                            <Vertex pos="1 -2 2" />
                            <Vertex pos="1 -2 -2" />
                            <Vertex pos="-1 2 2" />
                            <Vertex pos="-1 2 -2" />
                            <Vertex pos="-1 -2 2" />
                            <Vertex pos="-1 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-6 -6 -17" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -6 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 18" />
                            <Vertex pos="6 2 -20" />
                            <Vertex pos="2 -2 20" />
                            <Vertex pos="2 -2 -20" />
                            <Vertex pos="-6 2 18" />
                            <Vertex pos="-6 2 -20" />
                            <Vertex pos="-6 -2 20" />
                            <Vertex pos="-6 -2 -20" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.82843" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -16.9941" album="" material="bm_friction_grass" texgens="1 0 0 -1536 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="-6 6 -17" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 6 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 20" />
                            <Vertex pos="2 2 -20" />
                            <Vertex pos="6 -2 18" />
                            <Vertex pos="6 -2 -20" />
                            <Vertex pos="-6 2 20" />
                            <Vertex pos="-6 2 -20" />
                            <Vertex pos="-6 -2 18" />
                            <Vertex pos="-6 -2 -20" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.82843" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -16.9941" album="" material="bm_friction_grass" texgens="1 0 0 -1536 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-8 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -2 20" />
                            <Vertex pos="4 -2 -20" />
                            <Vertex pos="4 -6 20" />
                            <Vertex pos="4 -6 -20" />
                            <Vertex pos="-4 6 20" />
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="-4 -6 20" />
                            <Vertex pos="-4 -6 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -20" album="" material="bm_friction_grass" texgens="1 0 0 -2048 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-8 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 20" />
                            <Vertex pos="4 6 -20" />
                            <Vertex pos="4 2 20" />
                            <Vertex pos="4 2 -20" />
                            <Vertex pos="-4 6 20" />
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="-4 -6 20" />
                            <Vertex pos="-4 -6 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_friction_grass" texgens="1 0 0 -2048 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-16 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 20" />
                            <Vertex pos="4 6 -20" />
                            <Vertex pos="4 -6 20" />
                            <Vertex pos="4 -6 -20" />
                            <Vertex pos="-4 6 20" />
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="-4 -6 20" />
                            <Vertex pos="-4 -6 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-16 6 -15" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 6 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 18" />
                            <Vertex pos="4 2 -22" />
                            <Vertex pos="4 -2 22" />
                            <Vertex pos="4 -2 -22" />
                            <Vertex pos="-4 2 18" />
                            <Vertex pos="-4 2 -22" />
                            <Vertex pos="-4 -2 22" />
                            <Vertex pos="-4 -2 -22" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -14.1421" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-16 0 -15" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 0 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 22" />
                            <Vertex pos="4 4 -22" />
                            <Vertex pos="4 -4 22" />
                            <Vertex pos="4 -4 -22" />
                            <Vertex pos="-4 4 22" />
                            <Vertex pos="-4 4 -22" />
                            <Vertex pos="-4 -4 22" />
                            <Vertex pos="-4 -4 -22" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -22" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-16 -6 -15" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -6 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 22" />
                            <Vertex pos="4 2 -22" />
                            <Vertex pos="4 -2 18" />
                            <Vertex pos="4 -2 -22" />
                            <Vertex pos="-4 2 22" />
                            <Vertex pos="-4 2 -22" />
                            <Vertex pos="-4 -2 18" />
                            <Vertex pos="-4 -2 -22" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -14.1421" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-16 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 20" />
                            <Vertex pos="4 6 -20" />
                            <Vertex pos="4 -6 20" />
                            <Vertex pos="4 -6 -20" />
                            <Vertex pos="-4 6 20" />
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="-4 -6 20" />
                            <Vertex pos="-4 -6 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-13 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 9 18" />
                            <Vertex pos="7 9 -18" />
                            <Vertex pos="7 -9 18" />
                            <Vertex pos="7 -9 -18" />
                            <Vertex pos="-7 9 18" />
                            <Vertex pos="-7 9 -18" />
                            <Vertex pos="-7 -9 18" />
                            <Vertex pos="-7 -9 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-13 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 9 18" />
                            <Vertex pos="7 9 -18" />
                            <Vertex pos="7 -9 18" />
                            <Vertex pos="7 -9 -18" />
                            <Vertex pos="-7 9 18" />
                            <Vertex pos="-7 9 -18" />
                            <Vertex pos="-7 -9 18" />
                            <Vertex pos="-7 -9 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-29 28 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 4 18" />
                            <Vertex pos="9 4 -18" />
                            <Vertex pos="9 -4 18" />
                            <Vertex pos="9 -4 -18" />
                            <Vertex pos="-9 4 18" />
                            <Vertex pos="-9 4 -18" />
                            <Vertex pos="-9 -4 18" />
                            <Vertex pos="-9 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-29 -28 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 4 18" />
                            <Vertex pos="9 4 -18" />
                            <Vertex pos="9 -4 18" />
                            <Vertex pos="9 -4 -18" />
                            <Vertex pos="-9 4 18" />
                            <Vertex pos="-9 4 -18" />
                            <Vertex pos="-9 -4 18" />
                            <Vertex pos="-9 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-22 -36 -19" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="16 4 18" />
                            <Vertex pos="16 4 -18" />
                            <Vertex pos="8 -4 18" />
                            <Vertex pos="8 -4 -18" />
                            <Vertex pos="-16 4 18" />
                            <Vertex pos="-16 4 -18" />
                            <Vertex pos="-12 -4 18" />
                            <Vertex pos="-12 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -8.48528" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -12.522" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-22 36 -19" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 4 18" />
                            <Vertex pos="8 4 -18" />
                            <Vertex pos="16 -4 18" />
                            <Vertex pos="16 -4 -18" />
                            <Vertex pos="-12 4 18" />
                            <Vertex pos="-12 4 -18" />
                            <Vertex pos="-16 -4 18" />
                            <Vertex pos="-16 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -8.48528" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -12.522" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="-29 20 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 4 18" />
                            <Vertex pos="9 4 -54" />
                            <Vertex pos="9 -4 14" />
                            <Vertex pos="9 -4 -54" />
                            <Vertex pos="-9 4 18" />
                            <Vertex pos="-9 4 -54" />
                            <Vertex pos="-17 -4 14" />
                            <Vertex pos="-17 -4 -54" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -9.19239" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -14.3108" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 -5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="-29 -20 -19" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 4 14" />
                            <Vertex pos="9 4 -54" />
                            <Vertex pos="9 -4 18" />
                            <Vertex pos="9 -4 -54" />
                            <Vertex pos="-17 4 14" />
                            <Vertex pos="-17 4 -54" />
                            <Vertex pos="-9 -4 18" />
                            <Vertex pos="-9 -4 -54" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -9.19239" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -14.3108" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="-29 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 16 16" />
                            <Vertex pos="9 16 -52" />
                            <Vertex pos="9 -16 16" />
                            <Vertex pos="9 -16 -52" />
                            <Vertex pos="-17 16 16" />
                            <Vertex pos="-17 16 -52" />
                            <Vertex pos="-17 -16 16" />
                            <Vertex pos="-17 -16 -52" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -17" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 -7424 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="6 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 8" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 8" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 14" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -10.6716" album="" material="bm_friction_grass" texgens="1 0 0 1536 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="6 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 8" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 8" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 14" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -10.6716" album="" material="bm_friction_grass" texgens="1 0 0 1536 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="234 -6 -17" rot="1 0 0 0" scale="" transform="1 0 0 234 0 1 0 -6 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 18" />
                            <Vertex pos="6 2 -20" />
                            <Vertex pos="6 -2 20" />
                            <Vertex pos="6 -2 -20" />
                            <Vertex pos="-6.00002 2 18" />
                            <Vertex pos="-6.00002 2 -20" />
                            <Vertex pos="-2.00002 -2 20" />
                            <Vertex pos="-2.00002 -2 -20" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.82844" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -16.9941" album="" material="bm_friction_grass" texgens="1 0 0 59904 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="234 6 -17" rot="1 0 0 0" scale="" transform="1 0 0 234 0 1 0 6 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 20" />
                            <Vertex pos="6 2 -20" />
                            <Vertex pos="6 -2 18" />
                            <Vertex pos="6 -2 -20" />
                            <Vertex pos="-1.99998 2 20" />
                            <Vertex pos="-1.99998 2 -20" />
                            <Vertex pos="-5.99998 -2 18" />
                            <Vertex pos="-5.99998 -2 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.82841" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -16.9941" album="" material="bm_friction_grass" texgens="1 0 0 59904 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="236 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 236 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 5.99999 20" />
                            <Vertex pos="4 5.99999 -20" />
                            <Vertex pos="4 -5.99999 20" />
                            <Vertex pos="4 -5.99999 -20" />
                            <Vertex pos="-4 -2.00001 20" />
                            <Vertex pos="-4 -2.00001 -20" />
                            <Vertex pos="-4 -5.99999 20" />
                            <Vertex pos="-4 -5.99999 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 767.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -511.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.99999" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_friction_grass" texgens="1 0 0 60416 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -511.998 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="236 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 236 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 5.99999 20" />
                            <Vertex pos="4 5.99999 -20" />
                            <Vertex pos="4 -5.99999 20" />
                            <Vertex pos="4 -5.99999 -20" />
                            <Vertex pos="-4 5.99999 20" />
                            <Vertex pos="-4 5.99999 -20" />
                            <Vertex pos="-4 2.00001 20" />
                            <Vertex pos="-4 2.00001 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -255.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 511.998 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5.99999" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_friction_grass" texgens="1 0 0 60416 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 511.998 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="244 14 -17" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 20" />
                            <Vertex pos="4 6 -20" />
                            <Vertex pos="4 -6 20" />
                            <Vertex pos="4 -6 -20" />
                            <Vertex pos="-4 6 20" />
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="-4 -6 20" />
                            <Vertex pos="-4 -6 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="244 6 -15" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 6 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 18" />
                            <Vertex pos="4 2 -22" />
                            <Vertex pos="4 -2 22" />
                            <Vertex pos="4 -2 -22" />
                            <Vertex pos="-4 2 18" />
                            <Vertex pos="-4 2 -22" />
                            <Vertex pos="-4 -2 22" />
                            <Vertex pos="-4 -2 -22" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -14.1421" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="244 0 -15" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 0 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 22" />
                            <Vertex pos="4 4 -22" />
                            <Vertex pos="4 -4 22" />
                            <Vertex pos="4 -4 -22" />
                            <Vertex pos="-4 4 22" />
                            <Vertex pos="-4 4 -22" />
                            <Vertex pos="-4 -4 22" />
                            <Vertex pos="-4 -4 -22" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -22" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="244 -6 -15" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 -6 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 22" />
                            <Vertex pos="4 2 -22" />
                            <Vertex pos="4 -2 18" />
                            <Vertex pos="4 -2 -22" />
                            <Vertex pos="-4 2 22" />
                            <Vertex pos="-4 2 -22" />
                            <Vertex pos="-4 -2 18" />
                            <Vertex pos="-4 -2 -22" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -14.1421" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="244 -14 -17" rot="1 0 0 0" scale="" transform="1 0 0 244 0 1 0 -14 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 20" />
                            <Vertex pos="4 6 -20" />
                            <Vertex pos="4 -6 20" />
                            <Vertex pos="4 -6 -20" />
                            <Vertex pos="-4 6 20" />
                            <Vertex pos="-4 6 -20" />
                            <Vertex pos="-4 -6 20" />
                            <Vertex pos="-4 -6 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_friction_grass" texgens="1 0 0 62464 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="241 -23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 -23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 9 18" />
                            <Vertex pos="7 9 -18" />
                            <Vertex pos="7 -9 18" />
                            <Vertex pos="7 -9 -18" />
                            <Vertex pos="-7 9 18" />
                            <Vertex pos="-7 9 -18" />
                            <Vertex pos="-7 -9 18" />
                            <Vertex pos="-7 -9 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="241 23 -19" rot="1 0 0 0" scale="" transform="1 0 0 241 0 1 0 23 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 9 18" />
                            <Vertex pos="7 9 -18" />
                            <Vertex pos="7 -9 18" />
                            <Vertex pos="7 -9 -18" />
                            <Vertex pos="-7 9 18" />
                            <Vertex pos="-7 9 -18" />
                            <Vertex pos="-7 -9 18" />
                            <Vertex pos="-7 -9 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 61696 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="250 -36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 -36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="16 4 18" />
                            <Vertex pos="16 4 -18" />
                            <Vertex pos="12 -4 18" />
                            <Vertex pos="12 -4 -18" />
                            <Vertex pos="-16 4 18" />
                            <Vertex pos="-16 4 -18" />
                            <Vertex pos="-8.00003 -4 18" />
                            <Vertex pos="-8.00003 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -12.522" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707108 -0.707106 0 -8.48531" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="250 36 -19" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 36 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 18" />
                            <Vertex pos="12 4 -18" />
                            <Vertex pos="16 -4 18" />
                            <Vertex pos="16 -4 -18" />
                            <Vertex pos="-8.00003 4 18" />
                            <Vertex pos="-8.00003 4 -18" />
                            <Vertex pos="-16 -4 18" />
                            <Vertex pos="-16 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -12.522" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707108 0.707106 0 -8.48531" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="257 28 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 4 18" />
                            <Vertex pos="9 4 -18" />
                            <Vertex pos="9 -4 18" />
                            <Vertex pos="9 -4 -18" />
                            <Vertex pos="-9 4 18" />
                            <Vertex pos="-9 4 -18" />
                            <Vertex pos="-9 -4 18" />
                            <Vertex pos="-9 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="257 -28 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 -28 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 4 18" />
                            <Vertex pos="9 4 -18" />
                            <Vertex pos="9 -4 18" />
                            <Vertex pos="9 -4 -18" />
                            <Vertex pos="-9 4 18" />
                            <Vertex pos="-9 4 -18" />
                            <Vertex pos="-9 -4 18" />
                            <Vertex pos="-9 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="257 20 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 4 18" />
                            <Vertex pos="9 4 -54" />
                            <Vertex pos="17 -4 14" />
                            <Vertex pos="17 -4 -54" />
                            <Vertex pos="-9 4 18" />
                            <Vertex pos="-9 4 -54" />
                            <Vertex pos="-9 -4 14" />
                            <Vertex pos="-9 -4 -54" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -9.19239" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -14.3108" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 -5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="257 -20 -19" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 -20 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="17 4 14" />
                            <Vertex pos="17 4 -54" />
                            <Vertex pos="9 -4 18" />
                            <Vertex pos="9 -4 -54" />
                            <Vertex pos="-9 4 14" />
                            <Vertex pos="-9 4 -54" />
                            <Vertex pos="-9 -4 18" />
                            <Vertex pos="-9 -4 -54" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -9.19239" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -14.3108" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -54" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="257 0 -21" rot="1 0 0 0" scale="" transform="1 0 0 257 0 1 0 0 0 0 1 -21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="17 16 16" />
                            <Vertex pos="17 16 -52" />
                            <Vertex pos="17 -16 16" />
                            <Vertex pos="17 -16 -52" />
                            <Vertex pos="-9 16 16" />
                            <Vertex pos="-9 16 -52" />
                            <Vertex pos="-9 -16 16" />
                            <Vertex pos="-9 -16 -52" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -17" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_friction_grass" texgens="1 0 0 65792 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="222 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 222 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 14" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 14" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 8" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 8" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -10.6716" album="" material="bm_friction_grass" texgens="1 0 0 56832 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="222 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 222 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 14" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 14" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 8" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 8" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -10.6716" album="" material="bm_friction_grass" texgens="1 0 0 56832 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-8 0 -18" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 0 0 0 1 -18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 19" />
                            <Vertex pos="4 4 -19" />
                            <Vertex pos="4 -4 19" />
                            <Vertex pos="4 -4 -19" />
                            <Vertex pos="-4 4 19" />
                            <Vertex pos="-4 4 -19" />
                            <Vertex pos="-4 -4 19" />
                            <Vertex pos="-4 -4 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile07_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="30 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 13" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="12 -4 13" />
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="-12 4 9" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 -4 9" />
                            <Vertex pos="-12 -4 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.164399 0 0.986394 -10.8503" album="" material="bm_friction_grass" texgens="1 0 0 7680 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="30 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 13" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="12 -4 13" />
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="-12 4 9" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 -4 9" />
                            <Vertex pos="-12 -4 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.164399 0 0.986394 -10.8503" album="" material="bm_friction_grass" texgens="1 0 0 7680 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="54 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 11" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="12 -4 11" />
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="-12 4 13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 -4 13" />
                            <Vertex pos="-12 -4 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.0830455 0 0.996546 -11.9585" album="" material="bm_friction_grass" texgens="1 0 0 13824 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="54 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 11" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="12 -4 11" />
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="-12 4 13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 -4 13" />
                            <Vertex pos="-12 -4 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.0830455 0 0.996546 -11.9585" album="" material="bm_friction_grass" texgens="1 0 0 13824 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="78 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 14" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 14" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 10" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 10" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.164399 0 0.986394 -11.8367" album="" material="bm_friction_grass" texgens="1 0 0 19968 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="78 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 14" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 14" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 10" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 10" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.164399 0 0.986394 -11.8367" album="" material="bm_friction_grass" texgens="1 0 0 19968 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="102 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 102 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 8" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 8" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 14" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -10.6716" album="" material="bm_friction_grass" texgens="1 0 0 26112 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="102 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 102 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 8" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 8" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 14" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -10.6716" album="" material="bm_friction_grass" texgens="1 0 0 26112 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="126 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 126 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 14" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 14" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 8" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 8" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -10.6716" album="" material="bm_friction_grass" texgens="1 0 0 32256 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="126 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 126 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 14" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 14" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 8" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 8" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -10.6716" album="" material="bm_friction_grass" texgens="1 0 0 32256 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="150 -28 -23" rot="1 0 0 0" scale="" transform="1 0 0 150 0 1 0 -28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 10" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 10" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 14" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 -11.8367" album="" material="bm_friction_grass" texgens="1 0 0 38400 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="150 28 -23" rot="1 0 0 0" scale="" transform="1 0 0 150 0 1 0 28 0 0 1 -23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 10" />
                            <Vertex pos="12 4 -14" />
                            <Vertex pos="12 -4 10" />
                            <Vertex pos="12 -4 -14" />
                            <Vertex pos="-12 4 14" />
                            <Vertex pos="-12 4 -14" />
                            <Vertex pos="-12 -4 14" />
                            <Vertex pos="-12 -4 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 -11.8367" album="" material="bm_friction_grass" texgens="1 0 0 38400 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="174 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 174 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 13" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="12 -4 13" />
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="-12 4 11" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 -4 11" />
                            <Vertex pos="-12 -4 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.0830455 0 0.996546 -11.9585" album="" material="bm_friction_grass" texgens="1 0 0 44544 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="174 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 174 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 13" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="12 -4 13" />
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="-12 4 11" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 -4 11" />
                            <Vertex pos="-12 -4 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.0830455 0 0.996546 -11.9585" album="" material="bm_friction_grass" texgens="1 0 0 44544 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="198 -28 -24" rot="1 0 0 0" scale="" transform="1 0 0 198 0 1 0 -28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 9" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="12 -4 9" />
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="-12 4 13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 -4 13" />
                            <Vertex pos="-12 -4 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 -10.8503" album="" material="bm_friction_grass" texgens="1 0 0 50688 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="198 28 -24" rot="1 0 0 0" scale="" transform="1 0 0 198 0 1 0 28 0 0 1 -24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 9" />
                            <Vertex pos="12 4 -13" />
                            <Vertex pos="12 -4 9" />
                            <Vertex pos="12 -4 -13" />
                            <Vertex pos="-12 4 13" />
                            <Vertex pos="-12 4 -13" />
                            <Vertex pos="-12 -4 13" />
                            <Vertex pos="-12 -4 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 -10.8503" album="" material="bm_friction_grass" texgens="1 0 0 50688 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="38 0 -55" rot="1 0 0 0" scale="" transform="1 0 0 38 0 1 0 0 0 0 1 -55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="76 32 18" />
                            <Vertex pos="76 32 -18" />
                            <Vertex pos="76 -32 18" />
                            <Vertex pos="76 -32 -18" />
                            <Vertex pos="-76 32 18" />
                            <Vertex pos="-76 32 -18" />
                            <Vertex pos="-76 -32 18" />
                            <Vertex pos="-76 -32 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -76" album="" material="bm_grid_blank4" texgens="0 1 0 4352 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -76" album="" material="bm_grid_blank4" texgens="0 -1 0 -4096 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -32" album="" material="bm_grid_blank4" texgens="-1 0 0 -8448 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -32" album="" material="bm_grid_blank4" texgens="1 0 0 8704 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_grid_blank_water" texgens="1 0 0 -9472 0 -1 0 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -8448 0 -1 0 -4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="-22 -36 -55" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -36 0 0 1 -55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="16 4 18" />
                            <Vertex pos="16 4 -18" />
                            <Vertex pos="8 -4 18" />
                            <Vertex pos="8 -4 -18" />
                            <Vertex pos="-16 4 18" />
                            <Vertex pos="-16 4 -18" />
                            <Vertex pos="-12 -4 18" />
                            <Vertex pos="-12 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -8.48528" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -12.522" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-22 36 -55" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 36 0 0 1 -55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 4 18" />
                            <Vertex pos="8 4 -18" />
                            <Vertex pos="16 -4 18" />
                            <Vertex pos="16 -4 -18" />
                            <Vertex pos="-12 4 18" />
                            <Vertex pos="-12 4 -18" />
                            <Vertex pos="-16 -4 18" />
                            <Vertex pos="-16 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -8.48528" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -12.522" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 -5632 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="190 0 -55" rot="1 0 0 0" scale="" transform="1 0 0 190 0 1 0 0 0 0 1 -55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="76 32 18" />
                            <Vertex pos="76 32 -18" />
                            <Vertex pos="76 -32 18" />
                            <Vertex pos="76 -32 -18" />
                            <Vertex pos="-76 32 18" />
                            <Vertex pos="-76 32 -18" />
                            <Vertex pos="-76 -32 18" />
                            <Vertex pos="-76 -32 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -76" album="" material="bm_grid_blank4" texgens="0 1 0 4352 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -76" album="" material="bm_grid_blank4" texgens="0 -1 0 -4096 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -32" album="" material="bm_grid_blank4" texgens="-1 0 0 -8448 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -32" album="" material="bm_grid_blank4" texgens="1 0 0 8704 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_grid_blank_water" texgens="1 0 0 -9472 0 -1 0 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -8448 0 -1 0 -4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="250 -36 -55" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 -36 0 0 1 -55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="16 4 18" />
                            <Vertex pos="16 4 -18" />
                            <Vertex pos="12 -4 18" />
                            <Vertex pos="12 -4 -18" />
                            <Vertex pos="-16 4 18" />
                            <Vertex pos="-16 4 -18" />
                            <Vertex pos="-8.00003 -4 18" />
                            <Vertex pos="-8.00003 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -12.522" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707108 -0.707106 0 -8.48531" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="250 36 -55" rot="1 0 0 0" scale="" transform="1 0 0 250 0 1 0 36 0 0 1 -55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 4 18" />
                            <Vertex pos="12 4 -18" />
                            <Vertex pos="16 -4 18" />
                            <Vertex pos="16 -4 -18" />
                            <Vertex pos="-8.00003 4 18" />
                            <Vertex pos="-8.00003 4 -18" />
                            <Vertex pos="-16 -4 18" />
                            <Vertex pos="-16 -4 -18" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -12.522" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707108 0.707106 0 -8.48531" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_friction_grass" texgens="1 0 0 64000 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="0 0 -26" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 11" />
                            <Vertex pos="4 4 -11" />
                            <Vertex pos="4 -4 11" />
                            <Vertex pos="4 -4 -11" />
                            <Vertex pos="-4 4 11" />
                            <Vertex pos="-4 4 -11" />
                            <Vertex pos="-4 -4 11" />
                            <Vertex pos="-4 -4 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_friction_grass" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="228 0 -26" rot="1 0 0 0" scale="" transform="1 0 0 228 0 1 0 0 0 0 1 -26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 11" />
                            <Vertex pos="4 4 -11" />
                            <Vertex pos="4 -4 11" />
                            <Vertex pos="4 -4 -11" />
                            <Vertex pos="-4 4 11" />
                            <Vertex pos="-4 4 -11" />
                            <Vertex pos="-4 -4 11" />
                            <Vertex pos="-4 -4 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1280 0 0 -1 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_friction_grass" texgens="1 0 0 58368 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="236 0 -18" rot="1 0 0 0" scale="" transform="1 0 0 236 0 1 0 0 0 0 1 -18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 19" />
                            <Vertex pos="4 4 -19" />
                            <Vertex pos="4 -4 19" />
                            <Vertex pos="4 -4 -19" />
                            <Vertex pos="-4 4 19" />
                            <Vertex pos="-4 4 -19" />
                            <Vertex pos="-4 -4 19" />
                            <Vertex pos="-4 -4 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile07_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="381" owner="0" type="0" pos="3 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="382" owner="0" type="0" pos="3 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="383" owner="0" type="0" pos="36 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="384" owner="0" type="0" pos="36 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="385" owner="0" type="0" pos="45 -4.25 2.75" rot="1 0 0 0" scale="" transform="1 0 0 45 0 1 0 -4.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="386" owner="0" type="0" pos="45 4.25 2.75" rot="1 0 0 0" scale="" transform="1 0 0 45 0 1 0 4.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="387" owner="0" type="0" pos="55 -4.25 4.75" rot="1 0 0 0" scale="" transform="1 0 0 55 0 1 0 -4.25 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="388" owner="0" type="0" pos="55 4.25 4.75" rot="1 0 0 0" scale="" transform="1 0 0 55 0 1 0 4.25 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="389" owner="0" type="0" pos="49 -4.25 3.75" rot="1 0 0 0" scale="" transform="1 0 0 49 0 1 0 -4.25 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1.25" />
                            <Vertex pos="1 0.25 0.75" />
                            <Vertex pos="1 -0.25 1.25" />
                            <Vertex pos="1 -0.25 0.75" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 0.25 -1.25" />
                            <Vertex pos="-1 -0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 1 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="390" owner="0" type="0" pos="49 4.25 3.75" rot="1 0 0 0" scale="" transform="1 0 0 49 0 1 0 4.25 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1.25" />
                            <Vertex pos="1 0.25 0.75" />
                            <Vertex pos="1 -0.25 1.25" />
                            <Vertex pos="1 -0.25 0.75" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 0.25 -1.25" />
                            <Vertex pos="-1 -0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 1 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="391" owner="0" type="0" pos="41 -4.25 1.75" rot="1 0 0 0" scale="" transform="1 0 0 41 0 1 0 -4.25 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1.25" />
                            <Vertex pos="1 0.25 0.75" />
                            <Vertex pos="1 -0.25 1.25" />
                            <Vertex pos="1 -0.25 0.75" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 0.25 -1.25" />
                            <Vertex pos="-1 -0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 1 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="392" owner="0" type="0" pos="41 4.25 1.75" rot="1 0 0 0" scale="" transform="1 0 0 41 0 1 0 4.25 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 1.25" />
                            <Vertex pos="1 0.25 0.75" />
                            <Vertex pos="1 -0.25 1.25" />
                            <Vertex pos="1 -0.25 0.75" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 0.25 -1.25" />
                            <Vertex pos="-1 -0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 1 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="393" owner="0" type="0" pos="112 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 112 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="28 0.25 0.25" />
                            <Vertex pos="28 0.25 -0.25" />
                            <Vertex pos="28 -0.25 0.25" />
                            <Vertex pos="28 -0.25 -0.25" />
                            <Vertex pos="-28 0.25 0.25" />
                            <Vertex pos="-28 0.25 -0.25" />
                            <Vertex pos="-28 -0.25 0.25" />
                            <Vertex pos="-28 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -28" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -28" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5120 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5248 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5248 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5120 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="394" owner="0" type="0" pos="112 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 112 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="28 0.25 0.25" />
                            <Vertex pos="28 0.25 -0.25" />
                            <Vertex pos="28 -0.25 0.25" />
                            <Vertex pos="28 -0.25 -0.25" />
                            <Vertex pos="-28 0.25 0.25" />
                            <Vertex pos="-28 0.25 -0.25" />
                            <Vertex pos="-28 -0.25 0.25" />
                            <Vertex pos="-28 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -28" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -28" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5120 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5248 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 5248 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -5120 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="395" owner="0" type="0" pos="60.25 -1 4.75" rot="1 0 0 0" scale="" transform="1 0 0 60.25 0 1 0 -1 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.25" />
                            <Vertex pos="0.25 0.5 -0.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 0.25" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="396" owner="0" type="0" pos="60.25 3.5 4.75" rot="1 0 0 0" scale="" transform="1 0 0 60.25 0 1 0 3.5 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="397" owner="0" type="0" pos="83.75 1 0.75" rot="1 0 0 0" scale="" transform="1 0 0 83.75 0 1 0 1 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.25" />
                            <Vertex pos="0.25 0.5 -0.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 0.25" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 -0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="398" owner="0" type="0" pos="83.75 -3.5 0.75" rot="1 0 0 0" scale="" transform="1 0 0 83.75 0 1 0 -3.5 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="399" owner="1" type="999" pos="20 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="400" owner="1" type="999" pos="20 1.75 0.75" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 1.75 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="401" owner="0" type="0" pos="158 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 158 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="402" owner="0" type="0" pos="158 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 158 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="403" owner="0" type="0" pos="140.125 0 0.75" rot="1 0 0 0" scale="" transform="1 0 0 140.125 0 1 0 0 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4.5 0.25" />
                            <Vertex pos="0.125 4.5 -0.25" />
                            <Vertex pos="0.125 -4.5 0.25" />
                            <Vertex pos="0.125 -4.5 -0.25" />
                            <Vertex pos="-0.125 4.5 0.25" />
                            <Vertex pos="-0.125 4.5 -0.25" />
                            <Vertex pos="-0.125 -4.5 0.25" />
                            <Vertex pos="-0.125 -4.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_trim" texgens="-1 0 0 2016 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_trim" texgens="1 0 0 -1888 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -1888 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 2016 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="404" owner="0" type="0" pos="155.875 0 0.75" rot="1 0 0 0" scale="" transform="1 0 0 155.875 0 1 0 0 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4.5 0.25" />
                            <Vertex pos="0.125 4.5 -0.25" />
                            <Vertex pos="0.125 -4.5 0.25" />
                            <Vertex pos="0.125 -4.5 -0.25" />
                            <Vertex pos="-0.125 4.5 0.25" />
                            <Vertex pos="-0.125 4.5 -0.25" />
                            <Vertex pos="-0.125 -4.5 0.25" />
                            <Vertex pos="-0.125 -4.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_trim" texgens="-1 0 0 1952 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_trim" texgens="1 0 0 -1824 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -1824 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 1952 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="405" owner="0" type="0" pos="225 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 225 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="406" owner="0" type="0" pos="225 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 225 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="407" owner="5" type="999" pos="168 4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 168 0 1 0 4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="408" owner="5" type="999" pos="168 -4.25 0.75" rot="1 0 0 0" scale="" transform="1 0 0 168 0 1 0 -4.25 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="409" owner="1" type="999" pos="28 3 0" rot="1 0 0 0" scale="" transform="1 0 0 28 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-12 1 1" />
                            <Vertex pos="-12 1 -1" />
                            <Vertex pos="-12 -1 1" />
                            <Vertex pos="-12 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile08_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="410" owner="1" type="999" pos="34 3 0" rot="1 0 0 0" scale="" transform="1 0 0 34 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-12 1 1" />
                            <Vertex pos="-12 1 -1" />
                            <Vertex pos="-12 -1 1" />
                            <Vertex pos="-12 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile08_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="411" owner="1" type="999" pos="40 3 0" rot="1 0 0 0" scale="" transform="1 0 0 40 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-12 1 1" />
                            <Vertex pos="-12 1 -1" />
                            <Vertex pos="-12 -1 1" />
                            <Vertex pos="-12 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile08_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="412" owner="1" type="999" pos="36 3 0" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-10 1 1" />
                            <Vertex pos="-10 1 -1" />
                            <Vertex pos="-10 -1 1" />
                            <Vertex pos="-10 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile01_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="413" owner="1" type="999" pos="30 3 0" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-10 1 1" />
                            <Vertex pos="-10 1 -1" />
                            <Vertex pos="-10 -1 1" />
                            <Vertex pos="-10 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile01_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="414" owner="1" type="999" pos="24 3 0" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 1 1" />
                            <Vertex pos="-8 1 -1" />
                            <Vertex pos="-8 -1 1" />
                            <Vertex pos="-8 -1 -1" />
                            <Vertex pos="-10 1 1" />
                            <Vertex pos="-10 1 -1" />
                            <Vertex pos="-10 -1 1" />
                            <Vertex pos="-10 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 8" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile01_C" texgens="1 0 0 2048 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="416" owner="0" type="0" pos="150.824 -0.25955 1.25" rot="0 0 1.00001 0.17453" scale="" transform="0.984808 0.173648 0 150.824 -0.173648 0.984808 0 -0.25955 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1.75 -0.125" />
                            <Vertex pos="6 1.75 -0.25" />
                            <Vertex pos="6 -0.25 -0.125" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-12 1.75 -0.125" />
                            <Vertex pos="-12 1.75 -0.25" />
                            <Vertex pos="-12 -0.25 -0.125" />
                            <Vertex pos="-12 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_wood" texgens="0 1 0 6639.28 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="Blasted" material="bm_wood" texgens="0 -1 0 -6639.28 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.75" album="Blasted" material="bm_wood" texgens="-1 0 0 -38035.9 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 38035.9 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.125" album="Blasted" material="bm_wood" texgens="1 0 0 38035.9 0 -1 0 -6639.28 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -38035.9 0 -1 0 -6639.28 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="418" owner="0" type="0" pos="135.232 -3.22689 1.15076" rot="0.00867338 0.110207 -0.993871 0.158042" scale="" transform="0.987538 -0.156411 -0.0174524 135.232 0.156434 0.987688 0 -3.22689 0.0172375 -0.00273016 0.999848 1.15076 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="15 1.75 -0.125" />
                            <Vertex pos="15 1.75 -0.25" />
                            <Vertex pos="15 -0.25 -0.125" />
                            <Vertex pos="15 -0.25 -0.25" />
                            <Vertex pos="4 1.75 -0.125" />
                            <Vertex pos="4 1.75 -0.25" />
                            <Vertex pos="4 -0.25 -0.125" />
                            <Vertex pos="4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -15" album="Blasted" material="bm_wood" texgens="0 1 0 -6231.55 0 0 -1 309.641 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4" album="Blasted" material="bm_wood" texgens="0 -1 0 6231.55 0 0 -1 309.641 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.75" album="Blasted" material="bm_wood" texgens="-1 0 0 -34063.8 0 0 -1 309.641 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 34063.8 0 0 -1 309.641 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.125" album="Blasted" material="bm_wood" texgens="1 0 0 34063.8 0 -1 0 6231.55 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -34063.8 0 -1 0 6231.55 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="419" owner="0" type="0" pos="175.5 4.25 1.25" rot="1 0 0 0" scale="" transform="1 0 0 175.5 0 1 0 4.25 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.75 0 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="5.75 -8.5 0.25" />
                            <Vertex pos="6 -8.75 -0.25" />
                            <Vertex pos="4.75 0 0.25" />
                            <Vertex pos="4.5 0.25 -0.25" />
                            <Vertex pos="4.75 -8.5 0.25" />
                            <Vertex pos="4.5 -8.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0 0.447214 -5.25476" album="Blasted" material="bm_stripe_caution1" texgens="0 1 -1 -32 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0 0.447214 4.13673" album="Blasted" material="bm_stripe_caution1" texgens="0 -1 -1 -1248 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.894427 0.447214 -0.111803" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 1 832 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.894427 0.447214 -7.71443" album="Blasted" material="bm_stripe_caution1" texgens="1 0 1 -512 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="1 1 0 480 0 -1 0 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="-1 1 0 1920 0 -1 0 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="420" owner="0" type="0" pos="182 4.25 1.25" rot="1 0 0 0" scale="" transform="1 0 0 182 0 1 0 4.25 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.75 0 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="5.75 -5 0.25" />
                            <Vertex pos="6 -5.25 -0.25" />
                            <Vertex pos="4.75 0 0.25" />
                            <Vertex pos="4.5 0.25 -0.25" />
                            <Vertex pos="4.75 -5 0.25" />
                            <Vertex pos="4.5 -5.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0 0.447214 -5.25476" album="Blasted" material="bm_stripe_caution1" texgens="0 1 -1 -32 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0 0.447214 4.13673" album="Blasted" material="bm_stripe_caution1" texgens="0 -1 -1 -1248 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.894427 0.447214 -0.111803" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 1 832 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.894427 0.447214 -4.58394" album="Blasted" material="bm_stripe_caution1" texgens="1 0 1 -576 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="1 1 0 480 0 -1 0 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_stripe_caution1" texgens="-1 1 0 1408 0 -1 0 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="421" owner="0" type="0" pos="195 3 3" rot="1 0 0 0" scale="" transform="1 0 0 195 0 1 0 3 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 2" />
                            <Vertex pos="1 3 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 3 2" />
                            <Vertex pos="-1 3 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="422" owner="0" type="0" pos="195 -1 3" rot="1 0 0 0" scale="" transform="1 0 0 195 0 1 0 -1 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -5 2" />
                            <Vertex pos="1 -5 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -5 2" />
                            <Vertex pos="-1 -5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="423" owner="0" type="0" pos="189.25 1.75 1.25" rot="1 0 0 0" scale="" transform="1 0 0 189.25 0 1 0 1.75 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -1.75 0.25" />
                            <Vertex pos="6 -1.75 -0.25" />
                            <Vertex pos="5.5 0.25 0.25" />
                            <Vertex pos="5.5 0.25 -0.25" />
                            <Vertex pos="5.5 -1.75 0.25" />
                            <Vertex pos="5.5 -1.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_beam" texgens="0 1 0 128 0 0 -1 128 90 0.0625 0.0625" texRot="90" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 5.5" album="Blasted" material="bm_beam" texgens="0 -1 0 128 0 0 -1 128 90 0.0625 0.0625" texRot="90" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.75" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 -2816 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 3072 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="424" owner="0" type="0" pos="205 -3 3" rot="1 0 0 0" scale="" transform="1 0 0 205 0 1 0 -3 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -3 2" />
                            <Vertex pos="1 -3 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -3 2" />
                            <Vertex pos="-1 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="425" owner="0" type="0" pos="205 3 3" rot="1 0 0 0" scale="" transform="1 0 0 205 0 1 0 3 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 2" />
                            <Vertex pos="1 3 -2" />
                            <Vertex pos="1 -3 2" />
                            <Vertex pos="1 -3 -2" />
                            <Vertex pos="-1 3 2" />
                            <Vertex pos="-1 3 -2" />
                            <Vertex pos="-1 -3 2" />
                            <Vertex pos="-1 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="426" owner="0" type="0" pos="199.25 -0.25 1.25" rot="1 0 0 0" scale="" transform="1 0 0 199.25 0 1 0 -0.25 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -1.75 0.25" />
                            <Vertex pos="6 -1.75 -0.25" />
                            <Vertex pos="5.5 0.25 0.25" />
                            <Vertex pos="5.5 0.25 -0.25" />
                            <Vertex pos="5.5 -1.75 0.25" />
                            <Vertex pos="5.5 -1.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_beam" texgens="0 1 0 128 0 0 -1 128 90 0.0625 0.0625" texRot="90" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 5.5" album="Blasted" material="bm_beam" texgens="0 -1 0 128 0 0 -1 128 90 0.0625 0.0625" texRot="90" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.75" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 -2816 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 3072 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="427" owner="0" type="0" pos="118.25 1 1.25" rot="1 0 0 0" scale="" transform="1 0 0 118.25 0 1 0 1 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.5 0.75" />
                            <Vertex pos="0.75 0.5 0.25" />
                            <Vertex pos="0.75 -2.5 0.75" />
                            <Vertex pos="0.75 -2.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 1.5 -0.75" />
                            <Vertex pos="-0.25 -3.5 -0.25" />
                            <Vertex pos="-0.25 -3.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0.883883" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.2981" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0" album="Blasted" material="bm_friction_ice" texgens="1 0 0 30272 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.353553" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="428" owner="0" type="0" pos="119.25 1 2.25" rot="1 0 0 0" scale="" transform="1 0 0 119.25 0 1 0 1 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 1.5 -1.25" />
                            <Vertex pos="0.75 1.5 -1.75" />
                            <Vertex pos="0.75 -3.5 -1.25" />
                            <Vertex pos="0.75 -3.5 -1.75" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 -0.75" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.94454" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 0.353553" album="Blasted" material="bm_friction_ice" texgens="1 0 0 30528 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.707107" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="429" owner="0" type="0" pos="118.75 2 1.75" rot="1 0 0 0" scale="" transform="1 0 0 118.75 0 1 0 2 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.5 -0.75" />
                            <Vertex pos="1.25 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.75 0.5 -0.75" />
                            <Vertex pos="-0.75 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 0.176777" album="Blasted" material="bm_friction_ice" texgens="1 0 0 30400 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="430" owner="0" type="0" pos="118.25 0 1.75" rot="1 0 0 0" scale="" transform="1 0 0 118.25 0 1 0 0 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 -1.5 0.25" />
                            <Vertex pos="0.75 -1.5 -0.25" />
                            <Vertex pos="1.75 -2.5 -0.75" />
                            <Vertex pos="1.75 -2.5 -1.25" />
                            <Vertex pos="0.75 -1.5 0.25" />
                            <Vertex pos="0.75 -1.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 -0.75" />
                            <Vertex pos="-0.25 -2.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 0.53033" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 1.59099" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -1.23744" album="Blasted" material="bm_friction_ice" texgens="1 0 0 30272 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 0.883883" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="431" owner="0" type="0" pos="125.25 2 1.25" rot="1 0 0 0" scale="" transform="1 0 0 125.25 0 1 0 2 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.5 0.75" />
                            <Vertex pos="0.75 0.5 0.25" />
                            <Vertex pos="0.75 -1.5 0.75" />
                            <Vertex pos="0.75 -1.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 1.5 -0.75" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0.883883" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32064 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.353553" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="432" owner="0" type="0" pos="126.25 2 2.25" rot="1 0 0 0" scale="" transform="1 0 0 126.25 0 1 0 2 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 1.5 -1.25" />
                            <Vertex pos="0.75 1.5 -1.75" />
                            <Vertex pos="0.75 -2.5 -1.25" />
                            <Vertex pos="0.75 -2.5 -1.75" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 -0.75" />
                            <Vertex pos="-0.25 -1.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.23744" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 0.353553" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32320 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.707107" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="433" owner="0" type="0" pos="125.75 3 1.75" rot="1 0 0 0" scale="" transform="1 0 0 125.75 0 1 0 3 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.5 -0.75" />
                            <Vertex pos="1.25 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.75 0.5 -0.75" />
                            <Vertex pos="-0.75 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 0.176777" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32192 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="434" owner="0" type="0" pos="125.25 1 1.75" rot="1 0 0 0" scale="" transform="1 0 0 125.25 0 1 0 1 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 -0.5 0.25" />
                            <Vertex pos="0.75 -0.5 -0.25" />
                            <Vertex pos="1.75 -1.5 -0.75" />
                            <Vertex pos="1.75 -1.5 -1.25" />
                            <Vertex pos="0.75 -0.5 0.25" />
                            <Vertex pos="0.75 -0.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 -0.75" />
                            <Vertex pos="-0.25 -1.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 0.883883" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.53033" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32064 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 0.176777" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="435" owner="0" type="0" pos="128.75 -1 1.25" rot="1 0 0 0" scale="" transform="1 0 0 128.75 0 1 0 -1 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.5 0.75" />
                            <Vertex pos="0.75 0.5 0.25" />
                            <Vertex pos="0.75 -1.5 0.75" />
                            <Vertex pos="0.75 -1.5 0.25" />
                            <Vertex pos="-0.25 1.5 -0.25" />
                            <Vertex pos="-0.25 1.5 -0.75" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0.883883" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.59099" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32960 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.353553" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="436" owner="0" type="0" pos="129.75 -1 2.25" rot="1 0 0 0" scale="" transform="1 0 0 129.75 0 1 0 -1 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 1.5 -1.25" />
                            <Vertex pos="0.75 1.5 -1.75" />
                            <Vertex pos="0.75 -2.5 -1.25" />
                            <Vertex pos="0.75 -2.5 -1.75" />
                            <Vertex pos="-0.25 0.5 -0.25" />
                            <Vertex pos="-0.25 0.5 -0.75" />
                            <Vertex pos="-0.25 -1.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.23744" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 0.353553" album="Blasted" material="bm_friction_ice" texgens="1 0 0 33216 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.707107" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="437" owner="0" type="0" pos="129.25 0 1.75" rot="1 0 0 0" scale="" transform="1 0 0 129.25 0 1 0 0 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.5 -0.75" />
                            <Vertex pos="1.25 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="-0.75 0.5 -0.75" />
                            <Vertex pos="-0.75 0.5 -1.25" />
                            <Vertex pos="0.25 -0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.53033" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 0.176777" album="Blasted" material="bm_friction_ice" texgens="1 0 0 33088 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.53033" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="438" owner="0" type="0" pos="128.75 -2 1.75" rot="1 0 0 0" scale="" transform="1 0 0 128.75 0 1 0 -2 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 -0.5 0.25" />
                            <Vertex pos="0.75 -0.5 -0.25" />
                            <Vertex pos="1.75 -1.5 -0.75" />
                            <Vertex pos="1.75 -1.5 -1.25" />
                            <Vertex pos="0.75 -0.5 0.25" />
                            <Vertex pos="0.75 -0.5 -0.25" />
                            <Vertex pos="-0.25 -1.5 -0.75" />
                            <Vertex pos="-0.25 -1.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 0.883883" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.53033" album="Blasted" material="bm_friction_ice" texgens="1 0 0 32960 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 0.176777" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="439" owner="8" type="4" pos="166 0 3" rot="1 0 0 0" scale="" transform="1 0 0 166 0 1 0 0 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 -1.5" />
                            <Vertex pos="6 4 -2" />
                            <Vertex pos="6 -4 -1.5" />
                            <Vertex pos="6 -4 -2" />
                            <Vertex pos="-2 4 -1.5" />
                            <Vertex pos="-2 4 -2" />
                            <Vertex pos="-2 -4 -1.5" />
                            <Vertex pos="-2 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="" material="bm_tile07_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="440" owner="0" type="0" pos="9 3.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 3.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 224 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -2304 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 2304 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -2304 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="442" owner="0" type="0" pos="9 3.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 3.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -160 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -2304 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 2304 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 2304 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="445" owner="0" type="0" pos="15 -0.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -0.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 256 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -3840 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 3840 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 3840 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -3840 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="446" owner="0" type="0" pos="15 -0.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -0.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -128 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -3840 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 3840 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 3840 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -3840 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="447" owner="0" type="0" pos="21 1.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 1.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 256 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="448" owner="0" type="0" pos="21 1.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 1.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -128 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="449" owner="0" type="0" pos="21 -2.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -2.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 256 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="450" owner="0" type="0" pos="21 -2.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -2.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -128 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 5376 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -5376 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="451" owner="0" type="0" pos="189 3.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 189 0 1 0 3.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 224 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="452" owner="0" type="0" pos="189 3.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 189 0 1 0 3.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -160 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="453" owner="0" type="0" pos="189 -0.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 189 0 1 0 -0.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 256 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="454" owner="0" type="0" pos="189 -0.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 189 0 1 0 -0.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -128 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 48384 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -48384 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="455" owner="0" type="0" pos="199 1.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 199 0 1 0 1.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 224 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="456" owner="0" type="0" pos="199 1.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 199 0 1 0 1.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -160 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="" material="bm_edge_white" texgens="-1 0 0 1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="457" owner="0" type="0" pos="199 -2.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 199 0 1 0 -2.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="5 -1.25 -0.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 0.25 -0.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                            <Vertex pos="4.875 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 256 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="458" owner="0" type="0" pos="199 -2.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 199 0 1 0 -2.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 3.25" />
                            <Vertex pos="5 0.25 1.5" />
                            <Vertex pos="5 -1.25 3.25" />
                            <Vertex pos="5 -1.25 1.5" />
                            <Vertex pos="4.875 0.25 3.25" />
                            <Vertex pos="4.875 0.25 1.5" />
                            <Vertex pos="4.875 -1.25 3.25" />
                            <Vertex pos="4.875 -1.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.875" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 -128 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="Blasted" material="bm_wood" texgens="1 0 0 50944 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -50944 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
