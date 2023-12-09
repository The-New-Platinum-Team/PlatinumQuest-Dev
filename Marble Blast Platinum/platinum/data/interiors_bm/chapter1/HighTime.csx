<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2023/12/08 16:03:22">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="12">
        <SceneShape id="6" type="1" entityID="12" dl="0" group="-1" locked="0" />
        <SceneShape id="7" type="1" entityID="13" dl="0" group="-1" locked="0" />
        <SceneShape id="8" type="1" entityID="14" dl="0" group="-1" locked="0" />
        <SceneShape id="9" type="1" entityID="17" dl="0" group="-1" locked="0" />
        <SceneShape id="10" type="1" entityID="18" dl="0" group="-1" locked="0" />
        <SceneShape id="11" type="1" entityID="19" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="21">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="11" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="12" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 18 0.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="13" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 18 0.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="14" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 18 8.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="15" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="16" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="17" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 6 18.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="18" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 6 18.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="19" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 6 36.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="20" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="128">
                    <Brush id="0" owner="0" type="0" pos="0 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="3 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_trim" texgens="-1 0 0 0 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="0 8 0.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 8 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 0.25" />
                            <Vertex pos="3 1 -0.25" />
                            <Vertex pos="3 -1 0.25" />
                            <Vertex pos="3 -1 -0.25" />
                            <Vertex pos="-3 1 0.25" />
                            <Vertex pos="-3 1 -0.25" />
                            <Vertex pos="-3 -1 0.25" />
                            <Vertex pos="-3 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_trim" texgens="0 1 0 2048 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_trim" texgens="1 0 0 0 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="7 7 1.25" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 7 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 1792 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -1792 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 1792 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="13 9 1.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 9 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -6 0.25" />
                            <Vertex pos="-2 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -2304 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="0 24 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 24 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 3 13" />
                            <Vertex pos="9 3 -13" />
                            <Vertex pos="9 -3 13" />
                            <Vertex pos="9 -3 -13" />
                            <Vertex pos="-9 3 13" />
                            <Vertex pos="-9 3 -13" />
                            <Vertex pos="-9 -3 13" />
                            <Vertex pos="-9 -3 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile06_B" texgens="1 0 0 256 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="0 12 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 12 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 3 13" />
                            <Vertex pos="9 3 -13" />
                            <Vertex pos="9 -3 13" />
                            <Vertex pos="9 -3 -13" />
                            <Vertex pos="-9 3 13" />
                            <Vertex pos="-9 3 -13" />
                            <Vertex pos="-9 -3 13" />
                            <Vertex pos="-9 -3 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile06_B" texgens="1 0 0 256 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="6 18 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 18 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 13" />
                            <Vertex pos="3 3 -13" />
                            <Vertex pos="3 -3 13" />
                            <Vertex pos="3 -3 -13" />
                            <Vertex pos="-3 3 13" />
                            <Vertex pos="-3 3 -13" />
                            <Vertex pos="-3 -3 13" />
                            <Vertex pos="-3 -3 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 640 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile06_B" texgens="1 0 0 1792 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-6 18 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 18 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 17" />
                            <Vertex pos="3 3 -17" />
                            <Vertex pos="3 -3 17" />
                            <Vertex pos="3 -3 -17" />
                            <Vertex pos="-3 3 17" />
                            <Vertex pos="-3 3 -17" />
                            <Vertex pos="-3 -3 17" />
                            <Vertex pos="-3 -3 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 640 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile06_B" texgens="1 0 0 1792 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="11" type="999" pos="0 18 0.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 18 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 6" />
                            <Vertex pos="3 3 -6" />
                            <Vertex pos="3 -3 6" />
                            <Vertex pos="3 -3 -6" />
                            <Vertex pos="-3 3 6" />
                            <Vertex pos="-3 3 -6" />
                            <Vertex pos="-3 -3 6" />
                            <Vertex pos="-3 -3 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank2" texgens="0 1 0 640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank2" texgens="0 -1 0 -1664 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank2" texgens="-1 0 0 -896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank2" texgens="1 0 0 640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile07_D" texgens="1 0 0 1792 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank2" texgens="-1 0 0 -640 0 -1 0 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="6 18 13.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 18 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 9 7" />
                            <Vertex pos="3 9 -7" />
                            <Vertex pos="3 -9 7" />
                            <Vertex pos="3 -9 -7" />
                            <Vertex pos="-3 9 7" />
                            <Vertex pos="-3 9 -7" />
                            <Vertex pos="-3 -9 7" />
                            <Vertex pos="-3 -9 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 640 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_tile06_B" texgens="1 0 0 1792 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-6 24 13.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 24 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 7" />
                            <Vertex pos="3 3 -7" />
                            <Vertex pos="3 -3 7" />
                            <Vertex pos="3 -3 -7" />
                            <Vertex pos="-3 3 7" />
                            <Vertex pos="-3 3 -7" />
                            <Vertex pos="-3 -3 7" />
                            <Vertex pos="-3 -3 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 1408 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -2432 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 640 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_tile06_B" texgens="1 0 0 1792 0 -1 0 -4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-3 12 13.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 12 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 7" />
                            <Vertex pos="6 3 -7" />
                            <Vertex pos="6 -3 7" />
                            <Vertex pos="6 -3 -7" />
                            <Vertex pos="-6 3 7" />
                            <Vertex pos="-6 3 -7" />
                            <Vertex pos="-6 -3 7" />
                            <Vertex pos="-6 -3 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 1408 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -2432 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_tile06_B" texgens="1 0 0 2560 0 -1 0 -4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="12 19 6.25" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 19 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 0.25" />
                            <Vertex pos="3 4 -0.25" />
                            <Vertex pos="3 -4 0.25" />
                            <Vertex pos="3 -4 -0.25" />
                            <Vertex pos="-3 4 0.25" />
                            <Vertex pos="-3 4 -0.25" />
                            <Vertex pos="-3 -4 0.25" />
                            <Vertex pos="-3 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 256 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="11 30 6.25" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 30 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 0.25" />
                            <Vertex pos="4 3 -0.25" />
                            <Vertex pos="4 -3 0.25" />
                            <Vertex pos="4 -3 -0.25" />
                            <Vertex pos="-4 3 0.25" />
                            <Vertex pos="-4 3 -0.25" />
                            <Vertex pos="-4 -3 0.25" />
                            <Vertex pos="-4 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="1 30 6.25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 30 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 0.25" />
                            <Vertex pos="4 3 -0.25" />
                            <Vertex pos="4 -3 0.25" />
                            <Vertex pos="4 -3 -0.25" />
                            <Vertex pos="-4 3 0.25" />
                            <Vertex pos="-4 3 -0.25" />
                            <Vertex pos="-4 -3 0.25" />
                            <Vertex pos="-4 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="0 24 16.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 24 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 4" />
                            <Vertex pos="3 3 -4" />
                            <Vertex pos="3 -3 4" />
                            <Vertex pos="3 -3 -4" />
                            <Vertex pos="-3 3 4" />
                            <Vertex pos="-3 3 -4" />
                            <Vertex pos="-3 -3 4" />
                            <Vertex pos="-3 -3 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 1408 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -2432 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 640 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile06_B" texgens="1 0 0 1792 0 -1 0 -4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="0 18 28.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 18 0 0 1 28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 9 8" />
                            <Vertex pos="9 9 -8" />
                            <Vertex pos="9 -9 8" />
                            <Vertex pos="9 -9 -8" />
                            <Vertex pos="-9 9 8" />
                            <Vertex pos="-9 9 -8" />
                            <Vertex pos="-9 -9 8" />
                            <Vertex pos="-9 -9 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_grid_blank4" texgens="0 1 0 2176 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_grid_blank4" texgens="0 -1 0 -3200 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -1664 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 1408 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile06_B" texgens="1 0 0 3328 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -1408 0 -1 0 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-12 15 14.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 15 0 0 1 14.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 -6 0.25" />
                            <Vertex pos="3 -6 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 -6 0.25" />
                            <Vertex pos="-3 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-12 -5 18.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -5 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 -6 0.25" />
                            <Vertex pos="3 -6 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 -6 0.25" />
                            <Vertex pos="-3 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="0 -4 18.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -4 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 7 0.25" />
                            <Vertex pos="3 7 -0.25" />
                            <Vertex pos="3 -7 0.25" />
                            <Vertex pos="3 -7 -0.25" />
                            <Vertex pos="-3 7 0.25" />
                            <Vertex pos="-3 7 -0.25" />
                            <Vertex pos="-3 -7 0.25" />
                            <Vertex pos="-3 -7 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 256 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="16" type="999" pos="0 6 18.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 6 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="3 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_mp1" texgens="0 1 0 1536 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_mp1" texgens="0 -1 0 -1408 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_mp1" texgens="-1 0 0 0 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_mp1" texgens="1 0 0 128 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile07_D" texgens="1 0 0 256 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-6 -2 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -2 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 22" />
                            <Vertex pos="3 3 -22" />
                            <Vertex pos="3 -3 22" />
                            <Vertex pos="3 -3 -22" />
                            <Vertex pos="-3 3 22" />
                            <Vertex pos="-3 3 -22" />
                            <Vertex pos="-3 -3 22" />
                            <Vertex pos="-3 -3 -22" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 1408 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -2432 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 640 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -22" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-6 5 27.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 5 0 0 1 27.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -3328 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 640 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-6 5 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 5 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 19" />
                            <Vertex pos="3 4 -19" />
                            <Vertex pos="3 -4 19" />
                            <Vertex pos="3 -4 -19" />
                            <Vertex pos="-3 4 19" />
                            <Vertex pos="-3 4 -19" />
                            <Vertex pos="-3 -4 19" />
                            <Vertex pos="-3 -4 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 1536 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -2560 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 640 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile06_B" texgens="1 0 0 1792 0 -1 0 -4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 -2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-6 -8 18.25" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -8 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="3 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 -768 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="2 5 0.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 5 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 1280 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 -1280 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 512 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-1 5 0.625" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 5 0 0 1 0.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.125" />
                            <Vertex pos="2 2 -0.125" />
                            <Vertex pos="2 -2 0.125" />
                            <Vertex pos="2 -2 -0.125" />
                            <Vertex pos="-2 2 0.125" />
                            <Vertex pos="-2 2 -0.125" />
                            <Vertex pos="-2 -2 0.125" />
                            <Vertex pos="-2 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -256 0 0 -1 -160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_tile06_B" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="8 4 1.25" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 4 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 1024 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 -1024 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="4 8 1.25" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 8 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 -2048 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_trim" texgens="1 0 0 1024 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="4 5 1.125" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 5 0 0 1 1.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.125" />
                            <Vertex pos="1 2 -0.125" />
                            <Vertex pos="1 -2 0.125" />
                            <Vertex pos="1 -2 -0.125" />
                            <Vertex pos="-1 2 0.125" />
                            <Vertex pos="-1 2 -0.125" />
                            <Vertex pos="-1 -2 0.125" />
                            <Vertex pos="-1 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 -1280 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_tile06_B" texgens="1 0 0 768 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="6 4 1.125" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 4 0 0 1 1.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.125" />
                            <Vertex pos="1 1 -0.125" />
                            <Vertex pos="1 -1 0.125" />
                            <Vertex pos="1 -1 -0.125" />
                            <Vertex pos="-1 1 0.125" />
                            <Vertex pos="-1 1 -0.125" />
                            <Vertex pos="-1 -1 0.125" />
                            <Vertex pos="-1 -1 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_tile06_B" texgens="1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="6 18 39.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 18 0 0 1 39.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 9 3" />
                            <Vertex pos="3 9 -3" />
                            <Vertex pos="3 -9 3" />
                            <Vertex pos="3 -9 -3" />
                            <Vertex pos="-3 9 3" />
                            <Vertex pos="-3 9 -3" />
                            <Vertex pos="-3 -9 3" />
                            <Vertex pos="-3 -9 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 2176 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -3200 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 -2432 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 2176 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile06_B" texgens="1 0 0 4864 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -2176 0 -1 0 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-3 24 39.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 24 0 0 1 39.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 2944 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -3968 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -2048 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 1792 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile06_B" texgens="1 0 0 4096 0 -1 0 -7424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -1792 0 -1 0 -3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="6 21 45.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 21 0 0 1 45.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 3" />
                            <Vertex pos="3 6 -3" />
                            <Vertex pos="3 -6 3" />
                            <Vertex pos="3 -6 -3" />
                            <Vertex pos="-3 6 3" />
                            <Vertex pos="-3 6 -3" />
                            <Vertex pos="-3 -6 3" />
                            <Vertex pos="-3 -6 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 2560 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -3584 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -2432 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 2176 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -2176 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="0 24 45.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 24 0 0 1 45.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 2944 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -3968 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -2432 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 2176 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -2176 0 -1 0 -3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-6 0.414732 27.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 0.414732 0 0 1 27.5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 0.585271 3" />
                            <Vertex pos="-3 -0.585271 2.88472" />
                            <Vertex pos="-3 0.585256 -3" />
                            <Vertex pos="3 0.585271 3" />
                            <Vertex pos="3 -0.585271 2.88472" />
                            <Vertex pos="3 0.585256 -3" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -437.087 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 181.085 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.0980101 0.995185 -2.92819" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.980786 -0.195089 126.768 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 1 -2.5034e-006 -0.585263" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 0 1 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.980786 -0.195088 -0.0112522" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 0 1 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-6 -0.148056 27.4424" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -0.148056 0 0 1 27.4424 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -0.0224853 2.94235" />
                            <Vertex pos="-3 -1.14804 2.60092" />
                            <Vertex pos="-3 1.14804 -2.94236" />
                            <Vertex pos="3 -0.0224853 2.94235" />
                            <Vertex pos="3 -1.14804 2.60092" />
                            <Vertex pos="3 1.14804 -2.94236" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -365.051 0 0 -1 391.379 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 109.048 0 0 -1 391.379 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.290282 0.956941 -2.82218" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.980786 -0.195089 188.357 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.980786 0.195088 -0.551963" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.195088 0.980786 99.5141 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.923881 -0.38268 -0.0653313" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.195088 0.980786 99.5141 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-6 -0.666712 27.2716" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -0.666712 0 0 1 27.2716 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -0.629386 2.77164" />
                            <Vertex pos="-3 -1.6667 2.21717" />
                            <Vertex pos="-3 1.6667 -2.77164" />
                            <Vertex pos="3 -0.629386 2.77164" />
                            <Vertex pos="3 -1.6667 2.21717" />
                            <Vertex pos="3 1.6667 -2.77164" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -298.663 0 0 -1 413.23 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 42.6598 0 0 -1 413.23 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.471406 0.881916 -2.74105" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.831471 -0.555569 111.16 0 0.25 0.292637" texRot="0" texScale="0.25 0.292637" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.92388 0.382681 -0.479177" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.382682 0.92388 102.352 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.831471 -0.555568 -0.154023" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.382682 0.92388 102.352 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-6 -1.12134 26.9944" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -1.12134 0 0 1 26.9944 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -1.21209 2.4944" />
                            <Vertex pos="-3 -2.12132 1.74821" />
                            <Vertex pos="-3 2.12132 -2.4944" />
                            <Vertex pos="3 -1.21209 2.4944" />
                            <Vertex pos="3 -2.12132 1.74821" />
                            <Vertex pos="3 2.12132 -2.4944" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -240.471 0 0 -1 448.715 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -15.5325 0 0 -1 448.715 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.634395 0.773009 -2.69714" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.831471 -0.555569 169.338 0 0.25 0.292637" texRot="0" texScale="0.25 0.292637" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.83147 0.55557 -0.377998" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.555569 0.831471 104.083 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.707104 -0.707109 -0.263819" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.555569 0.831471 104.083 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-6 -1.49444 26.6213" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -1.49444 0 0 1 26.6213 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -1.74822 2.12131" />
                            <Vertex pos="-3 -2.49441 1.2121" />
                            <Vertex pos="-3 2.49441 -2.12131" />
                            <Vertex pos="3 -1.74822 2.12131" />
                            <Vertex pos="3 -2.49441 1.2121" />
                            <Vertex pos="3 2.49441 -2.12131" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -192.714 0 0 -1 496.473 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -63.2887 0 0 -1 496.473 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.773002 0.634404 -2.69714" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.555571 -0.831469 86.6682 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707106 0.707108 -0.263818" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.707107 0.707107 104.442 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.555569 -0.831471 -0.377991" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.707107 0.707107 104.442 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-6 -1.77164 26.1667" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -1.77164 0 0 1 26.1667 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -2.21721 1.6667" />
                            <Vertex pos="-3 -2.77164 0.629391" />
                            <Vertex pos="-3 2.77164 -1.6667" />
                            <Vertex pos="3 -2.21721 1.6667" />
                            <Vertex pos="3 -2.77164 0.629391" />
                            <Vertex pos="3 2.77164 -1.6667" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -157.232 0 0 -1 554.664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -98.7709 0 0 -1 554.664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.881929 0.471381 -2.74107" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.555571 -0.831469 144.844 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.555565 0.831473 -0.154011" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.83147 0.55557 103.376 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.382682 -0.92388 -0.479174" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.83147 0.55557 103.376 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-6 -1.94236 25.648" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -1.94236 0 0 1 25.648 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -2.60092 1.14805" />
                            <Vertex pos="-3 -2.94236 0.0224857" />
                            <Vertex pos="-3 2.94236 -1.14805" />
                            <Vertex pos="3 -2.60092 1.14805" />
                            <Vertex pos="3 -2.94236 0.0224857" />
                            <Vertex pos="3 2.94236 -1.14805" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -135.38 0 0 -1 621.051 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -120.623 0 0 -1 621.051 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.956939 0.290288 -2.82219" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.195089 -0.980786 67.6394 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.382683 0.92388 -0.0653316" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.92388 0.382683 101.046 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.195089 -0.980786 -0.551968" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.92388 0.382683 101.046 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="-6 -1.99999 25.0853" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -1.99999 0 0 1 25.0853 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -2.88473 0.58527" />
                            <Vertex pos="-3 -3.00001 -0.585266" />
                            <Vertex pos="-3 3.00001 -0.585268" />
                            <Vertex pos="3 -2.88473 0.58527" />
                            <Vertex pos="3 -3.00001 -0.585266" />
                            <Vertex pos="3 3.00001 -0.585268" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -128.003 0 0 -1 693.086 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -127.999 0 0 -1 693.086 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.995185 0.0980106 -2.9282" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.195089 -0.980786 129.227 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.195089 0.980786 -0.0112458" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.980785 0.19509 97.8081 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -3.37759e-007 -1 -0.585267" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.980785 0.19509 97.8081 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="6 14.4147 45.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 14.4147 0 0 1 45.5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 0.585266 3" />
                            <Vertex pos="-3 -0.585266 2.88469" />
                            <Vertex pos="-3 0.585266 -3" />
                            <Vertex pos="3 0.585266 3" />
                            <Vertex pos="3 -0.585266 2.88469" />
                            <Vertex pos="3 0.585266 -3" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -437.086 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 181.086 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.0980362 0.995183 -2.92817" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.980786 -0.195089 126.773 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.585266" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 0 1 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.980786 -0.195089 -0.0112478" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 0 1 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="6 13.852 45.4423" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 13.852 0 0 1 45.4423 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -0.0224819 2.94236" />
                            <Vertex pos="-3 -1.14805 2.60079" />
                            <Vertex pos="-3 1.14805 -2.94235" />
                            <Vertex pos="3 -0.0224819 2.94236" />
                            <Vertex pos="3 -1.14805 2.60079" />
                            <Vertex pos="3 1.14805 -2.94235" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -365.049 0 0 -1 391.383 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 109.049 0 0 -1 391.383 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.290388 0.956909 -2.8221" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.980786 -0.195089 188.353 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.980786 0.195089 -0.551971" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.195088 0.980786 99.5095 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.923876 -0.382691 -0.065356" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.195088 0.980786 99.5095 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="6 13.3333 45.2716" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 13.3333 0 0 1 45.2716 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -0.629391 2.77155" />
                            <Vertex pos="-3 -1.6667 2.21718" />
                            <Vertex pos="-3 1.6667 -2.77155" />
                            <Vertex pos="3 -0.629391 2.77155" />
                            <Vertex pos="3 -1.6667 2.21718" />
                            <Vertex pos="3 1.6667 -2.77155" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -298.662 0 0 -1 413.242 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 42.6621 0 0 -1 413.242 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.471342 0.881951 -2.74103" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.831471 -0.555569 111.161 0 0.25 0.292637" texRot="0" texScale="0.25 0.292637" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.923876 0.382693 -0.479172" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.382682 0.92388 102.349 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.831467 -0.555575 -0.153997" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.382682 0.92388 102.349 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="6 12.8787 44.9944" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 12.8787 0 0 1 44.9944 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -1.21207 2.49435" />
                            <Vertex pos="-3 -2.12131 1.74811" />
                            <Vertex pos="-3 2.12131 -2.49435" />
                            <Vertex pos="3 -1.21207 2.49435" />
                            <Vertex pos="3 -2.12131 1.74811" />
                            <Vertex pos="3 2.12131 -2.49435" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -240.469 0 0 -1 448.719 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -15.5313 0 0 -1 448.719 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.634417 0.772991 -2.69707" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.831471 -0.555569 169.333 0 0.25 0.292637" texRot="0" texScale="0.25 0.292637" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.831467 0.555575 -0.378001" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.555569 0.831471 104.083 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.707093 -0.70712 -0.263841" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.555569 0.831471 104.083 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="6 12.5055 44.6213" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 12.5055 0 0 1 44.6213 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -1.7482 2.12122" />
                            <Vertex pos="-3 -2.49438 1.21217" />
                            <Vertex pos="-3 2.49438 -2.12122" />
                            <Vertex pos="3 -1.7482 2.12122" />
                            <Vertex pos="3 -2.49438 1.21217" />
                            <Vertex pos="3 2.49438 -2.12122" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -192.709 0 0 -1 496.477 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -63.291 0 0 -1 496.477 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.772951 0.634465 -2.69711" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.555571 -0.831469 86.667 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707095 0.707118 -0.26381" album="" material="bm_grid_blank4" texgens="1 0 0 96.0001 0 -0.707107 0.707107 104.442 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.555571 -0.831469 -0.377923" album="" material="bm_grid_blank4" texgens="1 0 0 96.0001 0 -0.707107 0.707107 104.442 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="6 12.2283 44.1667" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 12.2283 0 0 1 44.1667 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -2.21719 1.66671" />
                            <Vertex pos="-3 -2.77162 0.629532" />
                            <Vertex pos="-3 2.77162 -1.66671" />
                            <Vertex pos="3 -2.21706 1.66663" />
                            <Vertex pos="3 -2.77149 0.629475" />
                            <Vertex pos="3 2.77162 -1.66671" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -157.229 0 0 -1 554.656 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -98.7715 0 0 -1 554.656 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="2.3576e-005 -0.881905 0.471428 -2.74101" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.555571 -0.831469 144.843 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-9.46867e-007 0.555571 0.831469 -0.154013" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.83147 0.55557 103.377 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.382706 -0.92387 -0.479109" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.83147 0.55557 103.377 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="6 12.0584 43.648" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 12.0584 0 0 1 43.648 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -2.60166 1.14828" />
                            <Vertex pos="-3 -2.9431 0.0226402" />
                            <Vertex pos="-3 2.9431 -1.14828" />
                            <Vertex pos="3 -2.60174 1.14801" />
                            <Vertex pos="3 -2.9431 0.0226402" />
                            <Vertex pos="3 2.94165 -1.14799" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -135.473 0 0 -1 621.063 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -120.527 0 0 -1 621.063 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.956945 0.29027 -2.82296" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.195089 -0.980786 67.6294 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="4.66703e-005 0.382662 0.923888 -0.0651847" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.92388 0.382683 101.024 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="2.58386e-007 -0.195103 -0.980783 -0.552003" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.92388 0.382683 101.024 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="6 12 43.0853" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 12 0 0 1 43.0853 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -2.88471 0.585308" />
                            <Vertex pos="-3 -2.99999 -0.585312" />
                            <Vertex pos="-3 2.99999 -0.585308" />
                            <Vertex pos="3 -2.88471 0.585308" />
                            <Vertex pos="3 -2.99999 -0.585312" />
                            <Vertex pos="3 2.99999 -0.585308" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -127.998 0 0 -1 693.078 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128.002 0 0 -1 693.078 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 -0.995186 0.0980036 -2.92819" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -0.195089 -0.980786 129.219 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.195103 0.980783 -0.0112457" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.980785 0.19509 97.8093 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 6.65587e-007 -1 -0.58531" album="" material="bm_grid_blank4" texgens="1 0 0 96 0 -0.980785 0.19509 97.8093 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="-3.58526 24 45.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.58526 0 1 0 24 0 0 1 45.5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.585268 3 3" />
                            <Vertex pos="-0.585268 3 2.88469" />
                            <Vertex pos="0.585253 3 -3" />
                            <Vertex pos="0.585268 -3 3" />
                            <Vertex pos="-0.585268 -3 2.88469" />
                            <Vertex pos="0.585253 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="0 1 0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -437.087 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 181.085 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.0980358 0 0.995183 -2.92817" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 -0.980786 0 -0.195089 126.769 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="1 0 -2.5034e-006 -0.585261" album="" material="bm_grid_blank4" texgens="0 -1 0 96 0 0 1 96.0001 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.980786 -0 -0.195088 -0.0112551" album="" material="bm_grid_blank4" texgens="0 -1 0 96 0 0 1 96.0001 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="-4.14805 24 45.4423" rot="1 0 0 0" scale="" transform="1 0 0 -4.14805 0 1 0 24 0 0 1 45.4423 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.0224786 3 2.94235" />
                            <Vertex pos="-1.14804 3 2.60078" />
                            <Vertex pos="1.14804 3 -2.94235" />
                            <Vertex pos="-0.0224786 -3 2.94235" />
                            <Vertex pos="-1.14804 -3 2.60078" />
                            <Vertex pos="1.14804 -3 -2.94235" />
                        </Vertices>
                        <Face id="0" plane="0 1 0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -365.051 0 0 -1 391.383 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 109.048 0 0 -1 391.383 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.290389 0 0.956909 -2.82209" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 -0.980786 0 -0.195089 188.359 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.980786 -0 0.195087 -0.551967" album="" material="bm_grid_blank4" texgens="0 -1 0 96.0001 -0.195089 0 0.980786 99.5106 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.923877 -0 -0.382689 -0.0653574" album="" material="bm_grid_blank4" texgens="0 -1 0 96.0001 -0.195089 0 0.980786 99.5106 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="-4.66671 24 45.2716" rot="1 0 0 0" scale="" transform="1 0 0 -4.66671 0 1 0 24 0 0 1 45.2716 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.629383 3 2.77155" />
                            <Vertex pos="-1.66669 3 2.21718" />
                            <Vertex pos="1.66669 3 -2.77155" />
                            <Vertex pos="-0.629383 -3 2.77155" />
                            <Vertex pos="-1.66669 -3 2.21718" />
                            <Vertex pos="1.66669 -3 -2.77155" />
                        </Vertices>
                        <Face id="0" plane="0 1 0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -298.662 0 0 -1 413.242 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 42.6602 0 0 -1 413.242 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.471342 0 0.88195 -2.74102" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 -0.831471 0 -0.555569 111.158 0 0.25 0.292637" texRot="0" texScale="0.25 0.292637" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.923877 -0 0.38269 -0.479172" album="" material="bm_grid_blank4" texgens="0 -1 0 96.0001 -0.382682 0 0.92388 102.353 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.831468 -0 -0.555572 -0.153996" album="" material="bm_grid_blank4" texgens="0 -1 0 96.0001 -0.382682 0 0.92388 102.353 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-5.12133 24 44.9944" rot="1 0 0 0" scale="" transform="1 0 0 -5.12133 0 1 0 24 0 0 1 44.9944 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.21208 3 2.49439" />
                            <Vertex pos="-2.12133 3 1.74814" />
                            <Vertex pos="2.12133 3 -2.49438" />
                            <Vertex pos="-1.21208 -3 2.49439" />
                            <Vertex pos="-2.12133 -3 1.74814" />
                            <Vertex pos="2.12132 -3 -2.49438" />
                        </Vertices>
                        <Face id="0" plane="0 1 0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -240.473 0 0 -1 448.719 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -15.5303 0 0 -1 448.719 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.634418 0 0.772991 -2.6971" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 -0.831471 0 -0.555569 169.336 0 0.25 0.292637" texRot="0" texScale="0.25 0.292637" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.831469 -0 0.555571 -0.378005" album="" material="bm_grid_blank4" texgens="0 -1 0 96 -0.555569 0 0.831471 104.086 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.707095 1.18009e-006 -0.707118 -0.263844" album="" material="bm_grid_blank4" texgens="0 -1 0 96 -0.555569 0 0.831471 104.086 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-5.49442 24 44.6212" rot="1 0 0 0" scale="" transform="1 0 0 -5.49442 0 1 0 24 0 0 1 44.6212 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.74823 3 2.12126" />
                            <Vertex pos="-2.49442 3 1.2122" />
                            <Vertex pos="2.49442 3 -2.12126" />
                            <Vertex pos="-1.74823 -3 2.12126" />
                            <Vertex pos="-2.49442 -3 1.2122" />
                            <Vertex pos="2.49442 -3 -2.12125" />
                        </Vertices>
                        <Face id="0" plane="0 1 0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -192.716 0 0 -1 496.484 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -63.2861 0 0 -1 496.484 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.77295 0 0.634466 -2.69716" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 -0.555571 0 -0.831469 86.6699 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.707095 -0 0.707118 -0.263817" album="" material="bm_grid_blank4" texgens="0 -1 0 96 -0.707107 0 0.707107 104.438 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.555573 -1.38766e-006 -0.831468 -0.377923" album="" material="bm_grid_blank4" texgens="0 -1 0 96 -0.707107 0 0.707107 104.438 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-5.77165 24 44.1667" rot="1 0 0 0" scale="" transform="1 0 0 -5.77165 0 1 0 24 0 0 1 44.1667 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.2172 3 1.66671" />
                            <Vertex pos="-2.77163 3 0.629532" />
                            <Vertex pos="2.77163 3 -1.66671" />
                            <Vertex pos="-2.21707 -3 1.66663" />
                            <Vertex pos="-2.77149 -3 0.629475" />
                            <Vertex pos="2.77163 -3 -1.66671" />
                        </Vertices>
                        <Face id="0" plane="0 1 0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -157.23 0 0 -1 554.656 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -98.7715 0 0 -1 554.656 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.881905 -2.50478e-005 0.471428 -2.74102" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 -0.555571 0 -0.831469 144.842 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.55557 9.46819e-007 0.83147 -0.154012" album="" material="bm_grid_blank4" texgens="0 -1 0 96.0001 -0.83147 0 0.55557 103.377 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.382705 -0 -0.923871 -0.479109" album="" material="bm_grid_blank4" texgens="0 -1 0 96.0001 -0.83147 0 0.55557 103.377 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="-5.94162 24 43.648" rot="1 0 0 0" scale="" transform="1 0 0 -5.94162 0 1 0 24 0 0 1 43.648 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.60166 3 1.14828" />
                            <Vertex pos="-2.9431 3 0.0226402" />
                            <Vertex pos="2.9431 3 -1.14827" />
                            <Vertex pos="-2.60174 -3 1.148" />
                            <Vertex pos="-2.9431 -3 0.0226402" />
                            <Vertex pos="2.94164 -3 -1.14799" />
                        </Vertices>
                        <Face id="0" plane="0 1 0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -135.474 0 0 -1 621.063 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -120.528 0 0 -1 621.063 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.956945 0 0.29027 -2.82296" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 -0.195089 0 -0.980786 67.6294 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.382662 -4.82122e-005 0.923889 -0.0651824" album="" material="bm_grid_blank4" texgens="0 -1 0 96.0001 -0.92388 0 0.382683 101.024 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.195102 1.70368e-006 -0.980783 -0.552004" album="" material="bm_grid_blank4" texgens="0 -1 0 96.0001 -0.92388 0 0.382683 101.024 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="-6 24 43.0853" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 24 0 0 1 43.0853 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.88472 3 0.585316" />
                            <Vertex pos="-3 3 -0.585312" />
                            <Vertex pos="3 3 -0.585312" />
                            <Vertex pos="-2.88472 -3 0.585316" />
                            <Vertex pos="-3 -3 -0.585312" />
                            <Vertex pos="3 -3 -0.585312" />
                        </Vertices>
                        <Face id="0" plane="0 1 0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128.002 0 0 -1 693.078 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128.001 0 0 -1 693.078 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.995186 0 0.0980029 -2.9282" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 -0.195089 0 -0.980786 129.226 0 0.25 0.292636" texRot="0" texScale="0.25 0.292636" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.195104 -0 0.980783 -0.0112476" album="" material="bm_grid_blank4" texgens="0 -1 0 96 -0.980785 0 0.19509 97.8092 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0 -0 -1 -0.585312" album="" material="bm_grid_blank4" texgens="0 -1 0 96 -0.980785 0 0.19509 97.8092 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="16" type="999" pos="0 6 16.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 6 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 1.75" />
                            <Vertex pos="3 3 -1.75" />
                            <Vertex pos="3 -3 1.75" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="-3 3 1.75" />
                            <Vertex pos="-3 3 -1.75" />
                            <Vertex pos="-3 -3 1.75" />
                            <Vertex pos="-3 -3 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank2" texgens="0 1 0 1664 0 0 -1 -992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank2" texgens="0 -1 0 -2688 0 0 -1 -992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank2" texgens="-1 0 0 -896 0 0 -1 -992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank2" texgens="1 0 0 640 0 0 -1 -992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_grid_blank2" texgens="1 0 0 1792 0 -1 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.316228 -0.948683 -0.711512" album="" material="bm_grid_blank2" texgens="-1 0 0 -640 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="3.25 -0.75 0.5" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -0.75 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.75 0.5" />
                            <Vertex pos="0.25 2.75 -0.5" />
                            <Vertex pos="0.25 -2.75 0.5" />
                            <Vertex pos="0.25 -2.75 -0.5" />
                            <Vertex pos="-0.25 2.75 -8.9407e-008" />
                            <Vertex pos="-0.25 2.75 -0.5" />
                            <Vertex pos="-0.25 -2.25 -8.9407e-008" />
                            <Vertex pos="-0.25 -2.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -192 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 320 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.75" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.76777" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="3.75 -1 0.5" rot="1 0 0 0" scale="" transform="1 0 0 3.75 0 1 0 -1 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.5" />
                            <Vertex pos="0.25 3 -0.5" />
                            <Vertex pos="0.25 -3 0.5" />
                            <Vertex pos="0.25 -3 -0.5" />
                            <Vertex pos="-0.25 3 0.5" />
                            <Vertex pos="-0.25 3 -0.5" />
                            <Vertex pos="-0.25 -2.5 0.5" />
                            <Vertex pos="-0.25 -2.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.94454" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="0.25 -3.25 0.5" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 -3.25 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.75 0.25 -1.78814e-007" />
                            <Vertex pos="2.75 0.25 -0.5" />
                            <Vertex pos="3.25 -0.25 0.5" />
                            <Vertex pos="3.25 -0.25 -0.5" />
                            <Vertex pos="-3.25 0.25 -1.78814e-007" />
                            <Vertex pos="-3.25 0.25 -0.5" />
                            <Vertex pos="-3.25 -0.25 0.5" />
                            <Vertex pos="-3.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 320 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="0.5 -3.75 0.5" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -3.75 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.5" />
                            <Vertex pos="3 0.25 -0.5" />
                            <Vertex pos="3.5 -0.25 0.5" />
                            <Vertex pos="3.5 -0.25 -0.5" />
                            <Vertex pos="-3.5 0.25 0.5" />
                            <Vertex pos="-3.5 0.25 -0.5" />
                            <Vertex pos="-3.5 -0.25 0.5" />
                            <Vertex pos="-3.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.2981" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="6 2.75 1.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 2.75 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 2.38419e-007" />
                            <Vertex pos="3 0.25 -0.5" />
                            <Vertex pos="3 -0.25 0.5" />
                            <Vertex pos="3 -0.25 -0.5" />
                            <Vertex pos="-3 0.25 2.38419e-007" />
                            <Vertex pos="-3 0.25 -0.5" />
                            <Vertex pos="-3 -0.25 0.5" />
                            <Vertex pos="-3 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="6 2.25 1.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 2.25 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.5" />
                            <Vertex pos="3 0.25 -0.5" />
                            <Vertex pos="3 -0.25 0.5" />
                            <Vertex pos="3 -0.25 -0.5" />
                            <Vertex pos="-3 0.25 0.5" />
                            <Vertex pos="-3 0.25 -0.5" />
                            <Vertex pos="-3 -0.25 0.5" />
                            <Vertex pos="-3 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="3.5 2.5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 3.5 0 1 0 2.5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="12.25 2.75 2" rot="1 0 0 0" scale="" transform="1 0 0 12.25 0 1 0 2.75 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.75 0.25 2.38419e-007" />
                            <Vertex pos="2.75 0.25 -0.5" />
                            <Vertex pos="3.25 -0.25 0.5" />
                            <Vertex pos="3.25 -0.25 -0.5" />
                            <Vertex pos="-3.25 0.25 2.38419e-007" />
                            <Vertex pos="-3.25 0.25 -0.5" />
                            <Vertex pos="-3.25 -0.25 0.5" />
                            <Vertex pos="-3.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 320 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -704 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="12.5 2.25 2" rot="1 0 0 0" scale="" transform="1 0 0 12.5 0 1 0 2.25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.5" />
                            <Vertex pos="3 0.25 -0.5" />
                            <Vertex pos="3.5 -0.25 0.5" />
                            <Vertex pos="3.5 -0.25 -0.5" />
                            <Vertex pos="-3.5 0.25 0.5" />
                            <Vertex pos="-3.5 0.25 -0.5" />
                            <Vertex pos="-3.5 -0.25 0.5" />
                            <Vertex pos="-3.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.2981" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="15.25 8.75 2" rot="1 0 0 0" scale="" transform="1 0 0 15.25 0 1 0 8.75 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.25 0.5" />
                            <Vertex pos="0.25 6.25 -0.5" />
                            <Vertex pos="0.25 -6.25 0.499999" />
                            <Vertex pos="0.25 -6.25 -0.5" />
                            <Vertex pos="-0.25 6.25 -4.76837e-007" />
                            <Vertex pos="-0.25 6.25 -0.5" />
                            <Vertex pos="-0.25 -5.75 -8.34465e-007" />
                            <Vertex pos="-0.25 -5.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.25" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -4.24264" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 -2.10734e-008 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="15.75 8.5 2" rot="1 0 0 0" scale="" transform="1 0 0 15.75 0 1 0 8.5 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.5 0.5" />
                            <Vertex pos="0.25 6.5 -0.5" />
                            <Vertex pos="0.25 -6.5 0.5" />
                            <Vertex pos="0.25 -6.5 -0.5" />
                            <Vertex pos="-0.25 6.5 0.5" />
                            <Vertex pos="-0.25 6.5 -0.5" />
                            <Vertex pos="-0.25 -6 0.5" />
                            <Vertex pos="-0.25 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -4.41942" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="15.25 19 6.5" rot="1 0 0 0" scale="" transform="1 0 0 15.25 0 1 0 19 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="15.75 19 6.5" rot="1 0 0 0" scale="" transform="1 0 0 15.75 0 1 0 19 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="12 26 6.25" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 26 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 0.25" />
                            <Vertex pos="3 1 -0.25" />
                            <Vertex pos="3 -1 0.25" />
                            <Vertex pos="3 -1 -0.25" />
                            <Vertex pos="-3 1 0.25" />
                            <Vertex pos="-3 1 -0.25" />
                            <Vertex pos="-3 -1 0.25" />
                            <Vertex pos="-3 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="15.25 29.25 6.5" rot="1 0 0 0" scale="" transform="1 0 0 15.25 0 1 0 29.25 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.5" />
                            <Vertex pos="0.25 4.25 -0.5" />
                            <Vertex pos="0.25 -4.25 0.5" />
                            <Vertex pos="0.25 -4.25 -0.5" />
                            <Vertex pos="-0.25 3.75 0" />
                            <Vertex pos="-0.25 3.75 -0.5" />
                            <Vertex pos="-0.25 -4.25 0" />
                            <Vertex pos="-0.25 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 320 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -192 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="15.75 29.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 15.75 0 1 0 29.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.5 0.5" />
                            <Vertex pos="0.25 4.5 -0.5" />
                            <Vertex pos="0.25 -4.5 0.5" />
                            <Vertex pos="0.25 -4.5 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4.5 0.5" />
                            <Vertex pos="-0.25 -4.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="10.5 15.25 4" rot="1 0 0 0" scale="" transform="1 0 0 10.5 0 1 0 15.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 2" />
                            <Vertex pos="1.5 0.25 -2" />
                            <Vertex pos="1.5 -0.25 2" />
                            <Vertex pos="1.5 -0.25 -2" />
                            <Vertex pos="-1.5 0.25 2" />
                            <Vertex pos="-1.5 0.25 -2" />
                            <Vertex pos="-1.5 -0.25 2" />
                            <Vertex pos="-1.5 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_edge_white" texgens="0 1 0 -704 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_edge_white" texgens="0 -1 0 832 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_stripe_caution2" texgens="-1 0 1.5 352 0 0 -1 128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_stripe_caution2" texgens="1 0 -1.5 -1056 0 0 -1 512 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="13.5 15.25 4" rot="1 0 0 0" scale="" transform="1 0 0 13.5 0 1 0 15.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 2" />
                            <Vertex pos="1.5 0.25 -2" />
                            <Vertex pos="1.5 -0.25 2" />
                            <Vertex pos="1.5 -0.25 -2" />
                            <Vertex pos="-1.5 0.25 2" />
                            <Vertex pos="-1.5 0.25 -2" />
                            <Vertex pos="-1.5 -0.25 2" />
                            <Vertex pos="-1.5 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_edge_white" texgens="0 1 0 -704 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_edge_white" texgens="0 -1 0 832 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_stripe_caution2" texgens="-1 0 -1.5 -416 0 0 -1 128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_stripe_caution2" texgens="1 0 1.5 -544 0 0 -1 512 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="15.5 15.25 4" rot="1 0 0 0" scale="" transform="1 0 0 15.5 0 1 0 15.25 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 2" />
                            <Vertex pos="0.5 0.25 -2" />
                            <Vertex pos="0.5 -0.25 2" />
                            <Vertex pos="0.5 -0.25 -2" />
                            <Vertex pos="-0.5 0.25 2" />
                            <Vertex pos="-0.5 0.25 -2" />
                            <Vertex pos="-0.5 -0.25 2" />
                            <Vertex pos="-0.5 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -704 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 832 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 0 0 -1 0 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="12.5 15.25 1.75" rot="1 0 0 0" scale="" transform="1 0 0 12.5 0 1 0 15.25 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 -704 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 832 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="11.25 33.25 6.5" rot="1 0 0 0" scale="" transform="1 0 0 11.25 0 1 0 33.25 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 0.25 0.500001" />
                            <Vertex pos="4.25 0.25 -0.500001" />
                            <Vertex pos="3.75 -0.25 2.86102e-006" />
                            <Vertex pos="3.75 -0.25 -0.500001" />
                            <Vertex pos="-4.25 0.25 0.500001" />
                            <Vertex pos="-4.25 0.25 -0.500001" />
                            <Vertex pos="-4.25 -0.25 2.86102e-006" />
                            <Vertex pos="-4.25 -0.25 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 192 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707106 0.707108 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="11.5 33.75 6.5" rot="1 0 0 0" scale="" transform="1 0 0 11.5 0 1 0 33.75 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.5" />
                            <Vertex pos="4.5 0.25 -0.5" />
                            <Vertex pos="4 -0.25 0.5" />
                            <Vertex pos="4 -0.25 -0.5" />
                            <Vertex pos="-4.5 0.25 0.5" />
                            <Vertex pos="-4.5 0.25 -0.5" />
                            <Vertex pos="-4.5 -0.25 0.5" />
                            <Vertex pos="-4.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 128 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="0.749998 33.25 6.5" rot="1 0 0 0" scale="" transform="1 0 0 0.749998 0 1 0 33.25 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 0.25 0.500001" />
                            <Vertex pos="4.25 0.25 -0.500001" />
                            <Vertex pos="4.25 -0.25 2.86102e-006" />
                            <Vertex pos="4.25 -0.25 -0.500001" />
                            <Vertex pos="-4.25 0.25 0.500001" />
                            <Vertex pos="-4.25 0.25 -0.500001" />
                            <Vertex pos="-3.75 -0.25 2.86102e-006" />
                            <Vertex pos="-3.75 -0.25 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 320 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -192 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707106 0.707108 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -64.001 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500001" album="" material="bm_edge_white" texgens="-1 0 0 -319.999 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="0.5 33.75 6.5" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 33.75 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.5" />
                            <Vertex pos="4.5 0.25 -0.5" />
                            <Vertex pos="4.5 -0.25 0.5" />
                            <Vertex pos="4.5 -0.25 -0.5" />
                            <Vertex pos="-4.5 0.25 0.5" />
                            <Vertex pos="-4.5 0.25 -0.5" />
                            <Vertex pos="-4 -0.25 0.5" />
                            <Vertex pos="-4 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -3.0052" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-3.25 30.25 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 30.25 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.75 -4.76837e-007" />
                            <Vertex pos="0.25 2.75 -0.5" />
                            <Vertex pos="0.25 -3.25 -4.76837e-007" />
                            <Vertex pos="0.25 -3.25 -0.5" />
                            <Vertex pos="-0.25 3.25 0.5" />
                            <Vertex pos="-0.25 3.25 -0.5" />
                            <Vertex pos="-0.25 -3.25 0.5" />
                            <Vertex pos="-0.25 -3.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.25" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707106 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="-3.75 30.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.75 0 1 0 30.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.5" />
                            <Vertex pos="0.25 3 -0.5" />
                            <Vertex pos="0.25 -3.5 0.5" />
                            <Vertex pos="0.25 -3.5 -0.5" />
                            <Vertex pos="-0.25 3.5 0.5" />
                            <Vertex pos="-0.25 3.5 -0.5" />
                            <Vertex pos="-0.25 -3.5 0.5" />
                            <Vertex pos="-0.25 -3.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -2.2981" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-12.25 21.25 14.5" rot="1 0 0 0" scale="" transform="1 0 0 -12.25 0 1 0 21.25 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.25 0.500001" />
                            <Vertex pos="3.25 0.25 -0.500002" />
                            <Vertex pos="3.25 -0.25 9.53674e-007" />
                            <Vertex pos="3.25 -0.25 -0.500002" />
                            <Vertex pos="-3.25 0.25 0.500001" />
                            <Vertex pos="-3.25 0.25 -0.500002" />
                            <Vertex pos="-2.75 -0.25 9.53674e-007" />
                            <Vertex pos="-2.75 -0.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.25" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -320 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500002" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-12.5 21.75 14.5" rot="1 0 0 0" scale="" transform="1 0 0 -12.5 0 1 0 21.75 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.5" />
                            <Vertex pos="3.5 0.25 -0.5" />
                            <Vertex pos="3.5 -0.25 0.5" />
                            <Vertex pos="3.5 -0.25 -0.5" />
                            <Vertex pos="-3.5 0.25 0.5" />
                            <Vertex pos="-3.5 0.25 -0.5" />
                            <Vertex pos="-3 -0.25 0.5" />
                            <Vertex pos="-3 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.2981" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 0 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-15.25 15.25 14.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 15.25 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5.75 9.53674e-007" />
                            <Vertex pos="0.25 5.75 -0.499999" />
                            <Vertex pos="0.25 -6.25 9.53674e-007" />
                            <Vertex pos="0.25 -6.25 -0.5" />
                            <Vertex pos="-0.25 6.25 0.500001" />
                            <Vertex pos="-0.25 6.25 -0.499999" />
                            <Vertex pos="-0.25 -6.25 0.500001" />
                            <Vertex pos="-0.25 -6.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 832 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.24264" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.25" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 8.44399e-008 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="-15.75 15.5 14.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.75 0 1 0 15.5 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.5" />
                            <Vertex pos="0.25 6 -0.499999" />
                            <Vertex pos="0.25 -6.5 0.5" />
                            <Vertex pos="0.25 -6.5 -0.5" />
                            <Vertex pos="-0.25 6.5 0.5" />
                            <Vertex pos="-0.25 6.5 -0.499999" />
                            <Vertex pos="-0.25 -6.5 0.5" />
                            <Vertex pos="-0.25 -6.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.41942" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.5" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 8.10623e-008 -1 -0.499999" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="-15.25 -5.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 -5.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.25 1.90735e-006" />
                            <Vertex pos="0.25 6.25 -0.5" />
                            <Vertex pos="0.25 -5.75 1.90735e-006" />
                            <Vertex pos="0.25 -5.75 -0.5" />
                            <Vertex pos="-0.25 6.25 0.500002" />
                            <Vertex pos="-0.25 6.25 -0.5" />
                            <Vertex pos="-0.25 -6.25 0.500002" />
                            <Vertex pos="-0.25 -6.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.25" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -4.24264" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-15.75 -5.5 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.75 0 1 0 -5.5 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.5 0.5" />
                            <Vertex pos="0.25 6.5 -0.5" />
                            <Vertex pos="0.25 -6 0.5" />
                            <Vertex pos="0.25 -6 -0.5" />
                            <Vertex pos="-0.25 6.5 0.5" />
                            <Vertex pos="-0.25 6.5 -0.5" />
                            <Vertex pos="-0.25 -6.5 0.5" />
                            <Vertex pos="-0.25 -6.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -4.41942" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="-6 -11.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -11.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 0.25 -1.90735e-006" />
                            <Vertex pos="9 0.25 -0.5" />
                            <Vertex pos="9.5 -0.25 0.5" />
                            <Vertex pos="9.5 -0.25 -0.5" />
                            <Vertex pos="-9 0.25 -1.90735e-006" />
                            <Vertex pos="-9 0.25 -0.5" />
                            <Vertex pos="-9.5 -0.25 0.5" />
                            <Vertex pos="-9.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -6.54074" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -6.54074" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707108 0.707105 -0.176776" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="-6 -11.75 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -11.75 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9.5 0.25 0.5" />
                            <Vertex pos="9.5 0.25 -0.5" />
                            <Vertex pos="10 -0.25 0.5" />
                            <Vertex pos="10 -0.25 -0.5" />
                            <Vertex pos="-9.5 0.25 0.5" />
                            <Vertex pos="-9.5 0.25 -0.5" />
                            <Vertex pos="-10 -0.25 0.5" />
                            <Vertex pos="-10 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -6.89429" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -6.89429" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="3.25 -1.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -1.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 10.25 0.500002" />
                            <Vertex pos="0.25 10.25 -0.500004" />
                            <Vertex pos="0.25 -10.25 0.500002" />
                            <Vertex pos="0.25 -10.25 -0.500004" />
                            <Vertex pos="-0.25 10.25 1.90735e-006" />
                            <Vertex pos="-0.25 10.25 -0.500004" />
                            <Vertex pos="-0.25 -9.75 1.90735e-006" />
                            <Vertex pos="-0.25 -9.75 -0.500004" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10.25" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -7.07107" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.500004" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="3.75 -1.5 18.5" rot="1 0 0 0" scale="" transform="1 0 0 3.75 0 1 0 -1.5 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 10.5 0.499998" />
                            <Vertex pos="0.25 10.5 -0.499998" />
                            <Vertex pos="0.25 -10.5 0.499998" />
                            <Vertex pos="0.25 -10.5 -0.499998" />
                            <Vertex pos="-0.25 10.5 0.499998" />
                            <Vertex pos="-0.25 10.5 -0.499998" />
                            <Vertex pos="-0.25 -10 0.499998" />
                            <Vertex pos="-0.25 -10 -0.499998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10.5" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -7.24784" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.499998" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.499998" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="-9.25 15 36.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.25 0 1 0 15 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 -3.8147e-006" />
                            <Vertex pos="0.25 6 -0.5" />
                            <Vertex pos="0.25 -6 -3.8147e-006" />
                            <Vertex pos="0.25 -6 -0.5" />
                            <Vertex pos="-0.25 6.5 0.499996" />
                            <Vertex pos="-0.25 6.5 -0.5" />
                            <Vertex pos="-0.25 -6.5 0.499996" />
                            <Vertex pos="-0.25 -6.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.41942" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -4.41942" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176774" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-9.75 15 36.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 15 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.5 0.5" />
                            <Vertex pos="0.25 6.5 -0.5" />
                            <Vertex pos="0.25 -6.5 0.5" />
                            <Vertex pos="0.25 -6.5 -0.5" />
                            <Vertex pos="-0.25 7 0.5" />
                            <Vertex pos="-0.25 7 -0.5" />
                            <Vertex pos="-0.25 -7 0.5" />
                            <Vertex pos="-0.25 -7 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -4.77297" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -4.77297" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-6.25 8.75 36.5" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 8.75 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.25 3.8147e-006" />
                            <Vertex pos="3.25 0.25 -0.5" />
                            <Vertex pos="2.75 -0.25 0.500004" />
                            <Vertex pos="2.75 -0.25 -0.5" />
                            <Vertex pos="-2.75 0.25 3.8147e-006" />
                            <Vertex pos="-2.75 0.25 -0.5" />
                            <Vertex pos="-3.25 -0.25 0.500004" />
                            <Vertex pos="-3.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176779" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -576 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-6.75 8.25 36.5" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 8.25 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.25 0.5" />
                            <Vertex pos="3.25 0.25 -0.5" />
                            <Vertex pos="2.75 -0.25 0.5" />
                            <Vertex pos="2.75 -0.25 -0.5" />
                            <Vertex pos="-2.75 0.25 0.5" />
                            <Vertex pos="-2.75 0.25 -0.5" />
                            <Vertex pos="-3.25 -0.25 0.5" />
                            <Vertex pos="-3.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 192 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-3.25 5.75 36.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 5.75 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.25 3.8147e-006" />
                            <Vertex pos="0.25 3.25 -0.5" />
                            <Vertex pos="0.25 -2.75 3.8147e-006" />
                            <Vertex pos="0.25 -2.75 -0.5" />
                            <Vertex pos="-0.25 2.75 0.500004" />
                            <Vertex pos="-0.25 2.75 -0.5" />
                            <Vertex pos="-0.25 -3.25 0.500004" />
                            <Vertex pos="-0.25 -3.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1600 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1728 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176779" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-3.75 5.25 36.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.75 0 1 0 5.25 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.25 0.5" />
                            <Vertex pos="0.25 3.25 -0.5" />
                            <Vertex pos="0.25 -2.75 0.5" />
                            <Vertex pos="0.25 -2.75 -0.5" />
                            <Vertex pos="-0.25 2.75 0.5" />
                            <Vertex pos="-0.25 2.75 -0.5" />
                            <Vertex pos="-0.25 -3.25 0.5" />
                            <Vertex pos="-0.25 -3.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1728 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1856 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="3.25 5.75 36.5" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 5.75 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.25 0.500004" />
                            <Vertex pos="0.25 3.25 -0.5" />
                            <Vertex pos="0.25 -3.25 0.500004" />
                            <Vertex pos="0.25 -3.25 -0.5" />
                            <Vertex pos="-0.25 3.25 3.8147e-006" />
                            <Vertex pos="-0.25 3.25 -0.5" />
                            <Vertex pos="-0.25 -2.75 3.8147e-006" />
                            <Vertex pos="-0.25 -2.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1216 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1088 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.25" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176779" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="3.75 5.5 36.5" rot="1 0 0 0" scale="" transform="1 0 0 3.75 0 1 0 5.5 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.5 0.5" />
                            <Vertex pos="0.25 3.5 -0.5" />
                            <Vertex pos="0.25 -3.5 0.5" />
                            <Vertex pos="0.25 -3.5 -0.5" />
                            <Vertex pos="-0.25 3.5 0.5" />
                            <Vertex pos="-0.25 3.5 -0.5" />
                            <Vertex pos="-0.25 -3 0.5" />
                            <Vertex pos="-0.25 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.5" album="" material="bm_edge_white" texgens="-1 0 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.2981" album="" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="0 2.75 36.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 2.75 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 3.8147e-006" />
                            <Vertex pos="3 0.25 -0.5" />
                            <Vertex pos="3.5 -0.25 0.500004" />
                            <Vertex pos="3.5 -0.25 -0.5" />
                            <Vertex pos="-3 0.25 3.8147e-006" />
                            <Vertex pos="-3 0.25 -0.5" />
                            <Vertex pos="-3.5 -0.25 0.500004" />
                            <Vertex pos="-3.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.2981" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.2981" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176779" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="0 2.25 36.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 2.25 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.5" />
                            <Vertex pos="3.5 0.25 -0.5" />
                            <Vertex pos="4 -0.25 0.5" />
                            <Vertex pos="4 -0.25 -0.5" />
                            <Vertex pos="-3.5 0.25 0.5" />
                            <Vertex pos="-3.5 0.25 -0.5" />
                            <Vertex pos="-4 -0.25 0.5" />
                            <Vertex pos="-4 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.65165" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.65165" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-9.25 21.25 36.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.25 0 1 0 21.25 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.250001 -0.250002 0" />
                            <Vertex pos="0.250001 -0.250002 -0.5" />
                            <Vertex pos="0.250001 0.25 0.5" />
                            <Vertex pos="0.250001 0.25 -0.5" />
                            <Vertex pos="-0.250001 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.250001" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707106 -7.16497e-007 -5.21541e-007" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1344 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707105 0.707108 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 704 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-9.5 21.75 36.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.5 0 1 0 21.75 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.5" />
                            <Vertex pos="0.5 0.25 -0.5" />
                            <Vertex pos="0.5 -0.25 0.5" />
                            <Vertex pos="0.5 -0.25 -0.5" />
                            <Vertex pos="-0.500001 0.25 0.5" />
                            <Vertex pos="-0.500001 0.25 -0.5" />
                            <Vertex pos="-9.53674e-007 -0.25 0.5" />
                            <Vertex pos="-9.53674e-007 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="10 6 1.625" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 6 0 0 1 1.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.125" />
                            <Vertex pos="1 3 -0.125" />
                            <Vertex pos="1 -3 0.125" />
                            <Vertex pos="1 -3 -0.125" />
                            <Vertex pos="-1 3 0.125" />
                            <Vertex pos="-1 3 -0.125" />
                            <Vertex pos="-1 -3 0.125" />
                            <Vertex pos="-1 -3 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 1536 0 0 -1 -416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 -1536 0 0 -1 -416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_tile06_B" texgens="1 0 0 768 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="10 12 1.75" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 12 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 3072 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 -3072 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_trim" texgens="1 0 0 2560 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="12.25 23.125 6.25" rot="1 0 0 0" scale="" transform="1 0 0 12.25 0 1 0 23.125 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.125 0.25" />
                            <Vertex pos="3.25 0.125 -0.25" />
                            <Vertex pos="3.25 -0.125 0.25" />
                            <Vertex pos="3.25 -0.125 -0.25" />
                            <Vertex pos="-3.25 0.125 0.25" />
                            <Vertex pos="-3.25 0.125 -0.25" />
                            <Vertex pos="-3.25 -0.125 0.25" />
                            <Vertex pos="-3.25 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.25" album="" material="bm_trim" texgens="0 1 0 5920 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="" material="bm_trim" texgens="0 -1 0 -5920 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -3136 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 3136 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 3136 0 -1 0 -5920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -3136 0 -1 0 -5920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="12.25 24.875 6.25" rot="1 0 0 0" scale="" transform="1 0 0 12.25 0 1 0 24.875 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.125 0.25" />
                            <Vertex pos="3.25 0.125 -0.25" />
                            <Vertex pos="3.25 -0.125 0.25" />
                            <Vertex pos="3.25 -0.125 -0.25" />
                            <Vertex pos="-3.25 0.125 0.25" />
                            <Vertex pos="-3.25 0.125 -0.25" />
                            <Vertex pos="-3.25 -0.125 0.25" />
                            <Vertex pos="-3.25 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.25" album="" material="bm_trim" texgens="0 1 0 6368 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="" material="bm_trim" texgens="0 -1 0 -6368 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -3136 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 3136 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 3136 0 -1 0 -6368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -3136 0 -1 0 -6368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="6.875 30 6.25" rot="1 0 0 0" scale="" transform="1 0 0 6.875 0 1 0 30 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 3 0.25" />
                            <Vertex pos="0.125 3 -0.25" />
                            <Vertex pos="0.125 -3 0.25" />
                            <Vertex pos="0.125 -3 -0.25" />
                            <Vertex pos="-0.125 3 0.25" />
                            <Vertex pos="-0.125 3 -0.25" />
                            <Vertex pos="-0.125 -3 0.25" />
                            <Vertex pos="-0.125 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 7680 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -7680 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_trim" texgens="-1 0 0 -1760 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_trim" texgens="1 0 0 1760 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 1760 0 -1 0 -7680 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -1760 0 -1 0 -7680 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="5.125 30 6.25" rot="1 0 0 0" scale="" transform="1 0 0 5.125 0 1 0 30 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 3 0.25" />
                            <Vertex pos="0.125 3 -0.25" />
                            <Vertex pos="0.125 -3 0.25" />
                            <Vertex pos="0.125 -3 -0.25" />
                            <Vertex pos="-0.125 3 0.25" />
                            <Vertex pos="-0.125 3 -0.25" />
                            <Vertex pos="-0.125 -3 0.25" />
                            <Vertex pos="-0.125 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 7680 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -7680 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_trim" texgens="-1 0 0 -1312 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_trim" texgens="1 0 0 1312 0 0 -1 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 1312 0 -1 0 -7680 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -1312 0 -1 0 -7680 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="-12.25 1.125 18.25" rot="1 0 0 0" scale="" transform="1 0 0 -12.25 0 1 0 1.125 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.125 0.25" />
                            <Vertex pos="3.25 0.125 -0.25" />
                            <Vertex pos="3.25 -0.125 0.25" />
                            <Vertex pos="3.25 -0.125 -0.25" />
                            <Vertex pos="-3.25 0.125 0.25" />
                            <Vertex pos="-3.25 0.125 -0.25" />
                            <Vertex pos="-3.25 -0.125 0.25" />
                            <Vertex pos="-3.25 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.25" album="" material="bm_trim" texgens="0 1 0 288 0 0 -1 -4672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="" material="bm_trim" texgens="0 -1 0 -288 0 0 -1 -4672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 3136 0 0 -1 -4672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -3136 0 0 -1 -4672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -3136 0 -1 0 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 3136 0 -1 0 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="-12.25 8.875 14.25" rot="1 0 0 0" scale="" transform="1 0 0 -12.25 0 1 0 8.875 0 0 1 14.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.125 0.25" />
                            <Vertex pos="3.25 0.125 -0.25" />
                            <Vertex pos="3.25 -0.125 0.25" />
                            <Vertex pos="3.25 -0.125 -0.25" />
                            <Vertex pos="-3.25 0.125 0.25" />
                            <Vertex pos="-3.25 0.125 -0.25" />
                            <Vertex pos="-3.25 -0.125 0.25" />
                            <Vertex pos="-3.25 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.25" album="" material="bm_trim" texgens="0 1 0 2272 0 0 -1 -3648 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="" material="bm_trim" texgens="0 -1 0 -2272 0 0 -1 -3648 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 3136 0 0 -1 -3648 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -3136 0 0 -1 -3648 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -3136 0 -1 0 -2272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 3136 0 -1 0 -2272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="-8.875 5 18.625" rot="1 0 0 0" scale="" transform="1 0 0 -8.875 0 1 0 5 0 0 1 18.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.125" />
                            <Vertex pos="0.125 4 -0.125" />
                            <Vertex pos="0.125 -4 0.125" />
                            <Vertex pos="0.125 -4 -0.125" />
                            <Vertex pos="-0.125 4 0.125" />
                            <Vertex pos="-0.125 4 -0.125" />
                            <Vertex pos="-0.125 -4 0.125" />
                            <Vertex pos="-0.125 -4 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 2560 0 0 -1 -9536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -2560 0 0 -1 -9536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_wood" texgens="-1 0 0 4544 0 0 -1 -9536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_wood" texgens="1 0 0 -4544 0 0 -1 -9536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 -4544 0 -1 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 4544 0 -1 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="-8.875 5 24.375" rot="1 0 0 0" scale="" transform="1 0 0 -8.875 0 1 0 5 0 0 1 24.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.125" />
                            <Vertex pos="0.125 4 -0.125" />
                            <Vertex pos="0.125 -4 0.125" />
                            <Vertex pos="0.125 -4 -0.125" />
                            <Vertex pos="-0.125 4 0.125" />
                            <Vertex pos="-0.125 4 -0.125" />
                            <Vertex pos="-0.125 -4 0.125" />
                            <Vertex pos="-0.125 -4 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 2560 0 0 -1 -12480 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -2560 0 0 -1 -12480 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_wood" texgens="-1 0 0 4544 0 0 -1 -12480 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_wood" texgens="1 0 0 -4544 0 0 -1 -12480 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 -4544 0 -1 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 4544 0 -1 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="-8.875 8.875 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -8.875 0 1 0 8.875 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 2.75" />
                            <Vertex pos="0.125 0.125 -2.75" />
                            <Vertex pos="0.125 -0.125 2.75" />
                            <Vertex pos="0.125 -0.125 -2.75" />
                            <Vertex pos="-0.125 0.125 2.75" />
                            <Vertex pos="-0.125 0.125 -2.75" />
                            <Vertex pos="-0.125 -0.125 2.75" />
                            <Vertex pos="-0.125 -0.125 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 4544 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -4544 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 4544 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 -4544 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.75" album="" material="bm_wood" texgens="1 0 0 -4544 0 -1 0 -4544 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.75" album="" material="bm_wood" texgens="-1 0 0 4544 0 -1 0 -4544 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="-8.875 1.125 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -8.875 0 1 0 1.125 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 2.75" />
                            <Vertex pos="0.125 0.125 -2.75" />
                            <Vertex pos="0.125 -0.125 2.75" />
                            <Vertex pos="0.125 -0.125 -2.75" />
                            <Vertex pos="-0.125 0.125 2.75" />
                            <Vertex pos="-0.125 0.125 -2.75" />
                            <Vertex pos="-0.125 -0.125 2.75" />
                            <Vertex pos="-0.125 -0.125 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 576 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -576 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 4544 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 -4544 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.75" album="" material="bm_wood" texgens="1 0 0 -4544 0 -1 0 -576 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.75" album="" material="bm_wood" texgens="-1 0 0 4544 0 -1 0 -576 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="-3.125 5 18.625" rot="1 0 0 0" scale="" transform="1 0 0 -3.125 0 1 0 5 0 0 1 18.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.125" />
                            <Vertex pos="0.125 4 -0.125" />
                            <Vertex pos="0.125 -4 0.125" />
                            <Vertex pos="0.125 -4 -0.125" />
                            <Vertex pos="-0.125 4 0.125" />
                            <Vertex pos="-0.125 4 -0.125" />
                            <Vertex pos="-0.125 -4 0.125" />
                            <Vertex pos="-0.125 -4 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 2560 0 0 -1 -9536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -2560 0 0 -1 -9536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_wood" texgens="-1 0 0 1600 0 0 -1 -9536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_wood" texgens="1 0 0 -1600 0 0 -1 -9536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 -1600 0 -1 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 1600 0 -1 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="-3.125 5 24.375" rot="1 0 0 0" scale="" transform="1 0 0 -3.125 0 1 0 5 0 0 1 24.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.125" />
                            <Vertex pos="0.125 4 -0.125" />
                            <Vertex pos="0.125 -4 0.125" />
                            <Vertex pos="0.125 -4 -0.125" />
                            <Vertex pos="-0.125 4 0.125" />
                            <Vertex pos="-0.125 4 -0.125" />
                            <Vertex pos="-0.125 -4 0.125" />
                            <Vertex pos="-0.125 -4 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 2560 0 0 -1 -12480 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -2560 0 0 -1 -12480 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_wood" texgens="-1 0 0 1600 0 0 -1 -12480 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_wood" texgens="1 0 0 -1600 0 0 -1 -12480 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 -1600 0 -1 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 1600 0 -1 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="-3.125 8.875 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.125 0 1 0 8.875 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 2.75" />
                            <Vertex pos="0.125 0.125 -2.75" />
                            <Vertex pos="0.125 -0.125 2.75" />
                            <Vertex pos="0.125 -0.125 -2.75" />
                            <Vertex pos="-0.125 0.125 2.75" />
                            <Vertex pos="-0.125 0.125 -2.75" />
                            <Vertex pos="-0.125 -0.125 2.75" />
                            <Vertex pos="-0.125 -0.125 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 4544 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -4544 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 1600 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 -1600 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.75" album="" material="bm_wood" texgens="1 0 0 -1600 0 -1 0 -4544 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.75" album="" material="bm_wood" texgens="-1 0 0 1600 0 -1 0 -4544 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="-3.125 1.125 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.125 0 1 0 1.125 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 2.75" />
                            <Vertex pos="0.125 0.125 -2.75" />
                            <Vertex pos="0.125 -0.125 2.75" />
                            <Vertex pos="0.125 -0.125 -2.75" />
                            <Vertex pos="-0.125 0.125 2.75" />
                            <Vertex pos="-0.125 0.125 -2.75" />
                            <Vertex pos="-0.125 -0.125 2.75" />
                            <Vertex pos="-0.125 -0.125 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 576 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -576 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 1600 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 -1600 0 0 -1 -11008 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.75" album="" material="bm_wood" texgens="1 0 0 -1600 0 -1 0 -576 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.75" album="" material="bm_wood" texgens="-1 0 0 1600 0 -1 0 -576 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="15" type="4" pos="1 18 6.75" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 18 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.25" />
                            <Vertex pos="2 3 -0.25" />
                            <Vertex pos="2 -3 0.25" />
                            <Vertex pos="2 -3 -0.25" />
                            <Vertex pos="-4 3 0.25" />
                            <Vertex pos="-4 3 -0.25" />
                            <Vertex pos="-4 -3 0.25" />
                            <Vertex pos="-4 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="20" type="4" pos="0 6 18.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 6 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="3 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_B" texgens="1 0 0 -768 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
