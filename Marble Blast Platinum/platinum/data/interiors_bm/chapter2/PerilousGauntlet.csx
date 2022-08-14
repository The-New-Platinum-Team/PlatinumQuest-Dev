<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2022/06/19 12:42:45">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="22">
        <SceneShape id="11" type="1" entityID="18" dl="0" group="-1" locked="0" />
        <SceneShape id="12" type="1" entityID="19" dl="0" group="-1" locked="0" />
        <SceneShape id="13" type="1" entityID="22" dl="0" group="-1" locked="0" />
        <SceneShape id="14" type="1" entityID="23" dl="0" group="-1" locked="0" />
        <SceneShape id="15" type="1" entityID="24" dl="0" group="-1" locked="0" />
        <SceneShape id="16" type="1" entityID="26" dl="0" group="-1" locked="0" />
        <SceneShape id="17" type="1" entityID="27" dl="0" group="-1" locked="0" />
        <SceneShape id="18" type="1" entityID="28" dl="0" group="-1" locked="0" />
        <SceneShape id="19" type="1" entityID="30" dl="0" group="-1" locked="0" />
        <SceneShape id="20" type="1" entityID="31" dl="0" group="-1" locked="0" />
        <SceneShape id="21" type="1" entityID="32" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="33">
                    <Entity id="13" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="32" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="4" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="17" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="18" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 8 0" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="19" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 32 6" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="20" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="21" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="22" classname="path_node" gametype="Torque" isPointEntity="1" origin="31 17 25.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="23" classname="path_node" gametype="Torque" isPointEntity="1" origin="17 17 25.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="24" classname="path_node" gametype="Torque" isPointEntity="1" origin="31 17 25.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="25" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="26" classname="path_node" gametype="Torque" isPointEntity="1" origin="17 24 25.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="27" classname="path_node" gametype="Torque" isPointEntity="1" origin="31 24 25.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="28" classname="path_node" gametype="Torque" isPointEntity="1" origin="17 24 25.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="29" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="30" classname="path_node" gametype="Torque" isPointEntity="1" origin="31 31 25.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="31" classname="path_node" gametype="Torque" isPointEntity="1" origin="17 31 25.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="32" classname="path_node" gametype="Torque" isPointEntity="1" origin="31 31 25.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="115">
                    <Brush id="0" owner="-1" type="0" pos="0 -4 0" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -4 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 8 0.5" />
                            <Vertex pos="4 8 -0.5" />
                            <Vertex pos="4 -8 0.5" />
                            <Vertex pos="4 -8 -0.5" />
                            <Vertex pos="-4 8 0.5" />
                            <Vertex pos="-4 8 -0.5" />
                            <Vertex pos="-4 -8 0.5" />
                            <Vertex pos="-4 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_trim" texgens="-1 0 0 -384 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="-1" type="0" pos="24 1 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 1 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 11 8" />
                            <Vertex pos="12 11 -8" />
                            <Vertex pos="12 -11 8" />
                            <Vertex pos="12 -11 -8" />
                            <Vertex pos="-12 11 8" />
                            <Vertex pos="-12 11 -8" />
                            <Vertex pos="-12 -11 8" />
                            <Vertex pos="-12 -11 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -1152 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 1408 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11" album="" material="bm_grid_blank_water" texgens="1 0 0 1536 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile06_D" texgens="1 0 0 -2560 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="-1" type="0" pos="32 1 14.5" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 1 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 11 8" />
                            <Vertex pos="4 11 -8" />
                            <Vertex pos="4 -11 8" />
                            <Vertex pos="4 -11 -8" />
                            <Vertex pos="-4 11 8" />
                            <Vertex pos="-4 11 -8" />
                            <Vertex pos="-4 -11 8" />
                            <Vertex pos="-4 -11 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1152 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1408 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="-1" type="0" pos="16 1 14.5" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 1 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 11 8" />
                            <Vertex pos="4 11 -8" />
                            <Vertex pos="4 -11 8" />
                            <Vertex pos="4 -11 -8" />
                            <Vertex pos="-4 11 8" />
                            <Vertex pos="-4 11 -8" />
                            <Vertex pos="-4 -11 8" />
                            <Vertex pos="-4 -11 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1152 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1408 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="-1" type="0" pos="24 24 5.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 24 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 12 1" />
                            <Vertex pos="4 12 -1" />
                            <Vertex pos="4 -12 1" />
                            <Vertex pos="4 -12 -1" />
                            <Vertex pos="-4 12 1" />
                            <Vertex pos="-4 12 -1" />
                            <Vertex pos="-4 -12 1" />
                            <Vertex pos="-4 -12 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="-1" type="0" pos="19 24 5.5" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 24 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 12 3" />
                            <Vertex pos="1 12 -3" />
                            <Vertex pos="1 -12 3" />
                            <Vertex pos="1 -12 -3" />
                            <Vertex pos="-1 12 3" />
                            <Vertex pos="-1 12 -3" />
                            <Vertex pos="-1 -12 3" />
                            <Vertex pos="-1 -12 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="-1" type="0" pos="29 24 5.5" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 24 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 12 3" />
                            <Vertex pos="1 12 -3" />
                            <Vertex pos="1 -12 3" />
                            <Vertex pos="1 -12 -3" />
                            <Vertex pos="-1 12 3" />
                            <Vertex pos="-1 12 -3" />
                            <Vertex pos="-1 -12 3" />
                            <Vertex pos="-1 -12 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="-1" type="0" pos="29 17 10.5" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 17 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 5 2" />
                            <Vertex pos="1 5 -2" />
                            <Vertex pos="1 -5 2" />
                            <Vertex pos="1 -5 -2" />
                            <Vertex pos="-1 5 2" />
                            <Vertex pos="-1 5 -2" />
                            <Vertex pos="-1 -5 2" />
                            <Vertex pos="-1 -5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="-1" type="0" pos="29 31 10.5" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 31 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 5 2" />
                            <Vertex pos="1 5 -2" />
                            <Vertex pos="1 -5 2" />
                            <Vertex pos="1 -5 -2" />
                            <Vertex pos="-1 5 2" />
                            <Vertex pos="-1 5 -2" />
                            <Vertex pos="-1 -5 2" />
                            <Vertex pos="-1 -5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="-1" type="0" pos="19 17 10.5" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 17 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 5 2" />
                            <Vertex pos="1 5 -2" />
                            <Vertex pos="1 -5 2" />
                            <Vertex pos="1 -5 -2" />
                            <Vertex pos="-1 5 2" />
                            <Vertex pos="-1 5 -2" />
                            <Vertex pos="-1 -5 2" />
                            <Vertex pos="-1 -5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="-1" type="0" pos="19 31 10.5" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 31 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 5 2" />
                            <Vertex pos="1 5 -2" />
                            <Vertex pos="1 -5 2" />
                            <Vertex pos="1 -5 -2" />
                            <Vertex pos="-1 5 2" />
                            <Vertex pos="-1 5 -2" />
                            <Vertex pos="-1 -5 2" />
                            <Vertex pos="-1 -5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="-1" type="0" pos="19 24 13.5" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 24 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 12 1" />
                            <Vertex pos="1 12 -1" />
                            <Vertex pos="1 -12 1" />
                            <Vertex pos="1 -12 -1" />
                            <Vertex pos="-1 12 1" />
                            <Vertex pos="-1 12 -1" />
                            <Vertex pos="-1 -12 1" />
                            <Vertex pos="-1 -12 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="-1" type="0" pos="29 24 13.5" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 24 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 12 1" />
                            <Vertex pos="1 12 -1" />
                            <Vertex pos="1 -12 1" />
                            <Vertex pos="1 -12 -1" />
                            <Vertex pos="-1 12 1" />
                            <Vertex pos="-1 12 -1" />
                            <Vertex pos="-1 -12 1" />
                            <Vertex pos="-1 -12 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 2944 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="-1" type="0" pos="24 24 17" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 24 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 12 0.5" />
                            <Vertex pos="6.5 12 -0.5" />
                            <Vertex pos="6.5 -12 0.5" />
                            <Vertex pos="6.5 -12 -0.5" />
                            <Vertex pos="-6.5 12 0.5" />
                            <Vertex pos="-6.5 12 -0.5" />
                            <Vertex pos="-6.5 -12 0.5" />
                            <Vertex pos="-6.5 -12 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_grid_blank3" texgens="0 1 0 -2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank3" texgens="-1 0 0 -6016 0 0 -1 -3712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank3" texgens="1 0 0 6272 0 0 -1 -3712 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -1408 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -1408 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="-1" type="0" pos="24 52 5.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 52 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 8 1" />
                            <Vertex pos="12 8 -1" />
                            <Vertex pos="12 -8 1" />
                            <Vertex pos="12 -8 -1" />
                            <Vertex pos="-12 8 1" />
                            <Vertex pos="-12 8 -1" />
                            <Vertex pos="-12 -8 1" />
                            <Vertex pos="-12 -8 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile06_D" texgens="1 0 0 -2560 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="-1" type="0" pos="32 52 10.5" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 52 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 8 4" />
                            <Vertex pos="4 8 -4" />
                            <Vertex pos="4 -8 4" />
                            <Vertex pos="4 -8 -4" />
                            <Vertex pos="-4 8 4" />
                            <Vertex pos="-4 8 -4" />
                            <Vertex pos="-4 -8 4" />
                            <Vertex pos="-4 -8 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="-1" type="0" pos="20 56 10.5" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 56 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 4 4" />
                            <Vertex pos="8 4 -4" />
                            <Vertex pos="8 -4 4" />
                            <Vertex pos="8 -4 -4" />
                            <Vertex pos="-8 4 4" />
                            <Vertex pos="-8 4 -4" />
                            <Vertex pos="-8 -4 4" />
                            <Vertex pos="-8 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2816 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 3072 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 3072 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2816 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="-1" type="0" pos="16 40 9.5" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 40 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 5" />
                            <Vertex pos="4 4 -5" />
                            <Vertex pos="4 -4 5" />
                            <Vertex pos="4 -4 -5" />
                            <Vertex pos="-4 4 5" />
                            <Vertex pos="-4 4 -5" />
                            <Vertex pos="-4 -4 5" />
                            <Vertex pos="-4 -4 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="-1" type="0" pos="0 44 6" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 44 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 8 0.5" />
                            <Vertex pos="4 8 -0.5" />
                            <Vertex pos="4 -8 0.5" />
                            <Vertex pos="4 -8 -0.5" />
                            <Vertex pos="-4 8 0.5" />
                            <Vertex pos="-4 8 -0.5" />
                            <Vertex pos="-4 -8 0.5" />
                            <Vertex pos="-4 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_trim" texgens="1 0 0 -384 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="-1" type="0" pos="8 48 6" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 48 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="-1" type="0" pos="32 40 9.5" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 40 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 5" />
                            <Vertex pos="4 4 -5" />
                            <Vertex pos="4 -4 5" />
                            <Vertex pos="4 -4 -5" />
                            <Vertex pos="-4 4 5" />
                            <Vertex pos="-4 4 -5" />
                            <Vertex pos="-4 -4 5" />
                            <Vertex pos="-4 -4 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="-1" type="0" pos="24 48 18.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 48 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 12 4" />
                            <Vertex pos="12 12 -4" />
                            <Vertex pos="12 -12 4" />
                            <Vertex pos="12 -12 -4" />
                            <Vertex pos="-12 12 4" />
                            <Vertex pos="-12 12 -4" />
                            <Vertex pos="-12 -12 4" />
                            <Vertex pos="-12 -12 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="-1" type="0" pos="24 -7 14.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -7 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 8" />
                            <Vertex pos="4 3 -8" />
                            <Vertex pos="4 -3 8" />
                            <Vertex pos="4 -3 -8" />
                            <Vertex pos="-4 3 8" />
                            <Vertex pos="-4 3 -8" />
                            <Vertex pos="-4 -3 8" />
                            <Vertex pos="-4 -3 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -2176 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2432 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank_water" texgens="1 0 0 2560 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="-1" type="0" pos="24 8 18.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 8 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 4" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -4 4" />
                            <Vertex pos="4 -4 -4" />
                            <Vertex pos="-4 4 4" />
                            <Vertex pos="-4 4 -4" />
                            <Vertex pos="-4 -4 4" />
                            <Vertex pos="-4 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -2304 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2560 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="-1" type="0" pos="24 8.25 23" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 8.25 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.5 4.25 0.5" />
                            <Vertex pos="12.5 4.25 -0.5" />
                            <Vertex pos="12.5 -4.25 0.5" />
                            <Vertex pos="12.5 -4.25 -0.5" />
                            <Vertex pos="-12.5 4.25 0.5" />
                            <Vertex pos="-12.5 4.25 -0.5" />
                            <Vertex pos="-12.5 -4.25 0.5" />
                            <Vertex pos="-12.5 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12.5" album="" material="bm_grid_blank3" texgens="0 1 0 2240 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -1984 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_grid_blank3" texgens="-1 0 0 -6016 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_grid_blank3" texgens="1 0 0 6272 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 6272 0 -1 0 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -6016 0 -1 0 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="-1" type="0" pos="24 -8.25 23" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -8.25 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.5 4.25 0.5" />
                            <Vertex pos="12.5 4.25 -0.5" />
                            <Vertex pos="12.5 -4.25 0.5" />
                            <Vertex pos="12.5 -4.25 -0.5" />
                            <Vertex pos="-12.5 4.25 0.5" />
                            <Vertex pos="-12.5 4.25 -0.5" />
                            <Vertex pos="-12.5 -4.25 0.5" />
                            <Vertex pos="-12.5 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12.5" album="" material="bm_grid_blank3" texgens="0 1 0 -1984 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12.5" album="" material="bm_grid_blank3" texgens="0 -1 0 2240 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_grid_blank3" texgens="-1 0 0 -6016 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_grid_blank3" texgens="1 0 0 6272 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 6272 0 -1 0 2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -6016 0 -1 0 2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="-1" type="0" pos="15.75 0 23" rot="1 0 0 0" scale="" transform="1 0 0 15.75 0 1 0 0 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 4 0.5" />
                            <Vertex pos="4.25 4 -0.5" />
                            <Vertex pos="4.25 -4 0.5" />
                            <Vertex pos="4.25 -4 -0.5" />
                            <Vertex pos="-4.25 4 0.5" />
                            <Vertex pos="-4.25 4 -0.5" />
                            <Vertex pos="-4.25 -4 0.5" />
                            <Vertex pos="-4.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 1 0 128 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 -1 0 128 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -3904 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 4160 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 4160 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -3904 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="-1" type="0" pos="32.25 0 23" rot="1 0 0 0" scale="" transform="1 0 0 32.25 0 1 0 0 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 4 0.5" />
                            <Vertex pos="4.25 4 -0.5" />
                            <Vertex pos="4.25 -4 0.5" />
                            <Vertex pos="4.25 -4 -0.5" />
                            <Vertex pos="-4.25 4 0.5" />
                            <Vertex pos="-4.25 4 -0.5" />
                            <Vertex pos="-4.25 -4 0.5" />
                            <Vertex pos="-4.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 1 0 128 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 -1 0 128 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -8128 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 8384 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 8384 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -8128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="-1" type="0" pos="24 9 24" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 9 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 5 0.5" />
                            <Vertex pos="4 5 -0.5" />
                            <Vertex pos="4 -5 0.5" />
                            <Vertex pos="4 -5 -0.5" />
                            <Vertex pos="-4 5 0.5" />
                            <Vertex pos="-4 5 -0.5" />
                            <Vertex pos="-4 -5 0.5" />
                            <Vertex pos="-4 -5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_D" texgens="1 0 0 1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="-1" type="0" pos="24 39 24" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 39 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 5 0.5" />
                            <Vertex pos="4 5 -0.5" />
                            <Vertex pos="4 -5 0.5" />
                            <Vertex pos="4 -5 -0.5" />
                            <Vertex pos="-4 5 0.5" />
                            <Vertex pos="-4 5 -0.5" />
                            <Vertex pos="-4 -5 0.5" />
                            <Vertex pos="-4 -5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_D" texgens="1 0 0 1024 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="-1" type="0" pos="24 48 23" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 48 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.5 12.5 0.5" />
                            <Vertex pos="12.5 12.5 -0.5" />
                            <Vertex pos="12.5 -12.5 0.5" />
                            <Vertex pos="12.5 -12.5 -0.5" />
                            <Vertex pos="-12.5 12.5 0.5" />
                            <Vertex pos="-12.5 12.5 -0.5" />
                            <Vertex pos="-12.5 -12.5 0.5" />
                            <Vertex pos="-12.5 -12.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12.5" album="" material="bm_grid_blank3" texgens="0 1 0 12416 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -12160 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -6016 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12.5" album="" material="bm_grid_blank3" texgens="1 0 0 6272 0 0 -1 -5760 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 6272 0 -1 0 -12160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -6016 0 -1 0 -12160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="-1" type="0" pos="24 24 24" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 24 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 10 0.5" />
                            <Vertex pos="4 10 -0.5" />
                            <Vertex pos="4 -10 0.5" />
                            <Vertex pos="4 -10 -0.5" />
                            <Vertex pos="-4 10 0.5" />
                            <Vertex pos="-4 10 -0.5" />
                            <Vertex pos="-4 -10 0.5" />
                            <Vertex pos="-4 -10 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="-1" type="0" pos="24 43 6.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 43 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 2.38419e-006" />
                            <Vertex pos="4 1 -1" />
                            <Vertex pos="4 -0.999996 1" />
                            <Vertex pos="4 -0.999996 -1.90735e-006" />
                            <Vertex pos="-4 1 2.38419e-006" />
                            <Vertex pos="-4 1 -1" />
                            <Vertex pos="-4 -0.999996 1" />
                            <Vertex pos="-4 -0.999996 -1.90735e-006" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.999996" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447213 0.894427 -0.447216" album="" material="bm_friction_grass" texgens="1 0 0 1024 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447214" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="-1" type="0" pos="24 37 6.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 37 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.999996 1" />
                            <Vertex pos="4 0.999996 -1.43051e-006" />
                            <Vertex pos="4 -1 1.43051e-006" />
                            <Vertex pos="4 -1 -1" />
                            <Vertex pos="-4 0.999996 1" />
                            <Vertex pos="-4 0.999996 -1.43051e-006" />
                            <Vertex pos="-4 -1 1.43051e-006" />
                            <Vertex pos="-4 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.999996" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447215" album="" material="bm_friction_grass" texgens="1 0 0 1024 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447213" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="-1" type="0" pos="29 48 24" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 48 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 4 0.5" />
                            <Vertex pos="9 4 -0.5" />
                            <Vertex pos="9 -4 0.5" />
                            <Vertex pos="9 -4 -0.5" />
                            <Vertex pos="-9 4 0.5" />
                            <Vertex pos="-9 4 -0.5" />
                            <Vertex pos="-9 -4 0.5" />
                            <Vertex pos="-9 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_D" texgens="1 0 0 2304 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="-1" type="0" pos="42 48 14" rot="1 0 0 0" scale="" transform="1 0 0 42 0 1 0 48 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 0.5" />
                            <Vertex pos="6 4 -0.5" />
                            <Vertex pos="6 -4 0.5" />
                            <Vertex pos="6 -4 -0.5" />
                            <Vertex pos="-6 4 0.5" />
                            <Vertex pos="-6 4 -0.5" />
                            <Vertex pos="-6 -4 0.5" />
                            <Vertex pos="-6 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 1536 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="-1" type="0" pos="44 40 12" rot="1 0 0 0" scale="" transform="1 0 0 44 0 1 0 40 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 2.5" />
                            <Vertex pos="4 4 1.5" />
                            <Vertex pos="4 -4 -1.5" />
                            <Vertex pos="4 -4 -2.5" />
                            <Vertex pos="-4 4 2.5" />
                            <Vertex pos="-4 4 1.5" />
                            <Vertex pos="-4 -4 -1.5" />
                            <Vertex pos="-4 -4 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_tile06_D" texgens="1 0 0 1024 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="-1" type="0" pos="44 32 10" rot="1 0 0 0" scale="" transform="1 0 0 44 0 1 0 32 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 2048 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="-1" type="0" pos="24 40 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 40 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 6" />
                            <Vertex pos="4 4 -6" />
                            <Vertex pos="4 -4 6" />
                            <Vertex pos="4 -4 -6" />
                            <Vertex pos="-4 4 6" />
                            <Vertex pos="-4 4 -6" />
                            <Vertex pos="-4 -4 6" />
                            <Vertex pos="-4 -4 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_grid_blank_water" texgens="1 0 0 2560 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="-1" type="0" pos="27 34 -8" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 34 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 2 0.5" />
                            <Vertex pos="7 2 -0.5" />
                            <Vertex pos="7 -2 0.5" />
                            <Vertex pos="7 -2 -0.5" />
                            <Vertex pos="-7 2 0.5" />
                            <Vertex pos="-7 2 -0.5" />
                            <Vertex pos="-7 -2 0.5" />
                            <Vertex pos="-7 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_trim" texgens="0 1 0 -128 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 1280 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="-1" type="0" pos="24 26 -8" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 26 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 0.5" />
                            <Vertex pos="4 6 -0.5" />
                            <Vertex pos="4 -6 0.5" />
                            <Vertex pos="4 -6 -0.5" />
                            <Vertex pos="-4 6 0.5" />
                            <Vertex pos="-4 6 -0.5" />
                            <Vertex pos="-4 -6 0.5" />
                            <Vertex pos="-4 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="-1" type="0" pos="37 34 10" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 34 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 0.5" />
                            <Vertex pos="3 2 -0.5" />
                            <Vertex pos="3 -2 0.5" />
                            <Vertex pos="3 -2 -0.5" />
                            <Vertex pos="-3 2 0.5" />
                            <Vertex pos="-3 2 -0.5" />
                            <Vertex pos="-3 -2 0.5" />
                            <Vertex pos="-3 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_trim" texgens="0 -1 0 -128 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 2304 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 2304 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="-1" type="0" pos="30 16 -8" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 16 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 4 0.5" />
                            <Vertex pos="10 4 -0.5" />
                            <Vertex pos="10 -4 0.5" />
                            <Vertex pos="10 -4 -0.5" />
                            <Vertex pos="-10 4 0.5" />
                            <Vertex pos="-10 4 -0.5" />
                            <Vertex pos="-10 -4 0.5" />
                            <Vertex pos="-10 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 2048 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="-1" type="0" pos="24 24 15.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 24 0 0 1 15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 12 1" />
                            <Vertex pos="6 12 -1" />
                            <Vertex pos="6 -12 1" />
                            <Vertex pos="6 -12 -1" />
                            <Vertex pos="-6 12 1" />
                            <Vertex pos="-6 12 -1" />
                            <Vertex pos="-6 -12 1" />
                            <Vertex pos="-6 -12 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -2048 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -2048 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="-1" type="0" pos="38 0 -8" rot="1 0 0 0" scale="" transform="1 0 0 38 0 1 0 0 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 12 0.5" />
                            <Vertex pos="2 12 -0.5" />
                            <Vertex pos="2 -12 0.5" />
                            <Vertex pos="2 -12 -0.5" />
                            <Vertex pos="-2 12 0.5" />
                            <Vertex pos="-2 12 -0.5" />
                            <Vertex pos="-2 -12 0.5" />
                            <Vertex pos="-2 -12 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_edge_white" texgens="-1 0 0 -3968 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_edge_white" texgens="1 0 0 4096 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_mud" texgens="1 0 0 0 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1792 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="-1" type="0" pos="30 -16 -8" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 -16 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 4 0.5" />
                            <Vertex pos="10 4 -0.5" />
                            <Vertex pos="10 -4 0.5" />
                            <Vertex pos="10 -4 -0.5" />
                            <Vertex pos="-10 4 0.5" />
                            <Vertex pos="-10 4 -0.5" />
                            <Vertex pos="-10 -4 0.5" />
                            <Vertex pos="-10 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 2048 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="-1" type="0" pos="32 -11 6.5" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 -11 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 16" />
                            <Vertex pos="4 1 -16" />
                            <Vertex pos="4 -1 16" />
                            <Vertex pos="4 -1 -16" />
                            <Vertex pos="-4 1 16" />
                            <Vertex pos="-4 1 -16" />
                            <Vertex pos="-4 -1 16" />
                            <Vertex pos="-4 -1 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank_water" texgens="0 -1 0 128 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="-1" type="0" pos="16 -11 6.5" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -11 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 16" />
                            <Vertex pos="4 1 -16" />
                            <Vertex pos="4 -1 16" />
                            <Vertex pos="4 -1 -16" />
                            <Vertex pos="-4 1 16" />
                            <Vertex pos="-4 1 -16" />
                            <Vertex pos="-4 -1 16" />
                            <Vertex pos="-4 -1 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank_water" texgens="0 1 0 128 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="-1" type="0" pos="24 -11 -8.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -11 0 0 1 -8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 1" />
                            <Vertex pos="4 1 -1" />
                            <Vertex pos="4 -1 1" />
                            <Vertex pos="4 -1 -1" />
                            <Vertex pos="-4 1 1" />
                            <Vertex pos="-4 1 -1" />
                            <Vertex pos="-4 -1 1" />
                            <Vertex pos="-4 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank_water" texgens="1 0 0 2560 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="-1" type="0" pos="24 -11 18.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -11 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 4" />
                            <Vertex pos="4 1 -4" />
                            <Vertex pos="4 -1 4" />
                            <Vertex pos="4 -1 -4" />
                            <Vertex pos="-4 1 4" />
                            <Vertex pos="-4 1 -4" />
                            <Vertex pos="-4 -1 4" />
                            <Vertex pos="-4 -1 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank_water" texgens="-1 0 0 -2304 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="-1" type="0" pos="21 -11 -5.5" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -11 0 0 1 -5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -1920 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_tile07_D" texgens="1 0 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 2176 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1920 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="-1" type="0" pos="25 -11 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 -11 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -1920 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_tile07_D" texgens="1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 2176 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -1920 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="-1" type="0" pos="23 -11 5.5" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 -11 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -1920 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_tile07_D" texgens="1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 2176 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -1920 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="-1" type="0" pos="24 -11.5 12.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -11.5 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1.5 2" />
                            <Vertex pos="2 1.5 -2" />
                            <Vertex pos="2 -1.5 2" />
                            <Vertex pos="2 -0.500001 -2" />
                            <Vertex pos="-2 1.5 2" />
                            <Vertex pos="-2 1.5 -2" />
                            <Vertex pos="-2 -1.5 2" />
                            <Vertex pos="-2 -0.500001 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 64 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 192 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1792 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.970143 -0.242535 -0.970143" album="" material="bm_tile07_D" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 2048 0 -1 0 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1792 0 -1 0 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="-1" type="0" pos="24 -12.5 18.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -12.5 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 4" />
                            <Vertex pos="4 0.5 -4" />
                            <Vertex pos="4 -0.5 4" />
                            <Vertex pos="4 -0.5 -4" />
                            <Vertex pos="-4 0.5 4" />
                            <Vertex pos="-4 0.5 -4" />
                            <Vertex pos="-4 -0.5 4" />
                            <Vertex pos="-4 -0.5 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_tile07_D" texgens="1 0 0 1024 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="-1" type="0" pos="24 -3.5 21.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -3.5 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="4 -0.5 0.999998" />
                            <Vertex pos="4 0.5 -1" />
                            <Vertex pos="4 -0.5 -1" />
                            <Vertex pos="-4 -0.5 0.999998" />
                            <Vertex pos="-4 0.5 -1" />
                            <Vertex pos="-4 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -2496 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2752 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0 0.894427 0.447214 4.47035e-007" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 2752 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="-1" type="0" pos="24 -3.5 18.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -3.5 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="4 -0.5 -2" />
                            <Vertex pos="4 0.5 2" />
                            <Vertex pos="4 -0.5 2" />
                            <Vertex pos="-4 -0.5 -2" />
                            <Vertex pos="-4 0.5 2" />
                            <Vertex pos="-4 -0.5 2" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -2496 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 2752 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                        <Face id="2" plane="0 0.970143 -0.242536 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="3" plane="-0 -1 -0 -0.5" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 2752 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="-1" type="0" pos="24 48 -21.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 48 0 0 1 -21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 12 12" />
                            <Vertex pos="4 4 -12" />
                            <Vertex pos="12 -12 12" />
                            <Vertex pos="4 -3.99999 -12" />
                            <Vertex pos="-12 12 12" />
                            <Vertex pos="-4 4 -12" />
                            <Vertex pos="-12 -12 12" />
                            <Vertex pos="-4 -3.99999 -12" />
                        </Vertices>
                        <Face id="0" plane="0.948683 0 -0.316228 -7.58947" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.948683 -0 -0.316228 -7.58947" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.948683 -0.316228 -7.58947" album="" material="bm_grid_blank4" texgens="-1 0 0 -3328 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.948683 -0.316228 -7.58946" album="" material="bm_grid_blank4" texgens="1 0 0 3584 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_grid_blank4" texgens="1 0 0 3584 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -3328 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="-1" type="0" pos="24 -9.53674e-007 -21.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -9.53674e-007 0 0 1 -21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 12 12" />
                            <Vertex pos="4 4 -12" />
                            <Vertex pos="12 -12 12" />
                            <Vertex pos="4 -4 -12" />
                            <Vertex pos="-12 12 12" />
                            <Vertex pos="-4 4 -12" />
                            <Vertex pos="-12 -12 12" />
                            <Vertex pos="-4 -4 -12" />
                        </Vertices>
                        <Face id="0" plane="0.948683 0 -0.316228 -7.58947" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.948683 -0 -0.316228 -7.58947" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.948683 -0.316228 -7.58947" album="" material="bm_grid_blank4" texgens="-1 0 0 -3328 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.948683 -0.316228 -7.58947" album="" material="bm_grid_blank4" texgens="1 0 0 3584 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_grid_blank4" texgens="1 0 0 3584 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -3328 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="-1" type="0" pos="0 24 -10.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 24 0 0 1 -10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 23" />
                            <Vertex pos="2 2 -23" />
                            <Vertex pos="2 -2 23" />
                            <Vertex pos="2 -2 -23" />
                            <Vertex pos="-2 2 23" />
                            <Vertex pos="-2 2 -23" />
                            <Vertex pos="-2 -2 23" />
                            <Vertex pos="-2 -2 -23" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -2560 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 2816 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -23" album="" material="bm_grid_blank4" texgens="1 0 0 2816 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23" album="" material="bm_grid_blank4" texgens="-1 0 0 -2560 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="-1" type="0" pos="0 24 13" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 24 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 2.5 0.5" />
                            <Vertex pos="2.5 2.5 -0.5" />
                            <Vertex pos="2.5 -2.5 0.5" />
                            <Vertex pos="2.5 -2.5 -0.5" />
                            <Vertex pos="-2.5 2.5 0.5" />
                            <Vertex pos="-2.5 2.5 -0.5" />
                            <Vertex pos="-2.5 -2.5 0.5" />
                            <Vertex pos="-2.5 -2.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_grid_blank3" texgens="0 1 0 -5248 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -384 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -4992 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_grid_blank3" texgens="1 0 0 5248 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -2432 0 -1 0 5504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -384 0 -1 0 5504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="-1" type="0" pos="24 24 3.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 24 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 12 1" />
                            <Vertex pos="4 12 -1" />
                            <Vertex pos="4 -12 1" />
                            <Vertex pos="4 -12 -1" />
                            <Vertex pos="-4 12 1" />
                            <Vertex pos="-4 12 -1" />
                            <Vertex pos="-4 -12 1" />
                            <Vertex pos="-4 -12 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank_water" texgens="-1 0 0 -2304 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="-1" type="0" pos="32 40 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 40 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 7" />
                            <Vertex pos="4 4 -7" />
                            <Vertex pos="4 -4 7" />
                            <Vertex pos="4 -4 -7" />
                            <Vertex pos="-4 4 7" />
                            <Vertex pos="-4 4 -7" />
                            <Vertex pos="-4 -4 7" />
                            <Vertex pos="-4 -4 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank_water" texgens="0 -1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="-1" type="0" pos="24 52 3.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 52 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 8 1" />
                            <Vertex pos="12 8 -1" />
                            <Vertex pos="12 -8 1" />
                            <Vertex pos="12 -8 -1" />
                            <Vertex pos="-12 8 1" />
                            <Vertex pos="-12 8 -1" />
                            <Vertex pos="-12 -8 1" />
                            <Vertex pos="-12 -8 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank_water" texgens="1 0 0 1536 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile06_D" texgens="1 0 0 -2560 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="-1" type="0" pos="24 52 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 52 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 8 6" />
                            <Vertex pos="12 8 -6" />
                            <Vertex pos="12 -8 6" />
                            <Vertex pos="12 -8 -6" />
                            <Vertex pos="-12 8 6" />
                            <Vertex pos="-12 8 -6" />
                            <Vertex pos="-12 -8 6" />
                            <Vertex pos="-12 -8 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 1536 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile06_D" texgens="1 0 0 -2560 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="-1" type="0" pos="16 40 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 40 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 7" />
                            <Vertex pos="4 4 -7" />
                            <Vertex pos="4 -4 7" />
                            <Vertex pos="4 -4 -7" />
                            <Vertex pos="-4 4 7" />
                            <Vertex pos="-4 4 -7" />
                            <Vertex pos="-4 -4 7" />
                            <Vertex pos="-4 -4 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank_water" texgens="0 1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 2560 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="-1" type="0" pos="0 -12.25 0" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -12.25 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.5" />
                            <Vertex pos="4.5 0.25 -0.5" />
                            <Vertex pos="4.5 -0.25 0.5" />
                            <Vertex pos="4.5 -0.25 -0.5" />
                            <Vertex pos="-4.5 0.25 0.5" />
                            <Vertex pos="-4.5 0.25 -0.5" />
                            <Vertex pos="-4.5 -0.25 0.5" />
                            <Vertex pos="-4.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="-1" type="0" pos="4.25 -4 0" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 -4 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8 0.5" />
                            <Vertex pos="0.25 8 -0.5" />
                            <Vertex pos="0.25 -8 0.5" />
                            <Vertex pos="0.25 -8 -0.5" />
                            <Vertex pos="-0.25 8 0.5" />
                            <Vertex pos="-0.25 8 -0.5" />
                            <Vertex pos="-0.25 -8 0.5" />
                            <Vertex pos="-0.25 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="-1" type="0" pos="-4.25 -4 0" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 -4 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8 0.5" />
                            <Vertex pos="0.25 8 -0.5" />
                            <Vertex pos="0.25 -8 0.5" />
                            <Vertex pos="0.25 -8 -0.5" />
                            <Vertex pos="-0.25 8 0.5" />
                            <Vertex pos="-0.25 8 -0.5" />
                            <Vertex pos="-0.25 -8 0.5" />
                            <Vertex pos="-0.25 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="-1" type="0" pos="-4.25 44.25 6" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 44.25 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8.25 0.5" />
                            <Vertex pos="0.25 8.25 -0.5" />
                            <Vertex pos="0.25 -8.25 0.5" />
                            <Vertex pos="0.25 -8.25 -0.5" />
                            <Vertex pos="-0.25 8.25 0.5" />
                            <Vertex pos="-0.25 8.25 -0.5" />
                            <Vertex pos="-0.25 -8.25 0.5" />
                            <Vertex pos="-0.25 -8.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2112 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1984 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="-1" type="0" pos="4.25 39.75 6" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 39.75 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.75 0.5" />
                            <Vertex pos="0.25 3.75 -0.5" />
                            <Vertex pos="0.25 -3.75 0.5" />
                            <Vertex pos="0.25 -3.75 -0.5" />
                            <Vertex pos="-0.25 3.75 0.5" />
                            <Vertex pos="-0.25 3.75 -0.5" />
                            <Vertex pos="-0.25 -3.75 0.5" />
                            <Vertex pos="-0.25 -3.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -832 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="-1" type="0" pos="8 43.75 6" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 43.75 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.5" />
                            <Vertex pos="4 0.25 -0.5" />
                            <Vertex pos="4 -0.25 0.5" />
                            <Vertex pos="4 -0.25 -0.5" />
                            <Vertex pos="-4 0.25 0.5" />
                            <Vertex pos="-4 0.25 -0.5" />
                            <Vertex pos="-4 -0.25 0.5" />
                            <Vertex pos="-4 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="-1" type="0" pos="4 52.25 6" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 52.25 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.25 0.5" />
                            <Vertex pos="8 0.25 -0.5" />
                            <Vertex pos="8 -0.25 0.5" />
                            <Vertex pos="8 -0.25 -0.5" />
                            <Vertex pos="-8 0.25 0.5" />
                            <Vertex pos="-8 0.25 -0.5" />
                            <Vertex pos="-8 -0.25 0.5" />
                            <Vertex pos="-8 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="-1" type="0" pos="42.25 52.25 14" rot="1 0 0 0" scale="" transform="1 0 0 42.25 0 1 0 52.25 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.25 0.25 0.5" />
                            <Vertex pos="6.25 0.25 -0.5" />
                            <Vertex pos="6.25 -0.25 0.5" />
                            <Vertex pos="6.25 -0.25 -0.5" />
                            <Vertex pos="-6.25 0.25 0.5" />
                            <Vertex pos="-6.25 0.25 -0.5" />
                            <Vertex pos="-6.25 -0.25 0.5" />
                            <Vertex pos="-6.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2496 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2368 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2368 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2496 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="-1" type="0" pos="48.25 48 14" rot="1 0 0 0" scale="" transform="1 0 0 48.25 0 1 0 48 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="-1" type="0" pos="48.25 40 12" rot="1 0 0 0" scale="" transform="1 0 0 48.25 0 1 0 40 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 2.5" />
                            <Vertex pos="0.25 4 1.5" />
                            <Vertex pos="0.25 -4 -1.5" />
                            <Vertex pos="0.25 -4 -2.5" />
                            <Vertex pos="-0.25 4 2.5" />
                            <Vertex pos="-0.25 4 1.5" />
                            <Vertex pos="-0.25 -4 -1.5" />
                            <Vertex pos="-0.25 -4 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="-1" type="0" pos="39.75 40 12" rot="1 0 0 0" scale="" transform="1 0 0 39.75 0 1 0 40 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 2.5" />
                            <Vertex pos="0.25 4 1.5" />
                            <Vertex pos="0.25 -4 -1.5" />
                            <Vertex pos="0.25 -4 -2.5" />
                            <Vertex pos="-0.25 4 2.5" />
                            <Vertex pos="-0.25 4 1.5" />
                            <Vertex pos="-0.25 -4 -1.5" />
                            <Vertex pos="-0.25 -4 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="-1" type="0" pos="37.75 43.75 14" rot="1 0 0 0" scale="" transform="1 0 0 37.75 0 1 0 43.75 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0.25 0.5" />
                            <Vertex pos="1.75 0.25 -0.5" />
                            <Vertex pos="1.75 -0.25 0.5" />
                            <Vertex pos="1.75 -0.25 -0.5" />
                            <Vertex pos="-1.75 0.25 0.5" />
                            <Vertex pos="-1.75 0.25 -0.5" />
                            <Vertex pos="-1.75 -0.25 0.5" />
                            <Vertex pos="-1.75 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.75" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3648 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3520 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -3520 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 3648 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="-1" type="0" pos="37.75 36.25 10" rot="1 0 0 0" scale="" transform="1 0 0 37.75 0 1 0 36.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0.25 0.5" />
                            <Vertex pos="1.75 0.25 -0.5" />
                            <Vertex pos="1.75 -0.25 0.5" />
                            <Vertex pos="1.75 -0.25 -0.5" />
                            <Vertex pos="-1.75 0.25 0.5" />
                            <Vertex pos="-1.75 0.25 -0.5" />
                            <Vertex pos="-1.75 -0.25 0.5" />
                            <Vertex pos="-1.75 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.75" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3648 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3520 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -3520 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 3648 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="-1" type="0" pos="36.75 31.75 10" rot="1 0 0 0" scale="" transform="1 0 0 36.75 0 1 0 31.75 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.75 0.25 0.5" />
                            <Vertex pos="2.75 0.25 -0.5" />
                            <Vertex pos="2.75 -0.25 0.5" />
                            <Vertex pos="2.75 -0.25 -0.5" />
                            <Vertex pos="-2.75 0.25 0.5" />
                            <Vertex pos="-2.75 0.25 -0.5" />
                            <Vertex pos="-2.75 -0.25 0.5" />
                            <Vertex pos="-2.75 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.75" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.75" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3392 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3264 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -3264 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 3392 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="-1" type="0" pos="48.25 32 10" rot="1 0 0 0" scale="" transform="1 0 0 48.25 0 1 0 32 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="-1" type="0" pos="39.75 30 10" rot="1 0 0 0" scale="" transform="1 0 0 39.75 0 1 0 30 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1408 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="-1" type="0" pos="44 27.75 10" rot="1 0 0 0" scale="" transform="1 0 0 44 0 1 0 27.75 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.5" />
                            <Vertex pos="4.5 0.25 -0.5" />
                            <Vertex pos="4.5 -0.25 0.5" />
                            <Vertex pos="4.5 -0.25 -0.5" />
                            <Vertex pos="-4.5 0.25 0.5" />
                            <Vertex pos="-4.5 0.25 -0.5" />
                            <Vertex pos="-4.5 -0.25 0.5" />
                            <Vertex pos="-4.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2816 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2816 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2944 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="-1" type="0" pos="31.25 31.75 -8" rot="1 0 0 0" scale="" transform="1 0 0 31.25 0 1 0 31.75 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.75 0.25 0.5" />
                            <Vertex pos="2.75 0.25 -0.5" />
                            <Vertex pos="2.75 -0.25 0.5" />
                            <Vertex pos="2.75 -0.25 -0.5" />
                            <Vertex pos="-2.75 0.25 0.5" />
                            <Vertex pos="-2.75 0.25 -0.5" />
                            <Vertex pos="-2.75 -0.25 0.5" />
                            <Vertex pos="-2.75 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.75" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.75" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3392 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -3264 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -3264 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 3392 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="-1" type="0" pos="34.5 20.25 -8" rot="1 0 0 0" scale="" transform="1 0 0 34.5 0 1 0 20.25 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.5" />
                            <Vertex pos="6 0.25 -0.5" />
                            <Vertex pos="6 -0.25 0.5" />
                            <Vertex pos="6 -0.25 -0.5" />
                            <Vertex pos="-6 0.25 0.5" />
                            <Vertex pos="-6 0.25 -0.5" />
                            <Vertex pos="-6 -0.25 0.5" />
                            <Vertex pos="-6 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="-1" type="0" pos="28.25 26 -8" rot="1 0 0 0" scale="" transform="1 0 0 28.25 0 1 0 26 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.5" />
                            <Vertex pos="0.25 6 -0.5" />
                            <Vertex pos="0.25 -6 0.5" />
                            <Vertex pos="0.25 -6 -0.5" />
                            <Vertex pos="-0.25 6 0.5" />
                            <Vertex pos="-0.25 6 -0.5" />
                            <Vertex pos="-0.25 -6 0.5" />
                            <Vertex pos="-0.25 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="-1" type="0" pos="19.75 24 -8" rot="1 0 0 0" scale="" transform="1 0 0 19.75 0 1 0 24 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 12 0.5" />
                            <Vertex pos="0.25 12 -0.5" />
                            <Vertex pos="0.25 -12 0.5" />
                            <Vertex pos="0.25 -12 -0.5" />
                            <Vertex pos="-0.25 12 0.5" />
                            <Vertex pos="-0.25 12 -0.5" />
                            <Vertex pos="-0.25 -12 0.5" />
                            <Vertex pos="-0.25 -12 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1152 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1280 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="-1" type="0" pos="40.25 16 -8" rot="1 0 0 0" scale="" transform="1 0 0 40.25 0 1 0 16 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="-1" type="0" pos="40.25 -16 -8" rot="1 0 0 0" scale="" transform="1 0 0 40.25 0 1 0 -16 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="-1" type="0" pos="19.75 -16 -8" rot="1 0 0 0" scale="" transform="1 0 0 19.75 0 1 0 -16 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="-1" type="0" pos="30 -20.25 -8" rot="1 0 0 0" scale="" transform="1 0 0 30 0 1 0 -20.25 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10.5 0.25 0.5" />
                            <Vertex pos="10.5 0.25 -0.5" />
                            <Vertex pos="10.5 -0.25 0.5" />
                            <Vertex pos="10.5 -0.25 -0.5" />
                            <Vertex pos="-10.5 0.25 0.5" />
                            <Vertex pos="-10.5 0.25 -0.5" />
                            <Vertex pos="-10.5 -0.25 0.5" />
                            <Vertex pos="-10.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10.5" album="" material="bm_edge_white" texgens="0 1 0 832 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10.5" album="" material="bm_edge_white" texgens="0 -1 0 -704 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -2560 0 -1 0 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 2688 0 -1 0 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="-1" type="0" pos="24 -0.397829 6.53842" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -0.397829 0 0 1 6.53842 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="4 -0.382536 0.0384216" />
                            <Vertex pos="4 0.397824 -0.0384216" />
                            <Vertex pos="-4 -0.382536 0.0384216" />
                            <Vertex pos="-4 0.397824 -0.0384216" />
                            <Vertex pos="4 -0.397824 -0.0384216" />
                            <Vertex pos="-4 -0.397824 -0.0384216" />
                        </Vertices>
                        <Face id="0" plane="0 0.0979975 0.995187 -0.000749093" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -0.92388 0.382682 63.9288 0 0.125 0.191342" texRot="0" texScale="0.125 0.191342" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 12.7305 0 0.098018 0.995185 127.36 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="-0.0491272 -0.997584 0.0491272 12.7602 0.708811 0.0691417 0.702001 180.568 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="3" plane="0 -0.980778 0.195126 -0.38268" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 126.77 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.0384216" album="" material="bm_grid_blank4" texgens="0 1 0 37.2129 1 0 0 62.468 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="-1" type="0" pos="24 -1.21861 6.65223" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -1.21861 0 0 1 6.65223 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.438244 -0.0753894" />
                            <Vertex pos="4 -0.312124 0.152236" />
                            <Vertex pos="-4 0.438244 -0.0753894" />
                            <Vertex pos="-4 -0.312124 0.152236" />
                            <Vertex pos="4 0.422953 -0.152235" />
                            <Vertex pos="4 -0.438244 -0.152235" />
                            <Vertex pos="-4 0.422953 -0.152235" />
                            <Vertex pos="-4 -0.438244 -0.152235" />
                        </Vertices>
                        <Face id="0" plane="-0 0.290289 0.956939 -0.0550744" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -0.92388 0.382682 198.03 0 0.125 0.191342" texRot="0" texScale="0.125 0.191342" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -0.980785 0.195091 14.225 0 0.290282 0.956941 125.621 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="-0.0491249 -0.968832 0.242801 14.1725 0.708811 0.204765 0.675025 179.341 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.980772 -0.195157 -0.44453" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.195091 -0.980785 128.371 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.923875 0.382694 -0.346623" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.195091 -0.980785 128.371 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.152235" album="" material="bm_grid_blank4" texgens="0 1 0 46.7348 1 0 0 60.207 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="-1" type="0" pos="24 -2.10173 6.83706" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -2.10173 0 0 1 6.83706 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.570987 -0.0325937" />
                            <Vertex pos="4 -0.120556 0.337062" />
                            <Vertex pos="-4 0.570987 -0.0325937" />
                            <Vertex pos="-4 -0.120556 0.337062" />
                            <Vertex pos="4 0.444868 -0.337062" />
                            <Vertex pos="4 -0.570987 -0.337062" />
                            <Vertex pos="-4 0.444868 -0.337062" />
                            <Vertex pos="-4 -0.570987 -0.337062" />
                        </Vertices>
                        <Face id="0" plane="-0 0.471415 0.881912 -0.240427" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -0.92388 0.382682 346.309 0 0.125 0.191342" texRot="0" texScale="0.125 0.191342" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -0.92388 0.382684 17.2797 0 0.471398 0.88192 119.69 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="-0.0491275 -0.902847 0.427147 16.9421 0.708811 0.332523 0.622105 175.158 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.923875 -0.382694 -0.539994" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.382683 -0.923879 134.029 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.831472 0.555567 -0.287499" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.382683 -0.923879 134.029 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.337062" album="" material="bm_grid_blank4" texgens="0 1 0 51.0577 1 0 0 58.476 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="-1" type="0" pos="24 -3.11115 7.08578" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -3.11115 0 0 1 7.08578 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.888854 0.0883431" />
                            <Vertex pos="4 0.282714 0.585781" />
                            <Vertex pos="-4 0.888854 0.0883431" />
                            <Vertex pos="-4 0.282714 0.585781" />
                            <Vertex pos="4 0.438426 -0.585781" />
                            <Vertex pos="4 -0.888854 -0.585781" />
                            <Vertex pos="-4 0.438426 -0.585781" />
                            <Vertex pos="-4 -0.888854 -0.585781" />
                        </Vertices>
                        <Face id="0" plane="-0 0.634387 0.773016 -0.632168" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -0.92388 0.382682 518.19 0 0.125 0.191342" texRot="0" texScale="0.125 0.191342" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -0.83147 0.55557 22.0791 0 0.634393 0.773011 107.154 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="-0.0491269 -0.802167 0.595075 21.1339 0.708811 0.4475 0.54528 166.315 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.831474 -0.555564 -0.689979" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.55557 -0.83147 146.152 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.707105 0.707109 -0.214302" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.55557 -0.83147 146.152 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.585781" album="" material="bm_grid_blank4" texgens="0 1 0 47.0594 1 0 0 57.539 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="-1" type="0" pos="24 -3.84777 9.28141" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -3.84777 0 0 1 9.28141 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.152234 -0.312156" />
                            <Vertex pos="4 -0.0753994 0.438249" />
                            <Vertex pos="-4 0.152234 -0.312156" />
                            <Vertex pos="-4 -0.0753903 0.438219" />
                            <Vertex pos="4 -0.152234 -0.43825" />
                            <Vertex pos="4 -0.152234 0.422938" />
                            <Vertex pos="-4 -0.152234 -0.43825" />
                            <Vertex pos="-4 -0.152234 0.422908" />
                        </Vertices>
                        <Face id="0" plane="-0 0.95694 0.290285 -0.0550645" album="" material="bm_tile06_D" texgens="0.999999 0 0 -512 0 -0.382679 0.92388 313.969 0 0.125 0.191343" texRot="0" texScale="0.125 0.191343" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -0.382681 0.92388 11.0929 0 0.95694 0.290286 125.621 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="-0.0491249 -0.336371 0.940447 11.0324 0.708811 0.675024 0.204767 179.34 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.38263 -0.923902 -0.346651" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.92388 -0.382681 128.679 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-3.8976e-006 -0.195408 0.980722 -0.444519" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.92388 -0.382681 128.679 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 -1 -0 -0.152234" album="" material="bm_grid_blank4" texgens="0 0 1 36.354 1 0 0 60.207 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="-1" type="0" pos="24 -3.96156 10.1022" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -3.96156 0 0 1 10.1022 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="4 0.0384376 -0.382518" />
                            <Vertex pos="4 -0.0384376 0.397829" />
                            <Vertex pos="-4 0.0384376 -0.382518" />
                            <Vertex pos="-4 -0.0384376 0.397829" />
                            <Vertex pos="4 -0.0384376 -0.39783" />
                            <Vertex pos="-4 -0.0384376 -0.39783" />
                        </Vertices>
                        <Face id="0" plane="-0 0.995183 0.0980395 -0.000750542" album="" material="bm_tile06_D" texgens="0.999999 0 0 -511.99 0 -0.38268 0.92388 448.07 0 0.125 0.191343" texRot="0" texScale="0.125 0.191343" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -0.195087 0.980786 12.2454 0 0.995185 0.0980118 127.36 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 1 0" />
                        </Face>
                        <Face id="2" plane="-1 -0 0 -4" album="" material="bm_grid_blank4" texgens="-0.049128 -0.146432 0.988 12.2741 0.708811 0.702002 0.0691373 180.568 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.195343 -0.980735 -0.382657" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.980786 -0.195087 126.818 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.0384376" album="" material="bm_grid_blank4" texgens="0 0 1 24.9665 1 0 0 62.468 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="-1" type="0" pos="24 -3.41422 7.38886" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -3.41422 0 0 1 7.38886 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.585785 0.282704" />
                            <Vertex pos="-4 0.585785 0.282704" />
                            <Vertex pos="4 0.0883408 0.88886" />
                            <Vertex pos="-4 0.0883408 0.88886" />
                            <Vertex pos="4 -0.585785 -0.88886" />
                            <Vertex pos="-4 -0.585785 -0.88886" />
                            <Vertex pos="4 -0.585785 0.438422" />
                            <Vertex pos="-4 -0.585785 0.438422" />
                        </Vertices>
                        <Face id="0" plane="-0 0.77302 0.634382 -0.632166" album="" material="bm_tile06_D" texgens="0.999999 0 0 -511.99 0 -0.38268 0.92388 -6.19153 0 0.125 0.191343" texRot="0" texScale="0.125 0.191343" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 0.707105 -0.707109 -0.214309" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.707106 -0.707107 147.651 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -0.707107 0.707106 6.85851 0 0.77301 0.634394 107.155 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="-0.0491267 -0.670661 0.740135 5.87579 0.708811 0.54528 0.4475 166.315 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 -0.555572 0.831469 -0.68998" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.707106 -0.707107 147.651 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="-0 -1 -0 -0.585785" album="" material="bm_grid_blank4" texgens="0 0 1 44.6245 1 0 0 57.539 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="-1" type="0" pos="24 -3.66294 8.39828" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -3.66294 0 0 1 8.39828 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -0.0325935 0.571" />
                            <Vertex pos="-4 -0.0325935 0.571" />
                            <Vertex pos="4 0.337063 -0.120562" />
                            <Vertex pos="-4 0.337063 -0.120562" />
                            <Vertex pos="4 -0.337062 0.444875" />
                            <Vertex pos="-4 -0.337062 0.444875" />
                            <Vertex pos="4 -0.337062 -0.570999" />
                            <Vertex pos="-4 -0.337062 -0.570999" />
                        </Vertices>
                        <Face id="0" plane="0 0.881917 0.471406 -0.240428" album="" material="bm_tile06_D" texgens="0.999999 0 0 -512 0 -0.382679 0.92388 165.691 0 0.125 0.191343" texRot="0" texScale="0.125 0.191343" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.382709 0.923869 -0.540003" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.83147 -0.55557 134.825 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 -0.55557 0.83147 9.20001 0 0.881923 0.471393 119.69 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="-1 -0 0 -4" album="" material="bm_grid_blank4" texgens="-0.0491289 -0.513378 0.856755 8.84271 0.708811 0.622107 0.33252 175.157 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 0.555571 -0.831469 -0.287506" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -0.83147 -0.55557 134.825 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -0.337062" album="" material="bm_grid_blank4" texgens="0 0 1 156.35 1 0 0 195.688 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="-1" type="0" pos="24 24 20.5" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 24 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 3" />
                            <Vertex pos="2 2 -3" />
                            <Vertex pos="2 -2 3" />
                            <Vertex pos="2 -2 -3" />
                            <Vertex pos="-2 2 3" />
                            <Vertex pos="-2 2 -3" />
                            <Vertex pos="-2 -2 3" />
                            <Vertex pos="-2 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -2560 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 2816 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 2816 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -2560 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="17" type="999" pos="0 8 0" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 8 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_stripe_caution1" texgens="0 1 1 288 0 0 -1 32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_stripe_caution1" texgens="0 -1 1 288 0 0 -1 32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_stripe_caution1" texgens="-1 0 1 288 0 0 -1 32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_stripe_caution1" texgens="1 0 1 288 0 0 -1 32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_D" texgens="1 0 0 1024 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="21" type="999" pos="31 17 25.5" rot="1 0 0 0" scale="" transform="1 0 0 31 0 1 0 17 0 0 1 25.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_basher_side" texgens="0 1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_basher_side" texgens="0 -1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_basher" texgens="-1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_basher" texgens="1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_basher_top" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_basher_top" texgens="-1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="25" type="999" pos="17 24 25.5" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 24 0 0 1 25.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_basher_side" texgens="0 1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_basher_side" texgens="0 -1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_basher" texgens="-1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_basher" texgens="1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_basher_top" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_basher_top" texgens="-1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="29" type="999" pos="31 31 25.5" rot="1 0 0 0" scale="" transform="1 0 0 31 0 1 0 31 0 0 1 25.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_basher_side" texgens="0 1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_basher_side" texgens="0 -1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_basher" texgens="-1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_basher" texgens="1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_basher_top" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_basher_top" texgens="-1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="20" type="4" pos="0 12 1" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 12 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0 0" />
                            <Vertex pos="4 0 -0.5" />
                            <Vertex pos="4 -8 0" />
                            <Vertex pos="4 -8 -0.5" />
                            <Vertex pos="-4 0 0" />
                            <Vertex pos="-4 0 -0.5" />
                            <Vertex pos="-4 -8 0" />
                            <Vertex pos="-4 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_trim" texgens="-1 0 0 -384 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_tile06_D" texgens="1 0 0 1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="13" type="0" pos="18.5 22 9" rot="1 0 0 0" scale="" transform="1 0 0 18.5 0 1 0 22 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 0 -0.5" />
                            <Vertex pos="-0.5 4 -0.25" />
                            <Vertex pos="-0.5 4 -0.5" />
                            <Vertex pos="-0.5 0 -0.25" />
                            <Vertex pos="-0.5 0 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.25" album="Blasted" material="bm_wood" texgens="0 1 0 5632 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 -1 0 -5632 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 -4736 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0" album="Blasted" material="bm_wood" texgens="1 0 0 4736 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.25" album="Blasted" material="bm_wood" texgens="1 0 0 4736 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -4736 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="13" type="0" pos="18.5 22 12.75" rot="1 0 0 0" scale="" transform="1 0 0 18.5 0 1 0 22 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 0 -0.5" />
                            <Vertex pos="-0.5 4 -0.25" />
                            <Vertex pos="-0.5 4 -0.5" />
                            <Vertex pos="-0.5 0 -0.25" />
                            <Vertex pos="-0.5 0 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.25" album="Blasted" material="bm_wood" texgens="0 1 0 5632 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 -1 0 -5632 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 -4736 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0" album="Blasted" material="bm_wood" texgens="1 0 0 4736 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.25" album="Blasted" material="bm_wood" texgens="1 0 0 4736 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -4736 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="13" type="0" pos="18.5 22 9.25" rot="1 0 0 0" scale="" transform="1 0 0 18.5 0 1 0 22 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 0 3" />
                            <Vertex pos="-0.25 0 -0.5" />
                            <Vertex pos="-0.5 0.25 3" />
                            <Vertex pos="-0.5 0.25 -0.5" />
                            <Vertex pos="-0.5 0 3" />
                            <Vertex pos="-0.5 0 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.25" album="Blasted" material="bm_wood" texgens="0 1 0 5632 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 -1 0 -5632 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -4736 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 4736 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 4736 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -4736 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="13" type="0" pos="18.5 25.75 9.25" rot="1 0 0 0" scale="" transform="1 0 0 18.5 0 1 0 25.75 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 0 3" />
                            <Vertex pos="-0.25 0 -0.5" />
                            <Vertex pos="-0.5 0.25 3" />
                            <Vertex pos="-0.5 0.25 -0.5" />
                            <Vertex pos="-0.5 0 3" />
                            <Vertex pos="-0.5 0 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.25" album="Blasted" material="bm_wood" texgens="0 1 0 6592 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 -1 0 -6592 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -4736 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 4736 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 4736 0 -1 0 -6592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -4736 0 -1 0 -6592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="13" type="0" pos="30.25 22 9" rot="1 0 0 0" scale="" transform="1 0 0 30.25 0 1 0 22 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 0 -0.5" />
                            <Vertex pos="-0.5 4 -0.25" />
                            <Vertex pos="-0.5 4 -0.5" />
                            <Vertex pos="-0.5 0 -0.25" />
                            <Vertex pos="-0.5 0 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.25" album="Blasted" material="bm_wood" texgens="0 1 0 5632 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 -1 0 -5632 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 -7744 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0" album="Blasted" material="bm_wood" texgens="1 0 0 7744 0 0 -1 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.25" album="Blasted" material="bm_wood" texgens="1 0 0 7744 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -7744 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="13" type="0" pos="30.25 22 12.75" rot="1 0 0 0" scale="" transform="1 0 0 30.25 0 1 0 22 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 0 -0.25" />
                            <Vertex pos="-0.25 0 -0.5" />
                            <Vertex pos="-0.5 4 -0.25" />
                            <Vertex pos="-0.5 4 -0.5" />
                            <Vertex pos="-0.5 0 -0.25" />
                            <Vertex pos="-0.5 0 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.25" album="Blasted" material="bm_wood" texgens="0 1 0 5632 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 -1 0 -5632 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 -7744 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0" album="Blasted" material="bm_wood" texgens="1 0 0 7744 0 0 -1 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.25" album="Blasted" material="bm_wood" texgens="1 0 0 7744 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -7744 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="13" type="0" pos="30.25 22 9.25" rot="1 0 0 0" scale="" transform="1 0 0 30.25 0 1 0 22 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 0 3" />
                            <Vertex pos="-0.25 0 -0.5" />
                            <Vertex pos="-0.5 0.25 3" />
                            <Vertex pos="-0.5 0.25 -0.5" />
                            <Vertex pos="-0.5 0 3" />
                            <Vertex pos="-0.5 0 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.25" album="Blasted" material="bm_wood" texgens="0 1 0 5632 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 -1 0 -5632 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -7744 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 7744 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 7744 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -7744 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="13" type="0" pos="30.25 25.75 9.25" rot="1 0 0 0" scale="" transform="1 0 0 30.25 0 1 0 25.75 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 0 3" />
                            <Vertex pos="-0.25 0 -0.5" />
                            <Vertex pos="-0.5 0.25 3" />
                            <Vertex pos="-0.5 0.25 -0.5" />
                            <Vertex pos="-0.5 0 3" />
                            <Vertex pos="-0.5 0 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.25" album="Blasted" material="bm_wood" texgens="0 1 0 6592 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 -1 0 -6592 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -7744 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 7744 0 0 -1 -2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 7744 0 -1 0 -6592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -7744 0 -1 0 -6592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
