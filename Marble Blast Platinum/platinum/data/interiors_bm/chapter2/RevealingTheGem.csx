<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2023/05/12 01:10:14">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="11">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="7" dl="0" group="-1" locked="0" />
        <SceneShape id="5" type="1" entityID="10" dl="0" group="-1" locked="0" />
        <SceneShape id="6" type="1" entityID="11" dl="0" group="-1" locked="0" />
        <SceneShape id="7" type="1" entityID="14" dl="0" group="-1" locked="0" />
        <SceneShape id="8" type="1" entityID="15" dl="0" group="-1" locked="0" />
        <SceneShape id="9" type="1" entityID="18" dl="0" group="-1" locked="0" />
        <SceneShape id="10" type="1" entityID="19" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="21">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="32" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="-15.5 41.5 0" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="-35.5 41.5 0" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="-15.5 41.5 0" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7.5 7.5 4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7.5 7.5 -4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="9" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="10" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7.5 7.5 4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="11" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7.5 7.5 -5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="12" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="13" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="14" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7.5 7.5 4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="15" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7.5 7.5 -4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="16" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="17" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="18" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7.5 7.5 2" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="19" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7.5 7.5 -1.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="20" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="256">
                    <Brush id="0" owner="0" type="0" pos="-1.5 1.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 1.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="-4.5 0.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -4.5 0 1 0 0.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="-7.5 0.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 0.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.5" />
                            <Vertex pos="2 3 -0.5" />
                            <Vertex pos="2 -3 0.5" />
                            <Vertex pos="2 -3 -0.5" />
                            <Vertex pos="-2 3 0.5" />
                            <Vertex pos="-2 3 -0.5" />
                            <Vertex pos="-2 -3 0.5" />
                            <Vertex pos="-2 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-10.5 0.499999 0" rot="1 0 0 0" scale="" transform="1 0 0 -10.5 0 1 0 0.499999 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-13.5 1.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 1.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-14.5 4.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -14.5 0 1 0 4.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 0.5" />
                            <Vertex pos="3 1 -0.5" />
                            <Vertex pos="3 -1 0.5" />
                            <Vertex pos="3 -1 -0.5" />
                            <Vertex pos="-3 1 0.5" />
                            <Vertex pos="-3 1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.41421" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-14.5 7.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -14.5 0 1 0 7.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-14.5 10.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -14.5 0 1 0 10.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 0.5" />
                            <Vertex pos="3 1 -0.5" />
                            <Vertex pos="3 -1 0.5" />
                            <Vertex pos="3 -1 -0.5" />
                            <Vertex pos="-0.999999 1 0.5" />
                            <Vertex pos="-0.999999 1 -0.5" />
                            <Vertex pos="-3 -1 0.5" />
                            <Vertex pos="-3 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-13.5 13.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 13.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-0.5 4.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 4.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 0.5" />
                            <Vertex pos="3 1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="-3 1 0.5" />
                            <Vertex pos="-3 1 -0.5" />
                            <Vertex pos="-3 -1 0.5" />
                            <Vertex pos="-3 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-0.5 7.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 7.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-0.500001 10.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -0.500001 0 1 0 10.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999999 1 0.5" />
                            <Vertex pos="0.999999 1 -0.5" />
                            <Vertex pos="3 -1 0.5" />
                            <Vertex pos="3 -1 -0.5" />
                            <Vertex pos="-3 1 0.5" />
                            <Vertex pos="-3 1 -0.5" />
                            <Vertex pos="-3 -1 0.5" />
                            <Vertex pos="-3 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41421" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-1.5 13.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 13.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-4.5 14.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -4.5 0 1 0 14.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-7.5 14.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 14.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.5" />
                            <Vertex pos="2 3 -0.5" />
                            <Vertex pos="2 -3 0.5" />
                            <Vertex pos="2 -3 -0.5" />
                            <Vertex pos="-2 3 0.5" />
                            <Vertex pos="-2 3 -0.5" />
                            <Vertex pos="-2 -3 0.5" />
                            <Vertex pos="-2 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 0 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-10.5 14.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -10.5 0 1 0 14.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 0.999999 0.5" />
                            <Vertex pos="-1 0.999999 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-7.5 7.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 7.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-1.5 1.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 1.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16" />
                            <Vertex pos="2 2 -28" />
                            <Vertex pos="2 -2 16" />
                            <Vertex pos="2 -2 -28" />
                            <Vertex pos="-2 2 16" />
                            <Vertex pos="-2 2 -28" />
                            <Vertex pos="-2 -2 16" />
                            <Vertex pos="-2 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-1.5 13.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 13.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16" />
                            <Vertex pos="2 2 -28" />
                            <Vertex pos="2 -2 16" />
                            <Vertex pos="2 -2 -28" />
                            <Vertex pos="-2 2 16" />
                            <Vertex pos="-2 2 -28" />
                            <Vertex pos="-2 -2 16" />
                            <Vertex pos="-2 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="-13.5 1.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 1.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16" />
                            <Vertex pos="2 2 -28" />
                            <Vertex pos="2 -2 16" />
                            <Vertex pos="2 -2 -28" />
                            <Vertex pos="-2 2 16" />
                            <Vertex pos="-2 2 -28" />
                            <Vertex pos="-2 -2 16" />
                            <Vertex pos="-2 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-13.5 13.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 13.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16" />
                            <Vertex pos="2 2 -28" />
                            <Vertex pos="2 -2 16" />
                            <Vertex pos="2 -2 -28" />
                            <Vertex pos="-2 2 16" />
                            <Vertex pos="-2 2 -28" />
                            <Vertex pos="-2 -2 16" />
                            <Vertex pos="-2 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-10.5 0.499999 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -10.5 0 1 0 0.499999 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 16" />
                            <Vertex pos="1 3 -28" />
                            <Vertex pos="1 -3 16" />
                            <Vertex pos="1 -3 -28" />
                            <Vertex pos="-1 3 16" />
                            <Vertex pos="-1 3 -28" />
                            <Vertex pos="-1 -1 16" />
                            <Vertex pos="-1 -1 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-4.5 0.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -4.5 0 1 0 0.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 16" />
                            <Vertex pos="1 3 -28" />
                            <Vertex pos="1 -1 16" />
                            <Vertex pos="1 -1 -28" />
                            <Vertex pos="-1 3 16" />
                            <Vertex pos="-1 3 -28" />
                            <Vertex pos="-1 -3 16" />
                            <Vertex pos="-1 -3 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-7.5 0.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 0.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 16" />
                            <Vertex pos="2 3 -28" />
                            <Vertex pos="2 -3 16" />
                            <Vertex pos="2 -3 -28" />
                            <Vertex pos="-2 3 16" />
                            <Vertex pos="-2 3 -28" />
                            <Vertex pos="-2 -3 16" />
                            <Vertex pos="-2 -3 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-10.5 14.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -10.5 0 1 0 14.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 16" />
                            <Vertex pos="1 3 -28" />
                            <Vertex pos="1 -3 16" />
                            <Vertex pos="1 -3 -28" />
                            <Vertex pos="-1 0.999999 16" />
                            <Vertex pos="-1 0.999999 -28" />
                            <Vertex pos="-1 -3 16" />
                            <Vertex pos="-1 -3 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-4.5 14.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -4.5 0 1 0 14.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 16" />
                            <Vertex pos="1 1 -28" />
                            <Vertex pos="1 -3 16" />
                            <Vertex pos="1 -3 -28" />
                            <Vertex pos="-1 3 16" />
                            <Vertex pos="-1 3 -28" />
                            <Vertex pos="-1 -3 16" />
                            <Vertex pos="-1 -3 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-7.5 14.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 14.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 16" />
                            <Vertex pos="2 3 -28" />
                            <Vertex pos="2 -3 16" />
                            <Vertex pos="2 -3 -28" />
                            <Vertex pos="-2 3 16" />
                            <Vertex pos="-2 3 -28" />
                            <Vertex pos="-2 -3 16" />
                            <Vertex pos="-2 -3 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-0.500001 10.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -0.500001 0 1 0 10.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999999 1 16" />
                            <Vertex pos="0.999999 1 -28" />
                            <Vertex pos="3 -1 16" />
                            <Vertex pos="3 -1 -28" />
                            <Vertex pos="-3 1 16" />
                            <Vertex pos="-3 1 -28" />
                            <Vertex pos="-3 -1 16" />
                            <Vertex pos="-3 -1 -28" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -1.41421" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="2.5 7.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 7.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 16" />
                            <Vertex pos="6 2 -28" />
                            <Vertex pos="6 -2 16" />
                            <Vertex pos="6 -2 -28" />
                            <Vertex pos="-6 2 16" />
                            <Vertex pos="-6 2 -28" />
                            <Vertex pos="-6 -2 16" />
                            <Vertex pos="-6 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-0.5 4.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 4.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 16" />
                            <Vertex pos="3 1 -28" />
                            <Vertex pos="1 -1 16" />
                            <Vertex pos="1 -1 -28" />
                            <Vertex pos="-3 1 16" />
                            <Vertex pos="-3 1 -28" />
                            <Vertex pos="-3 -1 16" />
                            <Vertex pos="-3 -1 -28" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-30.5 7.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 7.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="19 2 16" />
                            <Vertex pos="19 2 -28" />
                            <Vertex pos="19 -2 16" />
                            <Vertex pos="19 -2 -28" />
                            <Vertex pos="-19 2 16" />
                            <Vertex pos="-19 2 -28" />
                            <Vertex pos="-19 -2 16" />
                            <Vertex pos="-19 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -19" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -19" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -2176 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-14.5 4.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -14.5 0 1 0 4.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 16" />
                            <Vertex pos="3 1 -28" />
                            <Vertex pos="3 -1 16" />
                            <Vertex pos="3 -1 -28" />
                            <Vertex pos="-3 1 16" />
                            <Vertex pos="-3 1 -28" />
                            <Vertex pos="-1 -1 16" />
                            <Vertex pos="-1 -1 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -1.41421" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-14.5 10.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -14.5 0 1 0 10.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 16" />
                            <Vertex pos="3 1 -28" />
                            <Vertex pos="3 -1 16" />
                            <Vertex pos="3 -1 -28" />
                            <Vertex pos="-0.999999 1 16" />
                            <Vertex pos="-0.999999 1 -28" />
                            <Vertex pos="-3 -1 16" />
                            <Vertex pos="-3 -1 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-7.5 7.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 7.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 16" />
                            <Vertex pos="4 4 -28" />
                            <Vertex pos="4 -4 16" />
                            <Vertex pos="4 -4 -28" />
                            <Vertex pos="-4 4 16" />
                            <Vertex pos="-4 4 -28" />
                            <Vertex pos="-4 -4 16" />
                            <Vertex pos="-4 -4 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-7.5 -4.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -4.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-7.5 -4.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -4.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 0" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="6.5 7.5 0" rot="1 0 0 0" scale="" transform="1 0 0 6.5 0 1 0 7.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="10.5 7.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 10.5 0 1 0 7.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 2.38419e-007" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 2.38419e-007" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-7.5 19.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 19.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-7.5 19.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 19.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 3.57628e-006" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 3.57628e-006" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.894425" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-29.5 7.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -29.5 0 1 0 7.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 2 0.5" />
                            <Vertex pos="12 2 -0.5" />
                            <Vertex pos="12 -2 0.5" />
                            <Vertex pos="12 -2 -0.5" />
                            <Vertex pos="-12 2 0.5" />
                            <Vertex pos="-12 2 -0.5" />
                            <Vertex pos="-12 -2 0.5" />
                            <Vertex pos="-12 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -2816 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile05_A" texgens="1 0 0 -2560 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 3072 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="-7.5 -20.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -20.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-5.5 -24.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -5.5 0 1 0 -24.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-0.5 -24.5 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 -24.5 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.75" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.75" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.75" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 0 0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.485071" album="" material="bm_friction_ice" texgens="1 0 0 -128 0 -1 0 6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="4.5 -24.5 3" rot="1 0 0 0" scale="" transform="1 0 0 4.5 0 1 0 -24.5 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 3" />
                            <Vertex pos="4 2 2" />
                            <Vertex pos="4 -2 3" />
                            <Vertex pos="4 -2 2" />
                            <Vertex pos="-4 2 -2" />
                            <Vertex pos="-4 2 -3" />
                            <Vertex pos="-4 -2 -2" />
                            <Vertex pos="-4 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0.625 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0.625 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.529999 0 0.847998 -0.423999" album="" material="bm_friction_ice" texgens="1 0 0 1152 0 -1 0 6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.529999 0 -0.847998 -0.423999" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="9.5 -24.5 5.75" rot="1 0 0 0" scale="" transform="1 0 0 9.5 0 1 0 -24.5 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.75" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.75" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.75" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 0 0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.485071" album="" material="bm_friction_ice" texgens="1 0 0 2432 0 -1 0 6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="14.5 -24.5 6" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 -24.5 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="16.5 -28.5 6" rot="1 0 0 0" scale="" transform="1 0 0 16.5 0 1 0 -28.5 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="-3.5 -24.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -24.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2.38419e-007" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2.38419e-007" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-7.5 -20.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -20.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -4.76837e-007" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -4.76837e-007" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.894428" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-7.5 -24.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -24.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16" />
                            <Vertex pos="2 2 -28" />
                            <Vertex pos="2 -2 16" />
                            <Vertex pos="2 -2 -28" />
                            <Vertex pos="-2 2 16" />
                            <Vertex pos="-2 2 -28" />
                            <Vertex pos="-2 -2 16" />
                            <Vertex pos="-2 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="16.5 -31.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 16.5 0 1 0 -31.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0" />
                            <Vertex pos="2 1 -1" />
                            <Vertex pos="2 -1 1" />
                            <Vertex pos="2 -1 0" />
                            <Vertex pos="-2 1 0" />
                            <Vertex pos="-2 1 -1" />
                            <Vertex pos="-2 -1 1" />
                            <Vertex pos="-2 -1 0" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 -0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 -0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.447214" album="" material="bm_tile01_A" texgens="1 0 0 0 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447214" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="16.5 -52.5 6" rot="1 0 0 0" scale="" transform="1 0 0 16.5 0 1 0 -52.5 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="16.5 -49.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 16.5 0 1 0 -49.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 1" />
                            <Vertex pos="2 1 9.53674e-007" />
                            <Vertex pos="2 -1 -9.53674e-007" />
                            <Vertex pos="2 -1 -1" />
                            <Vertex pos="-2 1 1" />
                            <Vertex pos="-2 1 9.53674e-007" />
                            <Vertex pos="-2 -1 -9.53674e-007" />
                            <Vertex pos="-2 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447213" album="" material="bm_tile01_A" texgens="1 0 0 0 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447213" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="14.5 -56.5 6" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 -56.5 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="9.5 -56.5 6.25" rot="1 0 0 0" scale="" transform="1 0 0 9.5 0 1 0 -56.5 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.75" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.75" />
                            <Vertex pos="-1 2 0.75" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.75" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 0 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.485071" album="" material="bm_friction_ice" texgens="1 0 0 2432 0 -1 0 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="-0.5 -56.5 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 -56.5 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.75" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.75" />
                            <Vertex pos="-1 2 0.75" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.75" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 0 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.485071" album="" material="bm_friction_ice" texgens="1 0 0 -128 0 -1 0 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="4.5 -56.5 9" rot="1 0 0 0" scale="" transform="1 0 0 4.5 0 1 0 -56.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 -2" />
                            <Vertex pos="4 2 -3" />
                            <Vertex pos="4 -2 -2" />
                            <Vertex pos="4 -2 -3" />
                            <Vertex pos="-4 2 3" />
                            <Vertex pos="-4 2 2" />
                            <Vertex pos="-4 -2 3" />
                            <Vertex pos="-4 -2 2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 -0.625 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -768 -0.625 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.529999 0 0.847998 -0.423999" album="" material="bm_friction_ice" texgens="1 0 0 1152 0 -1 0 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.529999 0 -0.847998 -0.423999" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-7.5 -52.5 12" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -52.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-5.5 -56.5 12" rot="1 0 0 0" scale="" transform="1 0 0 -5.5 0 1 0 -56.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-7.5 -30.5 12" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -30.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="-7.5 -28.5 -10.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -28.5 0 0 1 -10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 22" />
                            <Vertex pos="2 2 -34" />
                            <Vertex pos="2 -2 22" />
                            <Vertex pos="2 -2 -34" />
                            <Vertex pos="-2 2 22" />
                            <Vertex pos="-2 2 -34" />
                            <Vertex pos="-2 -2 22" />
                            <Vertex pos="-2 -2 -34" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -22" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -34" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-7.5 -56.5 -10.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -56.5 0 0 1 -10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 22" />
                            <Vertex pos="2 2 -34" />
                            <Vertex pos="2 -2 22" />
                            <Vertex pos="2 -2 -34" />
                            <Vertex pos="-2 2 22" />
                            <Vertex pos="-2 2 -34" />
                            <Vertex pos="-2 -2 22" />
                            <Vertex pos="-2 -2 -34" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -22" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -34" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-7.5 -32.5 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -32.5 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -9.53674e-007" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447213 -0.894427 -0.894428" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-7.5 -52.5 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -52.5 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -9.53674e-007" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -9.53674e-007" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447213 -0.894427 -0.894428" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="12.5 -24.5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 12.5 0 1 0 -24.5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2.38419e-007" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="16.5 -24.5 -13.5" rot="1 0 0 0" scale="" transform="1 0 0 16.5 0 1 0 -24.5 0 0 1 -13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19" />
                            <Vertex pos="2 2 -31" />
                            <Vertex pos="2 -2 19" />
                            <Vertex pos="2 -2 -31" />
                            <Vertex pos="-2 2 19" />
                            <Vertex pos="-2 2 -31" />
                            <Vertex pos="-2 -2 19" />
                            <Vertex pos="-2 -2 -31" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -31" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="16.5 -28.5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 16.5 0 1 0 -28.5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 2.38419e-007" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="16.5 -56.5 -13.5" rot="1 0 0 0" scale="" transform="1 0 0 16.5 0 1 0 -56.5 0 0 1 -13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19" />
                            <Vertex pos="2 2 -31" />
                            <Vertex pos="2 -2 19" />
                            <Vertex pos="2 -2 -31" />
                            <Vertex pos="-2 2 19" />
                            <Vertex pos="-2 2 -31" />
                            <Vertex pos="-2 -2 19" />
                            <Vertex pos="-2 -2 -31" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -31" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="16.5 -52.5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 16.5 0 1 0 -52.5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 5.72205e-006" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 5.72205e-006" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256.001 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256.001 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256.001 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256.001 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447215 -0.894427 -0.894424" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="12.5 -56.5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 12.5 0 1 0 -56.5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2.38419e-007" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="-3.5 -56.5 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -56.5 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 0" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 0" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="11.5 7.5 0" rot="1 0 0 0" scale="" transform="1 0 0 11.5 0 1 0 7.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.5" />
                            <Vertex pos="1 2 -0.5" />
                            <Vertex pos="1 -2 0.5" />
                            <Vertex pos="1 -2 -0.5" />
                            <Vertex pos="-1 2 0.5" />
                            <Vertex pos="-1 2 -0.5" />
                            <Vertex pos="-1 -2 0.5" />
                            <Vertex pos="-1 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_bounce_med" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="21 7.5 4" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 7.5 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 2 0.5" />
                            <Vertex pos="3.5 2 -0.5" />
                            <Vertex pos="4.5 -2 0.5" />
                            <Vertex pos="3.5 -2 -0.5" />
                            <Vertex pos="-4.5 2 0.5" />
                            <Vertex pos="-4.5 2 -0.5" />
                            <Vertex pos="-4.5 -2 0.5" />
                            <Vertex pos="-4.5 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0 -0.707107 -2.82843" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_A" texgens="1 0 0 640 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="25 7.5 8.5" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 7.5 0 0 1 8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 4" />
                            <Vertex pos="0.5 2 -4" />
                            <Vertex pos="0.5 -2 4" />
                            <Vertex pos="0.5 -2 -4" />
                            <Vertex pos="-0.5 2 4" />
                            <Vertex pos="-0.5 2 -4" />
                            <Vertex pos="-0.5 -2 4" />
                            <Vertex pos="-0.5 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_tile07_A" texgens="0 -1 0 512 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -640 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -384 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="4 7.5 9.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 7.5 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 3" />
                            <Vertex pos="0.5 2 -3" />
                            <Vertex pos="0.5 -2 3" />
                            <Vertex pos="0.5 -2 -3" />
                            <Vertex pos="-0.5 2 3" />
                            <Vertex pos="-0.5 2 -3" />
                            <Vertex pos="-0.5 -2 3" />
                            <Vertex pos="-0.5 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_tile07_A" texgens="0 1 0 512 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 512 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -640 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank3" texgens="1 0 0 -384 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-31.5 7.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -31.5 0 1 0 7.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 2 0.5" />
                            <Vertex pos="10 2 -0.5" />
                            <Vertex pos="10 -2 0.5" />
                            <Vertex pos="10 -2 -0.5" />
                            <Vertex pos="-10 2 0.5" />
                            <Vertex pos="-10 2 -0.5" />
                            <Vertex pos="-10 -2 0.5" />
                            <Vertex pos="-10 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 3584 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -3328 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile05_A" texgens="1 0 0 -3072 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 3584 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-42.0266 7.5 -0.465778" rot="1 0 0 0" scale="" transform="1 0 0 -42.0266 0 1 0 7.5 0 0 1 -0.465778 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.517815 -2 0.0342251" />
                            <Vertex pos="0.526562 -2 -0.034225" />
                            <Vertex pos="-0.517815 2 0.0342251" />
                            <Vertex pos="0.526562 2 -0.034225" />
                            <Vertex pos="-0.526562 -2 -0.0342219" />
                            <Vertex pos="-0.526562 2 -0.0342219" />
                        </Vertices>
                        <Face id="0" plane="0.0654012 -0 0.997859 -0.00028608" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.997858 0 0.0654115 16.8843 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 188.602 0 0 -1 2043.62 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -700.602 0 0 -1 2043.62 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="3" plane="-0.991933 0 0.126761 -0.517976" album="" material="bm_grid_blank4" texgens="0 1 0 64 0 0 -1 254.9 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 0 4" />
                        </Face>
                        <Face id="4" plane="-2.94309e-006 0 -1 -0.0342234" album="" material="bm_grid_blank4" texgens="-1 0 0 16.85 0 -1 0 79.146 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-43.0941 7.5 -0.363703" rot="1 0 0 0" scale="" transform="1 0 0 -43.0941 0 1 0 7.5 0 0 1 -0.363703 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.549683 -2 -0.0678476" />
                            <Vertex pos="-0.476563 -2 0.136297" />
                            <Vertex pos="0.549683 2 -0.0678476" />
                            <Vertex pos="-0.476563 2 0.136297" />
                            <Vertex pos="0.540939 -2 -0.136297" />
                            <Vertex pos="-0.549686 -2 -0.136297" />
                            <Vertex pos="0.540939 2 -0.136297" />
                            <Vertex pos="-0.549686 2 -0.136297" />
                        </Vertices>
                        <Face id="0" plane="0.195101 0 0.980783 -0.0406999" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.980786 0 0.195087 17.6832 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 51.9609 0 0 -1 2030.55 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -563.961 0 0 -1 2030.55 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0.991939 0 -0.126714 -0.553849" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.13053 0 -0.991445 256.144 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.965853 0 0.259089 -0.495603" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.13053 0 -0.991445 256.144 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.136297" album="" material="bm_grid_blank4" texgens="-1 0 0 7.34998 0 -1 0 77.826 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-44.1922 7.5 -0.195511" rot="1 0 0 0" scale="" transform="1 0 0 -44.1922 0 1 0 7.5 0 0 1 -0.195511 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.621563 -2 -0.0318918" />
                            <Vertex pos="-0.369381 -2 0.304489" />
                            <Vertex pos="0.621563 2 -0.0318921" />
                            <Vertex pos="-0.369381 2 0.304488" />
                            <Vertex pos="0.548439 -2 -0.304489" />
                            <Vertex pos="-0.621567 -2 -0.304489" />
                            <Vertex pos="0.548439 2 -0.304489" />
                            <Vertex pos="-0.621567 2 -0.304489" />
                        </Vertices>
                        <Face id="0" plane="0.321439 7.05518e-008 0.94693 -0.169595" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.946927 0 0.321449 19.1653 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -88.6016 0 0 -1 2009.03 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -423.398 0 0 -1 2009.03 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0.965853 0 -0.259089 -0.608602" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.258823 0 -0.965925 260.162 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.923912 9.40708e-008 0.382605 -0.457774" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.258823 0 -0.965925 260.162 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.304489" album="" material="bm_grid_blank4" texgens="-1 0 0 -0.300293 0 -1 0 76.643 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-45.3402 7.5 0.0359116" rot="1 0 0 0" scale="" transform="1 0 0 -45.3402 0 1 0 7.5 0 0 1 0.0359116 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.778595 -2 0.0730722" />
                            <Vertex pos="-0.159843 -2 0.535912" />
                            <Vertex pos="0.778595 2 0.0730719" />
                            <Vertex pos="-0.159843 2 0.535911" />
                            <Vertex pos="0.526405 -2 -0.535912" />
                            <Vertex pos="-0.778595 -2 -0.535912" />
                            <Vertex pos="0.526405 2 -0.535912" />
                            <Vertex pos="-0.778595 2 -0.535912" />
                        </Vertices>
                        <Face id="0" plane="0.442329 6.84913e-008 0.896853 -0.40993" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.89687 0 0.442295 21.3135 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -235.539 0 0 -1 1979.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -276.461 0 0 -1 1979.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0.923911 0 -0.382606 -0.691395" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.382688 0 -0.923878 267.695 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866048 1.192e-007 0.49996 -0.406366" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.382688 0 -0.923878 267.695 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.535912" album="" material="bm_grid_blank4" texgens="-1 0 0 -4.7251 0 -1 0 75.678 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-46.5692 7.5 0.32658" rot="1 0 0 0" scale="" transform="1 0 0 -46.5692 0 1 0 7.5 0 0 1 0.32658 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.06922 -2 0.245242" />
                            <Vertex pos="0.199223 -2 0.82658" />
                            <Vertex pos="1.06922 2 0.245242" />
                            <Vertex pos="0.199223 2 0.82658" />
                            <Vertex pos="0.45047 -2 -0.82658" />
                            <Vertex pos="-1.06922 -2 -0.82658" />
                            <Vertex pos="0.45047 2 -0.82658" />
                            <Vertex pos="-1.06922 2 -0.82658" />
                        </Vertices>
                        <Face id="0" plane="0.555586 0 0.831459 -0.797953" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.831472 0 0.555567 24.0879 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -392.859 0 0 -1 1942.2 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -119.141 0 0 -1 1942.2 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0.866049 0 -0.49996 -0.803385" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.500004 0 -0.866023 279.903 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.79337 0 0.60874 -0.345115" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.500004 0 -0.866023 279.903 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.82658" album="" material="bm_grid_blank4" texgens="-1 0 0 -4.16504 0 -1 0 74.995 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-47.935 7.5 0.671559" rot="1 0 0 0" scale="" transform="1 0 0 -47.935 0 1 0 7.5 0 0 1 0.671559 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.565 -2 0.481596" />
                            <Vertex pos="0.778122 -2 1.17156" />
                            <Vertex pos="1.565 2 0.481596" />
                            <Vertex pos="0.778122 2 1.17156" />
                            <Vertex pos="0.296558 -2 -1.17156" />
                            <Vertex pos="-1.565 -2 -1.17156" />
                            <Vertex pos="0.296558 2 -1.17156" />
                            <Vertex pos="-1.565 2 -1.17156" />
                        </Vertices>
                        <Face id="0" plane="0.659287 0 0.751892 -1.39389" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.751844 0 0.659341 27.4875 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -567.68 0 0 -1 1898.04 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 55.6797 0 0 -1 1898.04 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0.793369 0 -0.608741 -0.948456" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.608759 0 -0.793356 298.712 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.278203" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.608759 0 -0.793356 298.712 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.17156" album="" material="bm_grid_blank4" texgens="-1 0 0 3.86975 0 -1 0 74.641 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-48.6734 7.5 2.43067" rot="1 0 0 0" scale="" transform="1 0 0 -48.6734 0 1 0 7.5 0 0 1 2.43067 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.826565 -2 0.199225" />
                            <Vertex pos="0.245316 -2 1.0693" />
                            <Vertex pos="0.826565 2 0.199225" />
                            <Vertex pos="0.245316 2 1.0693" />
                            <Vertex pos="-0.826565 -2 -1.0693" />
                            <Vertex pos="-0.826565 -2 0.450478" />
                            <Vertex pos="-0.826565 2 -1.0693" />
                            <Vertex pos="-0.826565 2 0.450478" />
                        </Vertices>
                        <Face id="0" plane="0.831521 0 0.555493 -0.797974" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.555573 0 0.831468 9.39532 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -662.203 0 0 -1 1672.88 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 150.203 0 0 -1 1672.88 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0.608772 0 -0.793346 -0.345135" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.793352 0 -0.608763 280.866 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.499983 0 0.866035 -0.803398" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.793352 0 -0.608763 280.866 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.826565" album="" material="bm_grid_blank4" texgens="0 0 -1 -8.15883 0 -1 0 74.995 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="-48.9641 7.5 3.65982" rot="1 0 0 0" scale="" transform="1 0 0 -48.9641 0 1 0 7.5 0 0 1 3.65982 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.535938 -2 -0.159849" />
                            <Vertex pos="0.0731239 -2 0.778682" />
                            <Vertex pos="0.535938 2 -0.159849" />
                            <Vertex pos="0.0731239 2 0.778682" />
                            <Vertex pos="-0.535938 -2 -0.778682" />
                            <Vertex pos="-0.535938 -2 0.526432" />
                            <Vertex pos="-0.535938 2 -0.778682" />
                            <Vertex pos="-0.535938 2 0.526432" />
                        </Vertices>
                        <Face id="0" plane="0.89688 0 0.442275 -0.409975" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.442291 0 0.896872 12.1721 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -699.398 0 0 -1 1515.54 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 187.398 0 0 -1 1515.54 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0.499991 0 -0.866031 -0.406398" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.866024 0 -0.500003 268.292 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.382642 0 0.923896 -0.691441" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.866024 0 -0.500003 268.292 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.535938" album="" material="bm_grid_blank4" texgens="0 0 -1 -11.0772 0 -1 0 75.678 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="-49.1955 7.5 4.80783" rot="1 0 0 0" scale="" transform="1 0 0 -49.1955 0 1 0 7.5 0 0 1 4.80783 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.304535 -2 -0.369329" />
                            <Vertex pos="-0.0320282 -2 0.621578" />
                            <Vertex pos="0.304535 2 -0.369329" />
                            <Vertex pos="-0.0320282 2 0.621578" />
                            <Vertex pos="-0.304527 -2 -0.621578" />
                            <Vertex pos="-0.304531 -2 0.548547" />
                            <Vertex pos="-0.304527 2 -0.621578" />
                            <Vertex pos="-0.304531 2 0.548547" />
                        </Vertices>
                        <Face id="0" plane="0.946873 0 0.321607 -0.169577" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.321441 0 0.94693 14.3228 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -729.023 0 0 -1 1368.6 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 217.023 0 0 -1 1368.6 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0.382641 0 -0.923897 -0.45775" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.923878 0 -0.382687 260.483 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.258865 0 0.965913 -0.608681" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.923878 0 -0.382687 260.483 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-1 0 -3.41289e-006 -0.304529" album="" material="bm_grid_blank4" texgens="0 0 -1 -8.58449 0 -1 0 76.643 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="-49.3637 7.5 5.90608" rot="1 0 0 0" scale="" transform="1 0 0 -49.3637 0 1 0 7.5 0 0 1 5.90608 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.136246 -2 -0.476672" />
                            <Vertex pos="-0.0678177 -2 0.549702" />
                            <Vertex pos="0.136246 2 -0.476672" />
                            <Vertex pos="-0.0678177 2 0.549702" />
                            <Vertex pos="-0.136246 -2 -0.549702" />
                            <Vertex pos="-0.136246 -2 0.540672" />
                            <Vertex pos="-0.136246 2 -0.549702" />
                            <Vertex pos="-0.136246 2 0.540672" />
                        </Vertices>
                        <Face id="0" plane="0.980803 0 0.195003 -0.0406779" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.195096 0 0.980784 15.8112 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -750.563 0 0 -1 1228.02 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 238.563 0 0 -1 1228.02 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0.258872 0 -0.965912 -0.495693" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.965925 0 -0.258823 256.267 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0.130829 0 0.991405 -0.55385" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.965925 0 -0.258823 256.267 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.136246" album="" material="bm_grid_blank4" texgens="0 0 -1 -2.30153 0 -1 0 77.826 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="-49.4658 7.5 6.97354" rot="1 0 0 0" scale="" transform="1 0 0 -49.4658 0 1 0 7.5 0 0 1 6.97354 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.0342216 -2 -0.517759" />
                            <Vertex pos="-0.0342216 -2 0.526792" />
                            <Vertex pos="0.0342216 2 -0.517759" />
                            <Vertex pos="-0.0342216 2 0.526792" />
                            <Vertex pos="-0.0342216 -2 -0.526791" />
                            <Vertex pos="-0.0342216 2 -0.526791" />
                        </Vertices>
                        <Face id="0" plane="0.99786 0 0.0653838 -0.000295304" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.0654021 0 0.997859 16.6048 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -763.617 0 0 -1 1091.39 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0" />
                        </Face>
                        <Face id="2" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 251.617 0 0 -1 1091.39 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 3" />
                        </Face>
                        <Face id="3" plane="0.130828 0 -0.991405 -0.517786" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.991445 0 -0.130529 254.925 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 2" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -0.0342216" album="" material="bm_grid_blank4" texgens="0 0 -1 6.49271 0 -1 0 79.146 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="-49.4658 7.5 8.02658" rot="1 0 0 0" scale="" transform="1 0 0 -49.4658 0 1 0 7.5 0 0 1 8.02658 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.034214 -2 0.517606" />
                            <Vertex pos="-0.034214 -2 -0.526606" />
                            <Vertex pos="0.034214 2 0.517606" />
                            <Vertex pos="-0.034214 2 -0.526606" />
                            <Vertex pos="-0.034214 -2 0.526606" />
                            <Vertex pos="-0.034214 2 0.526606" />
                        </Vertices>
                        <Face id="0" plane="0.99786 0 -0.0653905 -0.000294257" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.065402 0 0.997859 16.8866 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -763.617 0 0 -1 956.598 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 251.617 0 0 -1 956.598 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="3" plane="0.130402 0 0.991461 -0.517648" album="" material="bm_grid_blank4" texgens="0 1 0 64 -1 0 0 254.905 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 0 4" />
                        </Face>
                        <Face id="4" plane="-1 0 0 -0.034214" album="" material="bm_grid_blank4" texgens="0 0 -1 37.4474 0 -1 0 79.146 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="-49.3638 7.5 9.09389" rot="1 0 0 0" scale="" transform="1 0 0 -49.3638 0 1 0 7.5 0 0 1 9.09389 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0678139 -2 -0.549704" />
                            <Vertex pos="0.13625 -2 0.476642" />
                            <Vertex pos="-0.0678139 2 -0.549704" />
                            <Vertex pos="0.13625 2 0.476642" />
                            <Vertex pos="-0.136246 -2 -0.540704" />
                            <Vertex pos="-0.136246 -2 0.549704" />
                            <Vertex pos="-0.136246 2 -0.540704" />
                            <Vertex pos="-0.136246 2 0.549704" />
                        </Vertices>
                        <Face id="0" plane="0.980802 0 -0.195009 -0.040685" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.195087 0 0.980786 17.6759 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -750.563 0 0 -1 819.982 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 238.563 0 0 -1 819.982 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.130394 0 -0.991462 -0.553853" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.991445 0 0.130524 256.149 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.258974 0 0.965884 -0.495666" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.991445 0 0.130524 256.149 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.136246" album="" material="bm_grid_blank4" texgens="0 0 -1 46.4195 0 -1 0 77.826 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="-49.1955 7.5 10.1921" rot="1 0 0 0" scale="" transform="1 0 0 -49.1955 0 1 0 7.5 0 0 1 10.1921 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0320282 -2 -0.621579" />
                            <Vertex pos="0.304531 -2 0.369359" />
                            <Vertex pos="-0.0320282 2 -0.621579" />
                            <Vertex pos="0.304531 2 0.369359" />
                            <Vertex pos="-0.304535 -2 -0.548514" />
                            <Vertex pos="-0.304535 -2 0.621579" />
                            <Vertex pos="-0.304535 2 -0.548514" />
                            <Vertex pos="-0.304535 2 0.621579" />
                        </Vertices>
                        <Face id="0" plane="0.946877 0 -0.321595 -0.16957" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.321438 0 0.946931 19.1628 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -729.016 0 0 -1 679.41 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 217.016 0 0 -1 679.41 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.258974 0 -0.965884 -0.608668" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.965926 0 0.258818 260.157 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.382601 0 0.923914 -0.45777" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.965926 0 0.258818 260.157 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.304535" album="" material="bm_grid_blank4" texgens="0 0 -1 52.8575 0 -1 0 76.643 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="-48.9641 7.5 11.3401" rot="1 0 0 0" scale="" transform="1 0 0 -48.9641 0 1 0 7.5 0 0 1 11.3401 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0731239 -2 -0.778673" />
                            <Vertex pos="0.535938 -2 0.15986" />
                            <Vertex pos="0.0731239 2 -0.778673" />
                            <Vertex pos="0.535938 2 0.15986" />
                            <Vertex pos="-0.535938 -2 -0.526455" />
                            <Vertex pos="-0.535938 -2 0.778672" />
                            <Vertex pos="-0.535938 2 -0.526455" />
                            <Vertex pos="-0.535938 2 0.778672" />
                        </Vertices>
                        <Face id="0" plane="0.89688 0 -0.442274 -0.40997" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.442287 0 0.896873 21.315 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -699.398 0 0 -1 532.461 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 187.398 0 0 -1 532.461 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.382601 0 -0.923914 -0.691449" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.92388 0 0.382683 267.691 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.499978 0 0.866038 -0.406402" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.92388 0 0.382683 267.691 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.535938" album="" material="bm_grid_blank4" texgens="0 0 -1 55.4775 0 -1 0 75.677 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="-48.6734 7.5 12.5693" rot="1 0 0 0" scale="" transform="1 0 0 -48.6734 0 1 0 7.5 0 0 1 12.5693 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.245316 -2 -1.0693" />
                            <Vertex pos="0.826565 -2 -0.199208" />
                            <Vertex pos="0.245316 2 -1.0693" />
                            <Vertex pos="0.826565 2 -0.199208" />
                            <Vertex pos="-0.826569 -2 -0.450481" />
                            <Vertex pos="-0.826569 -2 1.0693" />
                            <Vertex pos="-0.826569 2 -0.450481" />
                            <Vertex pos="-0.826569 2 1.0693" />
                        </Vertices>
                        <Face id="0" plane="0.831526 0 -0.555486 -0.797967" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.555573 0 0.831468 24.0914 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -662.203 0 0 -1 375.129 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 150.203 0 0 -1 375.129 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.499979 0 -0.866037 -0.803401" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.866026 0 0.5 279.907 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.608766 0 0.79335 -0.345143" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.866026 0 0.5 279.907 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.826569" album="" material="bm_grid_blank4" texgens="0 0 -1 52.6475 0 -1 0 74.995 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="-48.3284 7.5 13.9351" rot="1 0 0 0" scale="" transform="1 0 0 -48.3284 0 1 0 7.5 0 0 1 13.9351 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.48156 -2 -1.56495" />
                            <Vertex pos="1.17156 -2 -0.778201" />
                            <Vertex pos="0.48156 2 -1.56495" />
                            <Vertex pos="1.17156 2 -0.778201" />
                            <Vertex pos="-1.17156 -2 -0.296455" />
                            <Vertex pos="-1.17156 -2 1.56495" />
                            <Vertex pos="-1.17156 2 -0.296455" />
                            <Vertex pos="-1.17156 2 1.56495" />
                        </Vertices>
                        <Face id="0" plane="0.751821 0 -0.659367 -1.39392" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.659341 0 0.751844 27.4911 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -618.039 0 0 -1 200.314 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 106.039 0 0 -1 200.314 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.608765 0 -0.793351 -0.948397" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.793354 0 0.608761 298.709 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.707111 0 0.707102 -0.278156" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.793354 0 0.608761 298.709 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -1.17156" album="" material="bm_grid_blank4" texgens="0 0 -1 42.0274 0 -1 0 74.641 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="-48.3284 7.5 1.06494" rot="1 0 0 0" scale="" transform="1 0 0 -48.3284 0 1 0 7.5 0 0 1 1.06494 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.17157 -2 0.778171" />
                            <Vertex pos="1.17157 2 0.778171" />
                            <Vertex pos="0.481564 -2 1.56495" />
                            <Vertex pos="0.481564 2 1.56495" />
                            <Vertex pos="-1.17157 -2 -1.56495" />
                            <Vertex pos="-1.17157 2 -1.56495" />
                            <Vertex pos="-1.17157 -2 0.296418" />
                            <Vertex pos="-1.17157 2 0.296418" />
                        </Vertices>
                        <Face id="0" plane="0.751831 0 0.659356 -1.39391" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.659351 0 0.751835 5.9939 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.707104 0 -0.70711 -0.278169" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.707104 0 -0.70711 300.12 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.608773 0 0.793345 -0.948382" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.707104 0 -0.70711 300.12 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -618.039 0 0 -1 1847.69 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 106.039 0 0 -1 1847.69 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -1.17157" album="" material="bm_grid_blank4" texgens="0 0 -1 44.9214 0 -1 0 339.784 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="-46.5694 7.5 14.6734" rot="1 0 0 0" scale="" transform="1 0 0 -46.5694 0 1 0 7.5 0 0 1 14.6734 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.199379 -2 -0.82658" />
                            <Vertex pos="1.06938 -2 -0.245236" />
                            <Vertex pos="0.199379 2 -0.82658" />
                            <Vertex pos="1.06938 2 -0.245236" />
                            <Vertex pos="-1.06937 -2 0.826578" />
                            <Vertex pos="0.450623 -2 0.826579" />
                            <Vertex pos="-1.06937 2 0.826578" />
                            <Vertex pos="0.450623 2 0.826579" />
                        </Vertices>
                        <Face id="0" plane="0.555589 0 -0.831457 -0.798039" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.831471 0 0.555569 9.39215 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -392.883 0 0 -1 105.803 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -119.117 0 0 -1 105.803 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.793299 0 -0.608833 -0.345082" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.608761 0 0.793354 280.867 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.866045 0 0.499966 -0.803521" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.608761 0 0.793354 280.867 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-6.2742e-007 0 1 -0.826579" album="" material="bm_grid_blank4" texgens="-1 0 0 -8.15979 0 -1 0 74.995 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="-45.3402 7.5 14.9641" rot="1 0 0 0" scale="" transform="1 0 0 -45.3402 0 1 0 7.5 0 0 1 14.9641 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.159847 -2 -0.535907" />
                            <Vertex pos="0.778603 -2 -0.0730572" />
                            <Vertex pos="-0.159847 2 -0.535907" />
                            <Vertex pos="0.778603 2 -0.0730572" />
                            <Vertex pos="-0.778603 -2 0.535907" />
                            <Vertex pos="0.526413 -2 0.535907" />
                            <Vertex pos="-0.778603 2 0.535907" />
                            <Vertex pos="0.526413 2 0.535907" />
                        </Vertices>
                        <Face id="0" plane="0.442333 0 -0.896851 -0.409923" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.89687 0 0.442295 12.1681 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -235.539 0 0 -1 68.5957 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -276.461 0 0 -1 68.5957 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.866045 0 -0.499966 -0.40637" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.500001 0 0.866025 268.294 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.923907 0 0.382617 -0.691404" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.500001 0 0.866025 268.294 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 -0 1 -0.535907" album="" material="bm_grid_blank4" texgens="-1 0 0 -11.075 0 -1 0 75.677 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="-44.1922 7.5 15.1955" rot="1 0 0 0" scale="" transform="1 0 0 -44.1922 0 1 0 7.5 0 0 1 15.1955 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.36937 -2 -0.304483" />
                            <Vertex pos="0.621559 -2 0.031889" />
                            <Vertex pos="-0.36937 2 -0.304483" />
                            <Vertex pos="0.621559 2 0.031889" />
                            <Vertex pos="-0.621559 -2 0.304483" />
                            <Vertex pos="0.548748 -2 0.304483" />
                            <Vertex pos="-0.621559 2 0.304483" />
                            <Vertex pos="0.548748 2 0.304483" />
                        </Vertices>
                        <Face id="0" plane="0.321437 0 -0.946931 -0.169595" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.946931 0 0.321438 14.3188 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -88.6016 0 0 -1 38.9746 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -423.398 0 0 -1 38.9746 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.923908 0 -0.382615 -0.457764" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.382684 0 0.923879 260.479 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.96613 0 0.258057 -0.608736" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.382684 0 0.923879 260.479 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 -0 1 -0.304483" album="" material="bm_grid_blank4" texgens="-1 0 0 -8.58008 0 -1 0 76.643 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="-43.0939 7.5 15.3637" rot="1 0 0 0" scale="" transform="1 0 0 -43.0939 0 1 0 7.5 0 0 1 15.3637 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.47641 -2 -0.136236" />
                            <Vertex pos="0.549843 -2 0.0678587" />
                            <Vertex pos="-0.476707 2 -0.136294" />
                            <Vertex pos="0.549843 2 0.0678587" />
                            <Vertex pos="-0.54953 -2 0.136294" />
                            <Vertex pos="0.540783 -2 0.136294" />
                            <Vertex pos="-0.549843 2 0.136294" />
                            <Vertex pos="0.540783 2 0.136294" />
                        </Vertices>
                        <Face id="0" plane="0.195053 2.59156e-007 -0.980793 -0.0406936" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.980786 0 0.195087 15.8135 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 51.9844 0 0 -1 17.4453 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -563.984 0 0 -1 17.4453 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.965841 -7.55732e-005 -0.259136 -0.495591" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.258819 0 0.965926 256.265 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.99135 0 0.131243 -0.553993" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.258819 0 0.965926 256.265 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 -0 1 -0.136294" album="" material="bm_grid_blank4" texgens="-1 0 0 -2.30518 0 -1 0 77.826 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="-42.0266 7.5 15.4658" rot="1 0 0 0" scale="" transform="1 0 0 -42.0266 0 1 0 7.5 0 0 1 15.4658 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.517506 -2 -0.0342188" />
                            <Vertex pos="0.526566 -2 0.0342197" />
                            <Vertex pos="-0.517506 2 -0.0342188" />
                            <Vertex pos="0.526566 2 0.0342197" />
                            <Vertex pos="-0.526566 -2 0.0342197" />
                            <Vertex pos="-0.526566 2 0.0342197" />
                        </Vertices>
                        <Face id="0" plane="0.0654092 0 -0.997859 -0.000295855" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.997859 0 0.0654022 16.5977 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 188.602 0 0 -1 4.38086 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -700.602 0 0 -1 4.38086 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 3" />
                        </Face>
                        <Face id="3" plane="-0.991351 0 -0.131237 -0.517521" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.130525 0 0.991445 254.924 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.0342197" album="" material="bm_grid_blank4" texgens="-1 0 0 6.49963 0 -1 0 79.146 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="-47.935 7.5 14.3284" rot="1 0 0 0" scale="" transform="1 0 0 -47.935 0 1 0 7.5 0 0 1 14.3284 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.778126 -2 -1.17157" />
                            <Vertex pos="0.778126 2 -1.17157" />
                            <Vertex pos="1.565 -2 -0.481578" />
                            <Vertex pos="1.565 2 -0.481578" />
                            <Vertex pos="-1.56499 -2 1.17154" />
                            <Vertex pos="-1.56499 2 1.17154" />
                            <Vertex pos="0.296249 -2 1.17158" />
                            <Vertex pos="0.296249 2 1.17158" />
                        </Vertices>
                        <Face id="0" plane="0.659304 0 -0.751877 -1.3939" album="" material="bm_grid_blank4" texgens="0 1 0 64 0.75184 0 0.659346 5.99695 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707106 0 -0.707108 -0.278209" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.707108 0 0.707106 300.122 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.793298 0 0.608833 -0.948311" album="" material="bm_grid_blank4" texgens="0 1 0 64 -0.707108 0 0.707106 300.122 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="-0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -567.68 0 0 -1 149.961 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 55.6797 0 0 -1 149.961 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="-2.14562e-005 0 1 -1.17157" album="" material="bm_grid_blank4" texgens="-1 0 0 44.9202 0 -1 0 339.784 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="-43 7.5 15.65" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 7.5 0 0 1 15.65 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.499996 2 -0.0499992" />
                            <Vertex pos="0.499996 2 -0.15" />
                            <Vertex pos="0.499996 -2 -0.0499992" />
                            <Vertex pos="0.499996 -2 -0.15" />
                            <Vertex pos="-0.499996 2 0.149999" />
                            <Vertex pos="-0.499996 2 -0.15" />
                            <Vertex pos="-0.499996 -2 0.149999" />
                            <Vertex pos="-0.499996 -2 -0.15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.499996" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -38.4363 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.499996" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -38.4363 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 0 -1 -38.4363 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1408 0 0 -1 -38.4363 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.196116 0 0.980581 -0.0490289" album="" material="bm_tile05_A" texgens="1 0 0 128 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.15" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="-42 7.5 15.55" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 7.5 0 0 1 15.55 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.500008 2 0.0500002" />
                            <Vertex pos="-0.500008 2 -0.0500011" />
                            <Vertex pos="-0.500008 -2 0.0500002" />
                            <Vertex pos="-0.500008 -2 -0.0500011" />
                            <Vertex pos="0.500004 2 -0.0500002" />
                            <Vertex pos="0.500004 -2 -0.0500002" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.500008" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -12.7969 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 1 0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1920 0 0 -1 -12.7969 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1664 0 0 -1 -12.7969 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="3" plane="0.0995029 -0 0.995037 2.01166e-007" album="" material="bm_tile05_A" texgens="1 0 0 384 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 0 4" />
                        </Face>
                        <Face id="4" plane="9.0151e-007 0 -1 -0.0500006" album="" material="bm_grid_blank3" texgens="-1 0 0 1920 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="-45 7.5 16" rot="1 0 0 0" scale="" transform="1 0 0 -45 0 1 0 7.5 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.500004 2 0.0999966" />
                            <Vertex pos="0.500004 2 -0.5" />
                            <Vertex pos="0.500004 -2 0.0999966" />
                            <Vertex pos="0.500004 -2 -0.5" />
                            <Vertex pos="-0.500004 2 0.5" />
                            <Vertex pos="-0.500004 2 -0.5" />
                            <Vertex pos="-0.500004 -2 0.5" />
                            <Vertex pos="-0.500004 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.500004" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.500004" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1408 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.371391 0 0.928477 -0.278541" album="" material="bm_tile05_A" texgens="1 0 0 128 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="-44 7.5 15.8" rot="1 0 0 0" scale="" transform="1 0 0 -44 0 1 0 7.5 0 0 1 15.8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 -9.53674e-007" />
                            <Vertex pos="0.5 2 -0.299999" />
                            <Vertex pos="0.5 -2 -9.53674e-007" />
                            <Vertex pos="0.5 -2 -0.299999" />
                            <Vertex pos="-0.5 2 0.299999" />
                            <Vertex pos="-0.5 2 -0.299999" />
                            <Vertex pos="-0.5 -2 0.299999" />
                            <Vertex pos="-0.5 -2 -0.299999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -76.7969 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -76.7969 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1920 0 0 -1 -76.7969 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1664 0 0 -1 -76.7969 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.287348 0 0.957826 -0.143673" album="" material="bm_tile05_A" texgens="1 0 0 384 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.299999" album="" material="bm_grid_blank3" texgens="-1 0 0 1920 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="-46 7.5 16.2" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 7.5 0 0 1 16.2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.299999" />
                            <Vertex pos="0.5 2 -0.700001" />
                            <Vertex pos="0.5 -2 0.299999" />
                            <Vertex pos="0.5 -2 -0.700001" />
                            <Vertex pos="-0.5 2 0.699999" />
                            <Vertex pos="-0.5 2 -0.300001" />
                            <Vertex pos="-0.5 -2 0.699999" />
                            <Vertex pos="-0.5 -2 -0.300001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -179.203 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -179.203 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 128 -0.4 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 -0.4 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.371391 0 0.928477 -0.464237" album="" material="bm_tile05_A" texgens="1 0 0 384 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.371391 0 -0.928477 -0.464239" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="-47 7.5 16.55" rot="1 0 0 0" scale="" transform="1 0 0 -47 0 1 0 7.5 0 0 1 16.55 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.35" />
                            <Vertex pos="0.5 2 -0.650001" />
                            <Vertex pos="0.5 -2 0.35" />
                            <Vertex pos="0.5 -2 -0.650001" />
                            <Vertex pos="-0.5 2 0.650002" />
                            <Vertex pos="-0.5 2 -0.35" />
                            <Vertex pos="-0.5 -2 0.650002" />
                            <Vertex pos="-0.5 -2 -0.35" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -268.797 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -268.797 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 128 -0.3 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 -0.3 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.28735 0 0.957826 -0.478914" album="" material="bm_tile05_A" texgens="1 0 0 128 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.287349 0 -0.957826 -0.478914" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="-48 7.5 16.8" rot="1 0 0 0" scale="" transform="1 0 0 -48 0 1 0 7.5 0 0 1 16.8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.4" />
                            <Vertex pos="0.5 2 -0.599998" />
                            <Vertex pos="0.5 -2 0.4" />
                            <Vertex pos="0.5 -2 -0.599998" />
                            <Vertex pos="-0.5 2 0.599998" />
                            <Vertex pos="-0.5 2 -0.4" />
                            <Vertex pos="-0.5 -2 0.599998" />
                            <Vertex pos="-0.5 -2 -0.4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -332.797 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -332.797 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 128 -0.2 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 -0.2 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.196114 0 0.980581 -0.49029" album="" material="bm_tile05_A" texgens="1 0 0 384 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.196114 0 -0.980581 -0.49029" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="-49 7.5 16.95" rot="1 0 0 0" scale="" transform="1 0 0 -49 0 1 0 7.5 0 0 1 16.95 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.449999" />
                            <Vertex pos="0.5 2 -0.550001" />
                            <Vertex pos="0.5 -2 0.449999" />
                            <Vertex pos="0.5 -2 -0.550001" />
                            <Vertex pos="-0.5 2 0.549999" />
                            <Vertex pos="-0.5 2 -0.450001" />
                            <Vertex pos="-0.5 -2 0.549999" />
                            <Vertex pos="-0.5 -2 -0.450001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -371.203 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -371.203 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 128 -0.1 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 -0.1 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.0995037 0 0.995037 -0.497518" album="" material="bm_tile05_A" texgens="1 0 0 128 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.0995037 0 -0.995037 -0.49752" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="-51.5 7.5 -8.5" rot="1 0 0 0" scale="" transform="1 0 0 -51.5 0 1 0 7.5 0 0 1 -8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 24" />
                            <Vertex pos="2 2 -36" />
                            <Vertex pos="2 -2 24" />
                            <Vertex pos="2 -2 -36" />
                            <Vertex pos="-2 2 24" />
                            <Vertex pos="-2 2 -36" />
                            <Vertex pos="-2 -2 24" />
                            <Vertex pos="-2 -2 -36" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -24" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -36" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="-50 7.5 17.05" rot="1 0 0 0" scale="" transform="1 0 0 -50 0 1 0 7.5 0 0 1 17.05 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.450001" />
                            <Vertex pos="0.5 2 -0.549999" />
                            <Vertex pos="0.5 -2 0.450001" />
                            <Vertex pos="0.5 -2 -0.549999" />
                            <Vertex pos="-0.5 2 0.550001" />
                            <Vertex pos="-0.5 2 -0.449999" />
                            <Vertex pos="-0.5 -2 0.550001" />
                            <Vertex pos="-0.5 -2 -0.449999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -371.197 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -371.197 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 128 -0.1 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 -0.1 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.0995037 0 0.995037 -0.49752" album="" material="bm_tile05_A" texgens="1 0 0 384 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.0995037 0 -0.995037 -0.497518" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="-51 7.5 17.2" rot="1 0 0 0" scale="" transform="1 0 0 -51 0 1 0 7.5 0 0 1 17.2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.4" />
                            <Vertex pos="0.5 2 -0.6" />
                            <Vertex pos="0.5 -2 0.4" />
                            <Vertex pos="0.5 -2 -0.6" />
                            <Vertex pos="-0.5 2 0.599998" />
                            <Vertex pos="-0.5 2 -0.400002" />
                            <Vertex pos="-0.5 -2 0.599998" />
                            <Vertex pos="-0.5 -2 -0.400002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -332.803 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -332.803 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 128 -0.2 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 -0.2 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.196114 0 0.980581 -0.49029" album="" material="bm_tile05_A" texgens="1 0 0 128 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.196114 0 -0.980581 -0.490291" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="-52 7.5 17.45" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 7.5 0 0 1 17.45 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.35" />
                            <Vertex pos="0.5 2 -0.650002" />
                            <Vertex pos="0.5 -2 0.35" />
                            <Vertex pos="0.5 -2 -0.650002" />
                            <Vertex pos="-0.5 2 0.650002" />
                            <Vertex pos="-0.5 2 -0.35" />
                            <Vertex pos="-0.5 -2 0.650002" />
                            <Vertex pos="-0.5 -2 -0.35" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -268.783 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -268.783 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 128 -0.3 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 -0.3 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.28735 0 0.957826 -0.478914" album="" material="bm_tile05_A" texgens="1 0 0 384 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.28735 0 -0.957826 -0.478914" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="-53 7.5 17.8" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 7.5 0 0 1 17.8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.300001" />
                            <Vertex pos="0.5 2 -0.699999" />
                            <Vertex pos="0.5 -2 0.300001" />
                            <Vertex pos="0.5 -2 -0.699999" />
                            <Vertex pos="-0.5 2 0.700001" />
                            <Vertex pos="-0.5 2 -0.299999" />
                            <Vertex pos="-0.5 -2 0.700001" />
                            <Vertex pos="-0.5 -2 -0.299999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -179.243 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -179.243 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 128 -0.4 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 128 -0.4 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.371391 0 0.928477 -0.464239" album="" material="bm_tile05_A" texgens="1 0 0 128 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.371391 0 -0.928477 -0.464237" album="" material="bm_grid_blank3" texgens="-1 0 0 1664 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="-55.5 7.5 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -55.5 0 1 0 7.5 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 25" />
                            <Vertex pos="2 2 -37" />
                            <Vertex pos="2 -2 25" />
                            <Vertex pos="2 -2 -37" />
                            <Vertex pos="-2 2 25" />
                            <Vertex pos="-2 2 -37" />
                            <Vertex pos="-2 -2 25" />
                            <Vertex pos="-2 -2 -37" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -25" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -37" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="-59.5 7.5 15.5" rot="1 0 0 0" scale="" transform="1 0 0 -59.5 0 1 0 7.5 0 0 1 15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 9.53674e-007" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="-57.5 7.5 18" rot="1 0 0 0" scale="" transform="1 0 0 -57.5 0 1 0 7.5 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 5120 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -4864 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile05_A" texgens="1 0 0 -4608 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 5120 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="-53 7.5 16.5" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 7.5 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.6" />
                            <Vertex pos="0.5 2 -1" />
                            <Vertex pos="0.5 -2 0.6" />
                            <Vertex pos="0.5 -2 -1" />
                            <Vertex pos="-0.5 2 1" />
                            <Vertex pos="-0.5 2 -1" />
                            <Vertex pos="-0.5 -2 1" />
                            <Vertex pos="-0.5 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.371391 0 0.928477 -0.742781" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="-52 7.5 16.3" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 7.5 0 0 1 16.3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.5" />
                            <Vertex pos="0.5 2 -0.799999" />
                            <Vertex pos="0.5 -2 0.5" />
                            <Vertex pos="0.5 -2 -0.799999" />
                            <Vertex pos="-0.5 2 0.800001" />
                            <Vertex pos="-0.5 2 -0.799999" />
                            <Vertex pos="-0.5 -2 0.800001" />
                            <Vertex pos="-0.5 -2 -0.799999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -1894.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -1894.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 64 0 0 -1 -1894.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 192 0 0 -1 -1894.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.287349 0 0.957826 -0.622587" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.799999" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="-51 7.5 16.15" rot="1 0 0 0" scale="" transform="1 0 0 -51 0 1 0 7.5 0 0 1 16.15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.450001" />
                            <Vertex pos="0.5 2 -0.65" />
                            <Vertex pos="0.5 -2 0.450001" />
                            <Vertex pos="0.5 -2 -0.65" />
                            <Vertex pos="-0.5 2 0.65" />
                            <Vertex pos="-0.5 2 -0.65" />
                            <Vertex pos="-0.5 -2 0.65" />
                            <Vertex pos="-0.5 -2 -0.65" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -1875.2 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -1875.2 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 0 -1 -1875.2 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 0 -1 -1875.2 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.196115 0 0.980581 -0.53932" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.65" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="-50 7.5 16.05" rot="1 0 0 0" scale="" transform="1 0 0 -50 0 1 0 7.5 0 0 1 16.05 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.449999" />
                            <Vertex pos="0.5 2 -0.549999" />
                            <Vertex pos="0.5 -2 0.449999" />
                            <Vertex pos="0.5 -2 -0.549999" />
                            <Vertex pos="-0.5 2 0.549999" />
                            <Vertex pos="-0.5 2 -0.549999" />
                            <Vertex pos="-0.5 -2 0.549999" />
                            <Vertex pos="-0.5 -2 -0.549999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -1862.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -1862.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 64 0 0 -1 -1862.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 192 0 0 -1 -1862.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.0995037 0 0.995037 -0.497518" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.549999" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="-49 7.5 16" rot="1 0 0 0" scale="" transform="1 0 0 -49 0 1 0 7.5 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.4" />
                            <Vertex pos="0.5 2 -0.5" />
                            <Vertex pos="0.5 -2 0.4" />
                            <Vertex pos="0.5 -2 -0.5" />
                            <Vertex pos="-0.5 2 0.5" />
                            <Vertex pos="-0.5 2 -0.5" />
                            <Vertex pos="-0.5 -2 0.5" />
                            <Vertex pos="-0.5 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 0 -1 -1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 0 -1 -1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.0995037 0 0.995037 -0.447767" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="-48 7.5 15.95" rot="1 0 0 0" scale="" transform="1 0 0 -48 0 1 0 7.5 0 0 1 15.95 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.250002" />
                            <Vertex pos="0.5 2 -0.450001" />
                            <Vertex pos="0.5 -2 0.250002" />
                            <Vertex pos="0.5 -2 -0.450001" />
                            <Vertex pos="-0.5 2 0.450001" />
                            <Vertex pos="-0.5 2 -0.450001" />
                            <Vertex pos="-0.5 -2 0.450001" />
                            <Vertex pos="-0.5 -2 -0.450001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -1849.6 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -1849.6 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 64 0 0 -1 -1849.6 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 192 0 0 -1 -1849.6 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.196115 0 0.980581 -0.343205" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.450001" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="-47 7.5 15.85" rot="1 0 0 0" scale="" transform="1 0 0 -47 0 1 0 7.5 0 0 1 15.85 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.0500002" />
                            <Vertex pos="0.5 2 -0.35" />
                            <Vertex pos="0.5 -2 0.0500002" />
                            <Vertex pos="0.5 -2 -0.35" />
                            <Vertex pos="-0.5 2 0.35" />
                            <Vertex pos="-0.5 2 -0.35" />
                            <Vertex pos="-0.5 -2 0.35" />
                            <Vertex pos="-0.5 -2 -0.35" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -1836.8 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -1836.8 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 0 -1 -1836.8 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 0 -1 -1836.8 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.287348 0 0.957826 -0.191565" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.35" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="-46 7.5 15.675" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 7.5 0 0 1 15.675 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 -0.174999" />
                            <Vertex pos="0.5 2 -0.225" />
                            <Vertex pos="0.5 -2 -0.174999" />
                            <Vertex pos="0.5 -2 -0.225" />
                            <Vertex pos="-0.5 2 0.225" />
                            <Vertex pos="-0.5 2 -0.225" />
                            <Vertex pos="-0.5 -2 0.225" />
                            <Vertex pos="-0.5 -2 -0.225" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -1814.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -1814.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 64 0 0 -1 -1814.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 192 0 0 -1 -1814.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.37139 0 0.928477 -0.0232124" album="" material="bm_grid_blank4" texgens="1 0 0 -192 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.225" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="22.5 7.5 -14.5" rot="1 0 0 0" scale="" transform="1 0 0 22.5 0 1 0 7.5 0 0 1 -14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 18" />
                            <Vertex pos="2 2 -30" />
                            <Vertex pos="2 -2 18" />
                            <Vertex pos="2 -2 -30" />
                            <Vertex pos="-2 2 18" />
                            <Vertex pos="-2 2 -30" />
                            <Vertex pos="-2 -2 18" />
                            <Vertex pos="-2 -2 -30" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -30" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="18.5 7.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 18.5 0 1 0 7.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -1.19209e-007" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -1.19209e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="-8.5 23.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 23.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.5" />
                            <Vertex pos="1 2 -0.5" />
                            <Vertex pos="1 -2 0.5" />
                            <Vertex pos="1 -2 -0.5" />
                            <Vertex pos="-1 2 0.5" />
                            <Vertex pos="-1 2 -0.5" />
                            <Vertex pos="-1 -2 0.5" />
                            <Vertex pos="-1 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="-7.5 27.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 27.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="-6.5 31.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 31.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.5" />
                            <Vertex pos="1 2 -0.5" />
                            <Vertex pos="1 -2 0.5" />
                            <Vertex pos="1 -2 -0.5" />
                            <Vertex pos="-1 2 0.5" />
                            <Vertex pos="-1 2 -0.5" />
                            <Vertex pos="-1 -2 0.5" />
                            <Vertex pos="-1 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="-7.5 35.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 35.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 2.38419e-007" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="-7.5 35.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 35.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-9.5 41.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.5 0 1 0 41.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 16" />
                            <Vertex pos="4 4 8" />
                            <Vertex pos="4 -4 16" />
                            <Vertex pos="4 -4 12" />
                            <Vertex pos="-4 4 16" />
                            <Vertex pos="-4 4 8" />
                            <Vertex pos="-4 -4 16" />
                            <Vertex pos="-4 -4 12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 8.94427" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="-9.5 41.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -9.5 0 1 0 41.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="1" type="999" pos="-15.5 41.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -15.5 0 1 0 41.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile11_A" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="-41.5 41.5 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 41.5 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 16" />
                            <Vertex pos="4 4 -28" />
                            <Vertex pos="4 -4 16" />
                            <Vertex pos="4 -4 -28" />
                            <Vertex pos="-4 4 16" />
                            <Vertex pos="-4 4 -28" />
                            <Vertex pos="-4 -4 16" />
                            <Vertex pos="-4 -4 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="-41.5 41.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 41.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="-39.5 49.5 -12" rot="1 0 0 0" scale="" transform="1 0 0 -39.5 0 1 0 49.5 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 20.5" />
                            <Vertex pos="2 4 -32.5" />
                            <Vertex pos="2 -4 20.5" />
                            <Vertex pos="2 -4 -32.5" />
                            <Vertex pos="-2 4 20.5" />
                            <Vertex pos="-2 4 -32.5" />
                            <Vertex pos="-2 -4 20.5" />
                            <Vertex pos="-2 -4 -32.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20.5" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32.5" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="-43.5 46.5 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -43.5 0 1 0 46.5 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.75" />
                            <Vertex pos="2 1 -0.250002" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.75" />
                            <Vertex pos="-2 1 0.75" />
                            <Vertex pos="-2 1 -0.250002" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.485071" album="" material="bm_friction_sand" texgens="1 0 0 -11136 0 -1 0 -11904 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242535 -0.970143 -0.485072" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="-43.5 52.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -43.5 0 1 0 52.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.75" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.75" />
                            <Vertex pos="-2 1 0.75" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.485071" album="" material="bm_friction_sand" texgens="1 0 0 -11136 0 -1 0 -13440 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="-43.5 49.5 2" rot="1 0 0 0" scale="" transform="1 0 0 -43.5 0 1 0 49.5 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 1" />
                            <Vertex pos="2 -2 -1" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 1" />
                            <Vertex pos="-2 -2 -1" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -383.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0.75 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 -383.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 -383.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -0.4" album="" material="bm_friction_sand" texgens="1 0 0 -11136 0 -1 0 -12672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.6 -0.8 -0.4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="-39.5 49.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -39.5 0 1 0 49.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="-33.5 53.5 -5.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.5 0 1 0 53.5 0 0 1 -5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 27" />
                            <Vertex pos="4 4 -39" />
                            <Vertex pos="4 -4 27" />
                            <Vertex pos="4 -4 -39" />
                            <Vertex pos="-4 4 27" />
                            <Vertex pos="-4 4 -39" />
                            <Vertex pos="-4 -4 27" />
                            <Vertex pos="-4 -4 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="-41.5 55.5 4" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 55.5 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="-41.5 55.5 -14.5" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 55.5 0 0 1 -14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 18" />
                            <Vertex pos="4 2 -30" />
                            <Vertex pos="4 -2 18" />
                            <Vertex pos="4 -2 -30" />
                            <Vertex pos="-4 2 18" />
                            <Vertex pos="-4 2 -30" />
                            <Vertex pos="-4 -2 18" />
                            <Vertex pos="-4 -2 -30" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -30" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="-35.5 47.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -35.5 0 1 0 47.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -9088 0 -1 0 -12160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="-23.5 47.5 -12" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 47.5 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14 2 20.5" />
                            <Vertex pos="14 2 -32.5" />
                            <Vertex pos="14 -2 20.5" />
                            <Vertex pos="14 -2 -32.5" />
                            <Vertex pos="-14 2 20.5" />
                            <Vertex pos="-14 2 -32.5" />
                            <Vertex pos="-14 -2 20.5" />
                            <Vertex pos="-14 -2 -32.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -14" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -14" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1024 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20.5" album="" material="bm_grid_blank4" texgens="1 0 0 -1024 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32.5" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="-15.5 47.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -15.5 0 1 0 47.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -3968 0 -1 0 -12160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="-32.5 46.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -32.5 0 1 0 46.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -8320 0 -1 0 -11904 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="-18.5 46.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 46.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -4736 0 -1 0 -11904 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="-25.5 47.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -25.5 0 1 0 47.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -6528 0 -1 0 -12160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="-22.5 46.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -22.5 0 1 0 46.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -0.999996 0.5" />
                            <Vertex pos="-1 -0.999996 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707106 -0 -1.41421" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -5760 0 -1 0 -11904 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-28.5 46.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -28.5 0 1 0 46.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -1.41421" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -7296 0 -1 0 -11904 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-30.5 46.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 46.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -7808 0 -1 0 -11904 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-20.5 46.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -20.5 0 1 0 46.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -5248 0 -1 0 -11904 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-11.5 49.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 49.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-11.5 51.5 -12" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 51.5 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 20.5" />
                            <Vertex pos="2 2 -32.5" />
                            <Vertex pos="2 -2 20.5" />
                            <Vertex pos="2 -2 -32.5" />
                            <Vertex pos="-2 2 20.5" />
                            <Vertex pos="-2 2 -32.5" />
                            <Vertex pos="-2 -2 20.5" />
                            <Vertex pos="-2 -2 -32.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20.5" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="-13.5 59.5 16" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 59.5 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="-13.5 59.5 -8.5" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 59.5 0 0 1 -8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 24" />
                            <Vertex pos="4 2 -36" />
                            <Vertex pos="4 -2 24" />
                            <Vertex pos="4 -2 -36" />
                            <Vertex pos="-4 2 24" />
                            <Vertex pos="-4 2 -36" />
                            <Vertex pos="-4 -2 24" />
                            <Vertex pos="-4 -2 -36" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -2048 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -24" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -36" album="" material="bm_grid_blank4" texgens="-1 0 0 -2048 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="-11.5 55.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 55.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_bounce_high" texgens="1 0 0 0 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="-18.5 59.5 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 59.5 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.250002" />
                            <Vertex pos="1 2 -0.750002" />
                            <Vertex pos="1 -2 0.250002" />
                            <Vertex pos="1 -2 -0.750002" />
                            <Vertex pos="-1 2 0.750002" />
                            <Vertex pos="-1 2 -0.250002" />
                            <Vertex pos="-1 -2 0.750002" />
                            <Vertex pos="-1 -2 -0.250002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 -0.25 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.485073" album="" material="bm_friction_sand" texgens="1 0 0 -4736 0 -1 0 -15232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.485073" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="-23.5 59.5 19" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 59.5 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 -2" />
                            <Vertex pos="4 2 -3" />
                            <Vertex pos="4 -2 -2" />
                            <Vertex pos="4 -2 -3" />
                            <Vertex pos="-4 2 3" />
                            <Vertex pos="-4 2 2" />
                            <Vertex pos="-4 -2 3" />
                            <Vertex pos="-4 -2 2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 -0.625 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.529999 0 0.847998 -0.423999" album="" material="bm_friction_sand" texgens="1 0 0 -6016 0 -1 0 -15232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.529999 0 -0.847998 -0.423999" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-28.5 59.5 21.75" rot="1 0 0 0" scale="" transform="1 0 0 -28.5 0 1 0 59.5 0 0 1 21.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.250002" />
                            <Vertex pos="1 2 -0.75" />
                            <Vertex pos="1 -2 0.250002" />
                            <Vertex pos="1 -2 -0.75" />
                            <Vertex pos="-1 2 0.750002" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.750002" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 -0.25 0 -1 128.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 -1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.485073" album="" material="bm_friction_sand" texgens="1 0 0 -7296 0 -1 0 -15232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="-33.5 59.5 22" rot="1 0 0 0" scale="" transform="1 0 0 -33.5 0 1 0 59.5 0 0 1 22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="-33.5 59.5 -5.5" rot="1 0 0 0" scale="" transform="1 0 0 -33.5 0 1 0 59.5 0 0 1 -5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 27" />
                            <Vertex pos="4 2 -39" />
                            <Vertex pos="4 -2 27" />
                            <Vertex pos="4 -2 -39" />
                            <Vertex pos="-4 2 27" />
                            <Vertex pos="-4 2 -39" />
                            <Vertex pos="-4 -2 27" />
                            <Vertex pos="-4 -2 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -2048 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_grid_blank4" texgens="1 0 0 2304 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="" material="bm_grid_blank4" texgens="-1 0 0 -2048 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="-33.5 53.5 22" rot="1 0 0 0" scale="" transform="1 0 0 -33.5 0 1 0 53.5 0 0 1 22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-27.5 55.5 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 -27.5 0 1 0 55.5 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 28" />
                            <Vertex pos="2 2 -40" />
                            <Vertex pos="2 -2 28" />
                            <Vertex pos="2 -2 -40" />
                            <Vertex pos="-2 2 28" />
                            <Vertex pos="-2 2 -40" />
                            <Vertex pos="-2 -2 28" />
                            <Vertex pos="-2 -2 -40" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -28" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -40" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-27.5 55.5 24" rot="1 0 0 0" scale="" transform="1 0 0 -27.5 0 1 0 55.5 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-27.5 51.5 23" rot="1 0 0 0" scale="" transform="1 0 0 -27.5 0 1 0 51.5 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1.5" />
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 -2 1.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 2 -1.5" />
                            <Vertex pos="-2 -2 -0.5" />
                            <Vertex pos="-2 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0.5 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.447214" album="" material="bm_tile06_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.447214" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-23.5 53.5 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 53.5 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 28" />
                            <Vertex pos="2 4 -40" />
                            <Vertex pos="2 -4 28" />
                            <Vertex pos="2 -4 -40" />
                            <Vertex pos="-2 4 28" />
                            <Vertex pos="-2 4 -40" />
                            <Vertex pos="-2 -4 28" />
                            <Vertex pos="-2 -4 -40" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -28" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -40" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="-23.5 53.5 24" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 53.5 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -1024 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-19.5 55.5 25" rot="1 0 0 0" scale="" transform="1 0 0 -19.5 0 1 0 55.5 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1.5" />
                            <Vertex pos="2 2 0.500002" />
                            <Vertex pos="2 -2 1.5" />
                            <Vertex pos="2 -2 0.500002" />
                            <Vertex pos="-2 2 -0.500002" />
                            <Vertex pos="-2 2 -1.5" />
                            <Vertex pos="-2 -2 -0.500002" />
                            <Vertex pos="-2 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0.5 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.447213" album="" material="bm_tile06_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.447213" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-19.5 51.5 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -19.5 0 1 0 51.5 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 29" />
                            <Vertex pos="2 2 -41" />
                            <Vertex pos="2 -2 29" />
                            <Vertex pos="2 -2 -41" />
                            <Vertex pos="-2 2 29" />
                            <Vertex pos="-2 2 -41" />
                            <Vertex pos="-2 -2 29" />
                            <Vertex pos="-2 -2 -41" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -29" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -41" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="-19.5 51.5 26" rot="1 0 0 0" scale="" transform="1 0 0 -19.5 0 1 0 51.5 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="-15.5 53.5 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.5 0 1 0 53.5 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 29" />
                            <Vertex pos="2 4 -41" />
                            <Vertex pos="2 -4 29" />
                            <Vertex pos="2 -4 -41" />
                            <Vertex pos="-2 4 29" />
                            <Vertex pos="-2 4 -41" />
                            <Vertex pos="-2 -4 29" />
                            <Vertex pos="-2 -4 -41" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -29" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -41" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="-15.5 53.5 26" rot="1 0 0 0" scale="" transform="1 0 0 -15.5 0 1 0 53.5 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-19.5 55.5 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -19.5 0 1 0 55.5 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 29" />
                            <Vertex pos="2 2 -41" />
                            <Vertex pos="2 -2 29" />
                            <Vertex pos="2 -2 -41" />
                            <Vertex pos="-2 2 27" />
                            <Vertex pos="-2 2 -41" />
                            <Vertex pos="-2 -2 27" />
                            <Vertex pos="-2 -2 -41" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -25.044" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -41" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="-27.5 51.5 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 -27.5 0 1 0 51.5 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 28" />
                            <Vertex pos="2 2 -40" />
                            <Vertex pos="2 -2 28" />
                            <Vertex pos="2 -2 -40" />
                            <Vertex pos="-2 2 26" />
                            <Vertex pos="-2 2 -40" />
                            <Vertex pos="-2 -2 26" />
                            <Vertex pos="-2 -2 -40" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -24.1495" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -40" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="-11.5 55.5 26" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 55.5 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="-11.5 55.5 23.5" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 55.5 0 0 1 23.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 1.90735e-006" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 1.90735e-006" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.894426" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="-21.5 41.5 1" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 41.5 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.125" texRot="0" texScale="0.0625 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 -768 0 0.0625 0.125" texRot="0" texScale="0.0625 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="-21.625 41.5 1.625" rot="1 0 0 0" scale="" transform="1 0 0 -21.625 0 1 0 41.5 0 0 1 1.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.125 4 0.125" />
                            <Vertex pos="0.125 -3.75 0.125" />
                            <Vertex pos="0.125 4 -0.125" />
                            <Vertex pos="0.125 -4 -0.125" />
                            <Vertex pos="-0.125 4 -0.125" />
                            <Vertex pos="-0.125 -4 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 -0" album="" material="bm_stripe_caution1" texgens="1 -1 0 992 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 0 -1 224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -2.74004" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -0.707107 -0.707107 -1856.8 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.125" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="-21.375 41.5 1.625" rot="1 0 0 0" scale="" transform="1 0 0 -21.375 0 1 0 41.5 0 0 1 1.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.125 4 0.125004" />
                            <Vertex pos="-0.125 -3.75 0.125004" />
                            <Vertex pos="0.125002 4 -0.125004" />
                            <Vertex pos="0.125002 -4 -0.125004" />
                            <Vertex pos="-0.125 4 -0.125004" />
                            <Vertex pos="-0.125 -4 -0.125004" />
                        </Vertices>
                        <Face id="0" plane="0.707115 -0 0.707098 -7.07805e-007" album="" material="bm_stripe_caution1" texgens="1 1 0 992 0 0 -1 32.002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_grid_blank2" texgens="0 -1 0 -768 0 0 -1 224.002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 0 -1 224.002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.707118 0.707096 -2.74008" album="" material="bm_grid_blank2" texgens="1 0 0 192 0 -0.707107 -0.707107 -1856.8 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.125004" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="-21.5 40.5 2" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 40.5 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.5" />
                            <Vertex pos="0.25 1 -0.5" />
                            <Vertex pos="0.25 -1 0.5" />
                            <Vertex pos="0.25 -1 -0.5" />
                            <Vertex pos="-0.25 1 0.5" />
                            <Vertex pos="-0.25 1 -0.5" />
                            <Vertex pos="-0.25 -1 0.5" />
                            <Vertex pos="-0.25 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 1 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.125" texRot="0" texScale="0.0625 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="-21.5 44.5 2" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 44.5 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.5" />
                            <Vertex pos="0.25 1 -0.5" />
                            <Vertex pos="0.25 -1 0.5" />
                            <Vertex pos="0.25 -1 -0.5" />
                            <Vertex pos="-0.25 1 0.5" />
                            <Vertex pos="-0.25 1 -0.5" />
                            <Vertex pos="-0.25 -1 0.5" />
                            <Vertex pos="-0.25 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 1 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.125" texRot="0" texScale="0.0625 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="-21.625 40.5 2.625" rot="1 0 0 0" scale="" transform="1 0 0 -21.625 0 1 0 40.5 0 0 1 2.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.125 0.750004 0.124999" />
                            <Vertex pos="0.125 -0.750004 0.124999" />
                            <Vertex pos="0.125 1 -0.124999" />
                            <Vertex pos="0.125 -1 -0.124999" />
                            <Vertex pos="-0.124998 1 -0.124999" />
                            <Vertex pos="-0.124998 -1 -0.124999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_grid_blank2" texgens="0 1 0 768 0 0 -1 224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 7.07805e-007" album="" material="bm_stripe_caution1" texgens="1 -1 0 1248 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.70711 0.707104 -0.618722" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 -1 128 0 0.0625 0.03125" texRot="0" texScale="0.0625 0.03125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.70711 0.707104 -0.618722" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -0.707107 -0.707107 -1344.8 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.124999" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="-21.375 40.5 2.625" rot="1 0 0 0" scale="" transform="1 0 0 -21.375 0 1 0 40.5 0 0 1 2.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.125 0.750004 0.124999" />
                            <Vertex pos="-0.125 -0.75 0.124999" />
                            <Vertex pos="0.124998 1 -0.125" />
                            <Vertex pos="0.124998 -1 -0.125" />
                            <Vertex pos="-0.125 1 -0.125" />
                            <Vertex pos="-0.125 -1 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707108 -0 0.707105 1.06543e-006" album="" material="bm_stripe_caution1" texgens="1 1 0 736 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_grid_blank2" texgens="0 -1 0 -512 0 0 -1 224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707111 0.707103 -0.618723" album="" material="bm_grid_blank2" texgens="-1 0 0 64 0 0 -1 128 0 0.0625 0.03125" texRot="0" texScale="0.0625 0.03125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.707105 0.707108 -0.618717" album="" material="bm_grid_blank2" texgens="1 0 0 192 0 -0.707107 -0.707107 -1344.8 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.125" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="-21.625 44.5 2.625" rot="1 0 0 0" scale="" transform="1 0 0 -21.625 0 1 0 44.5 0 0 1 2.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.125 0.999996 0.124999" />
                            <Vertex pos="0.125 -0.750008 0.124998" />
                            <Vertex pos="0.125 1 -0.124999" />
                            <Vertex pos="0.125 -1 -0.124999" />
                            <Vertex pos="-0.124998 1 -0.124999" />
                            <Vertex pos="-0.124998 -1 -0.124999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_grid_blank2" texgens="0 1 0 768 0 0 -1 224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 7.07805e-007" album="" material="bm_stripe_caution1" texgens="1 -1 0 1248 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 1.59742e-005 -0.999998" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 -1 128 0 0.0625 0.03125" texRot="0" texScale="0.0625 0.03125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.707114 0.7071 -0.618727" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -0.707107 -0.707107 -1342.9 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.124999" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="-21.375 44.5 2.625" rot="1 0 0 0" scale="" transform="1 0 0 -21.375 0 1 0 44.5 0 0 1 2.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.125 1 0.125" />
                            <Vertex pos="-0.125 -0.750004 0.125" />
                            <Vertex pos="0.125 1 -0.125" />
                            <Vertex pos="0.125 -1 -0.125" />
                            <Vertex pos="-0.125 1 -0.125" />
                            <Vertex pos="-0.125 -1 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0 0.707107 -0" album="" material="bm_stripe_caution1" texgens="1 1 0 736 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_grid_blank2" texgens="0 -1 0 -512 0 0 -1 224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 0 -1" album="" material="bm_grid_blank2" texgens="-1 0 0 64 0 0 -1 128 0 0.0625 0.03125" texRot="0" texScale="0.0625 0.03125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.707112 0.707101 -0.618725" album="" material="bm_grid_blank2" texgens="1 0 0 192 0 -0.707107 -0.707107 -1342.9 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.125" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="-29.5 41.5 1" rot="1 0 0 0" scale="" transform="1 0 0 -29.5 0 1 0 41.5 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.125" texRot="0" texScale="0.0625 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 -768 0 0.0625 0.125" texRot="0" texScale="0.0625 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="-29.625 41.5 1.625" rot="1 0 0 0" scale="" transform="1 0 0 -29.625 0 1 0 41.5 0 0 1 1.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.125 4 0.124999" />
                            <Vertex pos="0.125 -3.75 0.125" />
                            <Vertex pos="0.125 4 -0.125" />
                            <Vertex pos="0.125 -4 -0.125" />
                            <Vertex pos="-0.125 4 -0.125" />
                            <Vertex pos="-0.125 -4 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.125" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707105 0 0.707108 3.50177e-007" album="" material="bm_stripe_caution1" texgens="1 -1 0 992 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 0 -1 224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -2.74004" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -0.707107 -0.707107 -1856.8 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.125" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="-29.375 41.5 1.625" rot="1 0 0 0" scale="" transform="1 0 0 -29.375 0 1 0 41.5 0 0 1 1.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.125 4 0.124996" />
                            <Vertex pos="-0.125 -3.75 0.125002" />
                            <Vertex pos="0.124994 4 -0.125002" />
                            <Vertex pos="0.125002 -4 -0.125002" />
                            <Vertex pos="-0.125 4 -0.125002" />
                            <Vertex pos="-0.125 -4 -0.125002" />
                        </Vertices>
                        <Face id="0" plane="0.70711 5.47227e-007 0.707104 1.40816e-006" album="" material="bm_stripe_caution1" texgens="1 1 0 992 0 0 -1 32.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_grid_blank2" texgens="0 -1 0 -768 0 0 -1 224.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 0 -1 224.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.707112 0.707101 -2.74006" album="" material="bm_grid_blank2" texgens="1 0 0 192 0 -0.707107 -0.707107 -1856.8 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.125002" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="-29.5 39 2" rot="1 0 0 0" scale="" transform="1 0 0 -29.5 0 1 0 39 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 0.5" />
                            <Vertex pos="0.25 1.5 -0.5" />
                            <Vertex pos="0.25 -1.5 0.5" />
                            <Vertex pos="0.25 -1.5 -0.5" />
                            <Vertex pos="-0.25 1.5 0.5" />
                            <Vertex pos="-0.25 1.5 -0.5" />
                            <Vertex pos="-0.25 -1.5 0.5" />
                            <Vertex pos="-0.25 -1.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 1 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 -1 0 -640 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.125" texRot="0" texScale="0.0625 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="-29.5 44 2" rot="1 0 0 0" scale="" transform="1 0 0 -29.5 0 1 0 44 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 0.5" />
                            <Vertex pos="0.25 1.5 -0.5" />
                            <Vertex pos="0.25 -1.5 0.5" />
                            <Vertex pos="0.25 -1.5 -0.5" />
                            <Vertex pos="-0.25 1.5 0.5" />
                            <Vertex pos="-0.25 1.5 -0.5" />
                            <Vertex pos="-0.25 -1.5 0.5" />
                            <Vertex pos="-0.25 -1.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 1 0 640 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 -1 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.0625 0.125" texRot="0" texScale="0.0625 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -1 0 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="-29.625 39 2.625" rot="1 0 0 0" scale="" transform="1 0 0 -29.625 0 1 0 39 0 0 1 2.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.125 1.25 0.125002" />
                            <Vertex pos="0.125 -1.24999 0.125002" />
                            <Vertex pos="0.125 1.5 -0.125002" />
                            <Vertex pos="0.125 -1.5 -0.125002" />
                            <Vertex pos="-0.125002 1.5 -0.125002" />
                            <Vertex pos="-0.125002 -1.5 -0.125002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_grid_blank2" texgens="0 1 0 896 0 0 -1 224.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.70711 0 0.707104 -7.07805e-007" album="" material="bm_stripe_caution1" texgens="1 -1 0 1120 0 0 -1 32.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707112 0.707101 -0.97228" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 -1 128 0 0.0625 0.03125" texRot="0" texScale="0.0625 0.03125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.707098 0.707115 -0.972257" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -0.707107 -0.707107 -1599.7 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.125002" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="-29.375 39 2.625" rot="1 0 0 0" scale="" transform="1 0 0 -29.375 0 1 0 39 0 0 1 2.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.124998 1.25 0.124997" />
                            <Vertex pos="-0.124998 -1.25 0.124997" />
                            <Vertex pos="0.125 1.5 -0.124997" />
                            <Vertex pos="0.125 -1.5 -0.124997" />
                            <Vertex pos="-0.125 1.5 -0.124997" />
                            <Vertex pos="-0.125 -1.5 -0.124997" />
                        </Vertices>
                        <Face id="0" plane="0.707101 -0 0.707112 -7.07805e-007" album="" material="bm_stripe_caution1" texgens="1 1 0 864 0 0 -1 31.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 0 7.98721e-006 -0.124999" album="" material="bm_grid_blank2" texgens="0 -1 0 -640 0 0 -1 223.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707098 0.707115 -0.97226" album="" material="bm_grid_blank2" texgens="-1 0 0 64 0 0 -1 128 0 0.0625 0.03125" texRot="0" texScale="0.0625 0.03125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.707098 0.707115 -0.97226" album="" material="bm_grid_blank2" texgens="1 0 0 192 0 -0.707107 -0.707107 -1599.7 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.124997" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="-29.625 44 2.625" rot="1 0 0 0" scale="" transform="1 0 0 -29.625 0 1 0 44 0 0 1 2.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.125 1.5 0.125002" />
                            <Vertex pos="0.125 -1.25 0.125002" />
                            <Vertex pos="0.125 1.5 -0.125002" />
                            <Vertex pos="0.125 -1.5 -0.125002" />
                            <Vertex pos="-0.125002 1.5 -0.125002" />
                            <Vertex pos="-0.125002 -1.5 -0.125002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_grid_blank2" texgens="0 1 0 640 0 0 -1 224.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.70711 0 0.707104 -7.07805e-007" album="" material="bm_stripe_caution1" texgens="1 -1 0 1376 0 0 -1 32.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 -1 128 0 0.0625 0.03125" texRot="0" texScale="0.0625 0.03125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.707112 0.707101 -0.972279" album="" material="bm_grid_blank2" texgens="1 0 0 64 0 -0.707107 -0.707107 -1086.9 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.125002" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="-29.375 44 2.625" rot="1 0 0 0" scale="" transform="1 0 0 -29.375 0 1 0 44 0 0 1 2.625 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.125 1.5 0.124997" />
                            <Vertex pos="-0.124998 -1.25 0.124996" />
                            <Vertex pos="0.125 1.5 -0.124997" />
                            <Vertex pos="0.125 -1.5 -0.124997" />
                            <Vertex pos="-0.125 1.5 -0.124997" />
                            <Vertex pos="-0.125 -1.5 -0.124997" />
                        </Vertices>
                        <Face id="0" plane="0.7071 2.56705e-007 0.707114 -7.45058e-009" album="" material="bm_stripe_caution1" texgens="1 1 0 608 0 0 -1 31.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_grid_blank2" texgens="0 -1 0 -384 0 0 -1 223.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 0 -1.5" album="" material="bm_grid_blank2" texgens="-1 0 0 64 0 0 -1 128 0 0.0625 0.03125" texRot="0" texScale="0.0625 0.03125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="3" plane="0 -0.707097 0.707117 -0.972258" album="" material="bm_grid_blank2" texgens="1 0 0 192 0 -0.707107 -0.707107 -1086.9 0 0.0625 0.0441947" texRot="0" texScale="0.0625 0.0441947" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.124997" album="" material="bm_grid_blank2" texgens="-1 0 0 224 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="41.5 -0.5 -24.5" rot="1 0 0 0" scale="" transform="1 0 0 41.5 0 1 0 -0.5 0 0 1 -24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 86 8" />
                            <Vertex pos="1 86 -20" />
                            <Vertex pos="1 -86 8" />
                            <Vertex pos="1 -86 -20" />
                            <Vertex pos="-1 86 8" />
                            <Vertex pos="-1 86 -20" />
                            <Vertex pos="-1 -86 8" />
                            <Vertex pos="-1 -86 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -86" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -86" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="-26.5 -51.5 -24.5" rot="1 0 0 0" scale="" transform="1 0 0 -26.5 0 1 0 -51.5 0 0 1 -24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 35 8" />
                            <Vertex pos="1 35 -20" />
                            <Vertex pos="1 -35 8" />
                            <Vertex pos="1 -35 -20" />
                            <Vertex pos="-1 35 8" />
                            <Vertex pos="-1 35 -20" />
                            <Vertex pos="-1 -35 8" />
                            <Vertex pos="-1 -35 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -7296 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 7552 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -35" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -35" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 7552 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 7552 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="-27.5 84.5 -24.5" rot="1 0 0 0" scale="" transform="1 0 0 -27.5 0 1 0 84.5 0 0 1 -24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="68 1 8" />
                            <Vertex pos="68 1 -20" />
                            <Vertex pos="68 -1 8" />
                            <Vertex pos="68 -1 -20" />
                            <Vertex pos="-68 1 8" />
                            <Vertex pos="-68 1 -20" />
                            <Vertex pos="-68 -1 8" />
                            <Vertex pos="-68 -1 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -68" album="" material="bm_grid_blank4" texgens="0 1 0 10112 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -68" album="" material="bm_grid_blank4" texgens="0 -1 0 -9856 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -5376 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 5632 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 5632 0 -1 0 -9856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 -5376 0 -1 0 -9856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="225" owner="0" type="0" pos="7.5 -85.5 -24.5" rot="1 0 0 0" scale="" transform="1 0 0 7.5 0 1 0 -85.5 0 0 1 -24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="33 1 8" />
                            <Vertex pos="33 1 -20" />
                            <Vertex pos="33 -1 8" />
                            <Vertex pos="33 -1 -20" />
                            <Vertex pos="-33 1 8" />
                            <Vertex pos="-33 1 -20" />
                            <Vertex pos="-33 -1 8" />
                            <Vertex pos="-33 -1 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -33" album="" material="bm_grid_blank4" texgens="0 1 0 10112 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -33" album="" material="bm_grid_blank4" texgens="0 -1 0 -9856 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -9856 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 10112 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 10112 0 -1 0 -9856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 -9856 0 -1 0 -9856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="7.5 -0.5 -52.5" rot="1 0 0 0" scale="" transform="1 0 0 7.5 0 1 0 -0.5 0 0 1 -52.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="35 86 8" />
                            <Vertex pos="35 86 -8" />
                            <Vertex pos="35 -86 8" />
                            <Vertex pos="35 -86 -8" />
                            <Vertex pos="-35 86 8" />
                            <Vertex pos="-35 86 -8" />
                            <Vertex pos="-35 -86 8" />
                            <Vertex pos="-35 -86 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -35" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -35" album="" material="bm_grid_blank4" texgens="0 -1 0 1024 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -86" album="" material="bm_grid_blank4" texgens="-1 0 0 4736 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -86" album="" material="bm_grid_blank4" texgens="1 0 0 -4480 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank_water" texgens="1 0 0 -4480 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 4736 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="-62.5 33.5 -52.5" rot="1 0 0 0" scale="" transform="1 0 0 -62.5 0 1 0 33.5 0 0 1 -52.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="35 52 8" />
                            <Vertex pos="35 52 -8" />
                            <Vertex pos="35 -52 8" />
                            <Vertex pos="35 -52 -8" />
                            <Vertex pos="-35 52 8" />
                            <Vertex pos="-35 52 -8" />
                            <Vertex pos="-35 -52 8" />
                            <Vertex pos="-35 -52 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -35" album="" material="bm_grid_blank4" texgens="0 1 0 3584 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -35" album="" material="bm_grid_blank4" texgens="0 -1 0 -3328 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 4736 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -52" album="" material="bm_grid_blank4" texgens="1 0 0 -4480 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank_water" texgens="1 0 0 -4480 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 4736 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="-61.5 -17.5 -24.5" rot="1 0 0 0" scale="" transform="1 0 0 -61.5 0 1 0 -17.5 0 0 1 -24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="34 1 8" />
                            <Vertex pos="34 1 -20" />
                            <Vertex pos="34 -1 8" />
                            <Vertex pos="34 -1 -20" />
                            <Vertex pos="-34 1 8" />
                            <Vertex pos="-34 1 -20" />
                            <Vertex pos="-34 -1 8" />
                            <Vertex pos="-34 -1 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -34" album="" material="bm_grid_blank4" texgens="0 1 0 10112 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -34" album="" material="bm_grid_blank4" texgens="0 -1 0 -9856 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -9728 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 9984 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 9984 0 -1 0 -9856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 -9728 0 -1 0 -9856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="-96.5 33.5 -24.5" rot="1 0 0 0" scale="" transform="1 0 0 -96.5 0 1 0 33.5 0 0 1 -24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 52 8" />
                            <Vertex pos="1 52 -20" />
                            <Vertex pos="1 -52 8" />
                            <Vertex pos="1 -52 -20" />
                            <Vertex pos="-1 52 8" />
                            <Vertex pos="-1 52 -20" />
                            <Vertex pos="-1 -52 8" />
                            <Vertex pos="-1 -52 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -5120 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 5376 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -52" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -52" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 5376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 5376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="-7.5 7.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 7.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile09_A" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="9" type="999" pos="-7.5 7.5 4.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 7.5 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="35" nextVertexID="65">
                        <Vertices>
                            <Vertex pos="2.94238 0.585281 -4" />
                            <Vertex pos="2.94238 0.585281 4" />
                            <Vertex pos="3 -2.86102e-006 -4" />
                            <Vertex pos="3 -2.86102e-006 4" />
                            <Vertex pos="2.77163 1.14806 -4" />
                            <Vertex pos="2.77163 1.14806 4" />
                            <Vertex pos="2.49441 1.66672 -4" />
                            <Vertex pos="2.49441 1.66672 4" />
                            <Vertex pos="2.12132 2.12131 -4" />
                            <Vertex pos="2.12132 2.12131 4" />
                            <Vertex pos="1.66671 2.49441 -4" />
                            <Vertex pos="1.66671 2.49441 4" />
                            <Vertex pos="1.14804 2.77165 -4" />
                            <Vertex pos="1.14804 2.77165 4" />
                            <Vertex pos="0.585247 2.94238 -4" />
                            <Vertex pos="0.585247 2.94238 4" />
                            <Vertex pos="-1.90735e-006 3 -4" />
                            <Vertex pos="-1.90735e-006 3 4" />
                            <Vertex pos="-0.585273 2.94234 -4" />
                            <Vertex pos="-0.585273 2.94234 4" />
                            <Vertex pos="-1.14806 2.77162 -4" />
                            <Vertex pos="-1.14806 2.77162 4" />
                            <Vertex pos="-1.66672 2.49441 -4" />
                            <Vertex pos="-1.66672 2.49441 4" />
                            <Vertex pos="-2.12131 2.12134 -4" />
                            <Vertex pos="-2.12131 2.12134 4" />
                            <Vertex pos="-2.49441 1.66671 -4" />
                            <Vertex pos="-2.49441 1.66671 4" />
                            <Vertex pos="-2.77162 1.14806 -4" />
                            <Vertex pos="-2.77162 1.14806 4" />
                            <Vertex pos="-2.94235 0.585273 -4" />
                            <Vertex pos="-2.94235 0.585273 4" />
                            <Vertex pos="-3 -4.76837e-007 -4" />
                            <Vertex pos="-3 -4.76837e-007 4" />
                            <Vertex pos="-2.94238 -0.585276 -4" />
                            <Vertex pos="-2.94238 -0.585276 4" />
                            <Vertex pos="-2.77165 -1.14807 -4" />
                            <Vertex pos="-2.77165 -1.14807 4" />
                            <Vertex pos="-2.49441 -1.66672 -4" />
                            <Vertex pos="-2.49441 -1.66672 4" />
                            <Vertex pos="-2.12131 -2.12132 -4" />
                            <Vertex pos="-2.12131 -2.12132 4" />
                            <Vertex pos="-1.66672 -2.49441 -4" />
                            <Vertex pos="-1.66672 -2.49441 4" />
                            <Vertex pos="-1.14806 -2.77163 -4" />
                            <Vertex pos="-1.14806 -2.77163 4" />
                            <Vertex pos="-0.585283 -2.94238 -4" />
                            <Vertex pos="-0.585283 -2.94238 4" />
                            <Vertex pos="0 -3 -4" />
                            <Vertex pos="0 -3 4" />
                            <Vertex pos="0.585285 -2.94238 -4" />
                            <Vertex pos="0.585285 -2.94238 4" />
                            <Vertex pos="1.14806 -2.77163 -4" />
                            <Vertex pos="1.14806 -2.77163 4" />
                            <Vertex pos="1.66672 -2.49441 -4" />
                            <Vertex pos="1.66672 -2.49441 4" />
                            <Vertex pos="2.12135 -2.12131 -4" />
                            <Vertex pos="2.12135 -2.12131 4" />
                            <Vertex pos="2.49441 -1.66668 -4" />
                            <Vertex pos="2.49441 -1.66668 4" />
                            <Vertex pos="2.77166 -1.14804 -4" />
                            <Vertex pos="2.77166 -1.14804 4" />
                            <Vertex pos="2.94238 -0.585253 -4" />
                            <Vertex pos="2.94238 -0.585253 4" />
                        </Vertices>
                        <Face id="0" plane="0.995189 0.0979744 0 -2.98557" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.999 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.956925 0.290336 -0 -2.98556" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.999 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.881928 0.471384 -0 -2.98556" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.999 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.772996 0.634411 -0 -2.98555" album="" material="bm_grid_blank4" texgens="-0.382684 0.92388 0 127.999 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="0.634405 0.773001 -0 -2.98555" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 127.999 0 0 -1 -256 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="0.471404 0.881918 -0 -2.98556" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 127.999 0 0 -1 -256 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.290298 0.956936 -0 -2.98557" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 127.999 0 0 -1 -256 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.0979802 0.995188 -0 -2.98556" album="" material="bm_grid_blank4" texgens="-0.92388 0.382682 0 127.999 0 0 -1 -256 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.098044 0.995182 0 -2.98555" album="" material="bm_grid_blank4" texgens="-0.923879 -0.382684 0 128 0 0 -1 -256 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.290285 0.95694 0 -2.98554" album="" material="bm_grid_blank4" texgens="-0.923879 -0.382684 0 128 0 0 -1 -256 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.471371 0.881935 0 -2.98555" album="" material="bm_grid_blank4" texgens="-0.923879 -0.382684 0 128 0 0 -1 -256 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.634391 0.773012 0 -2.98556" album="" material="bm_grid_blank4" texgens="-0.923879 -0.382684 0 128 0 0 -1 -256 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="-0.773015 0.634388 0 -2.98556" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="-0.881931 0.471378 0 -2.98555" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="-0.956935 0.290301 0 -2.98554" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="-0.995184 0.0980267 0 -2.98555" album="" material="bm_grid_blank4" texgens="-0.382687 -0.923878 0 128 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="16" plane="-0.995189 -0.0979758 0 -2.98557" album="" material="bm_grid_blank4" texgens="0.382683 -0.92388 0 128.003 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="17" plane="-0.956936 -0.290297 0 -2.98557" album="" material="bm_grid_blank4" texgens="0.382683 -0.92388 0 128.003 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="18" plane="-0.88191 -0.471418 0 -2.98557" album="" material="bm_grid_blank4" texgens="0.382683 -0.92388 0 128.003 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="19" plane="-0.772994 -0.634413 0 -2.98555" album="" material="bm_grid_blank4" texgens="0.382683 -0.92388 0 128.003 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="20" plane="-0.634411 -0.772996 0 -2.98555" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="21" plane="-0.471384 -0.881928 0 -2.98556" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="22" plane="-0.290337 -0.956925 0 -2.98556" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="23" plane="-0.0979745 -0.995189 0 -2.98557" album="" material="bm_grid_blank4" texgens="0.92388 -0.382683 0 128.003 0 0 -1 -256 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 49 48 46 47" />
                        </Face>
                        <Face id="24" plane="0.0979742 -0.995189 0 -2.98557" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.001 0 0 -1 -256 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 51 50 48 49" />
                        </Face>
                        <Face id="25" plane="0.290338 -0.956924 0 -2.98556" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.001 0 0 -1 -256 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 53 52 50 51" />
                        </Face>
                        <Face id="26" plane="0.471384 -0.881928 0 -2.98556" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.001 0 0 -1 -256 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 55 54 52 53" />
                        </Face>
                        <Face id="27" plane="0.634388 -0.773015 0 -2.98556" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.001 0 0 -1 -256 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 57 56 54 55" />
                        </Face>
                        <Face id="28" plane="0.773048 -0.634347 0 -2.98555" album="" material="bm_grid_blank4" texgens="0.382681 0.923881 0 128 0 0 -1 -256 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 59 58 56 57" />
                        </Face>
                        <Face id="29" plane="0.881899 -0.471438 0 -2.98555" album="" material="bm_grid_blank4" texgens="0.382681 0.923881 0 128 0 0 -1 -256 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 61 60 58 59" />
                        </Face>
                        <Face id="30" plane="0.95694 -0.290285 0 -2.98557" album="" material="bm_grid_blank4" texgens="0.382681 0.923881 0 128 0 0 -1 -256 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 63 62 60 61" />
                        </Face>
                        <Face id="31" plane="0.995188 -0.09798 0 -2.98557" album="" material="bm_grid_blank4" texgens="0.382681 0.923881 0 128 0 0 -1 -256 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 63 3 2 62" />
                        </Face>
                        <Face id="32" plane="-0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 0.500015 0 -1 0 0.499969 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 62 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60" />
                        </Face>
                        <Face id="33" plane="0 -0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 63 61 59 57 55 53 51 49 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="233" owner="0" type="0" pos="-7.5 7.5 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 7.5 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.447214 -0 0.894427 -0.67082" album="" material="bm_friction_sand" texgens="0 1 0 1920 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.447214 0 0.894427 -0.67082" album="" material="bm_friction_sand" texgens="0 -1 0 -1920 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.447214 0.894427 -0.67082" album="" material="bm_friction_sand" texgens="-1 0 0 1920 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.447214 0.894427 -0.67082" album="" material="bm_friction_sand" texgens="1 0 0 -1920 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="13" type="999" pos="-7.5 7.5 4.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 7.5 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 4" />
                            <Vertex pos="2 2 -4" />
                            <Vertex pos="2 -2 4" />
                            <Vertex pos="2 -2 -4" />
                            <Vertex pos="-2 2 4" />
                            <Vertex pos="-2 2 -4" />
                            <Vertex pos="-2 -2 4" />
                            <Vertex pos="-2 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="17" type="999" pos="-7.5 7.5 2" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 7.5 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="236" owner="0" type="0" pos="16.5 -60.5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 16.5 0 1 0 -60.5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 9.53674e-007" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="16.5 -60.5 7.5" rot="1 0 0 0" scale="" transform="1 0 0 16.5 0 1 0 -60.5 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_friction_sand" texgens="-1 0 0 -2112 0 0 -1 -960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="16.5 -60.5 10" rot="1 0 0 0" scale="" transform="1 0 0 16.5 0 1 0 -60.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="5" type="999" pos="-7.5 7.5 1" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 7.5 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="89" nextVertexID="65">
                        <Vertices>
                            <Vertex pos="3.92314 0.78037 -0.5" />
                            <Vertex pos="3.92314 0.78037 7.5" />
                            <Vertex pos="4 -4.38788e-006 -0.5" />
                            <Vertex pos="4 -4.29153e-006 7.5" />
                            <Vertex pos="3.69552 1.53073 -0.5" />
                            <Vertex pos="3.69552 1.53073 7.5" />
                            <Vertex pos="3.32588 2.22228 -0.5" />
                            <Vertex pos="3.32588 2.22228 7.5" />
                            <Vertex pos="2.82843 2.82843 -0.5" />
                            <Vertex pos="2.82843 2.82843 7.5" />
                            <Vertex pos="2.22228 3.32588 -0.5" />
                            <Vertex pos="2.22228 3.32588 7.5" />
                            <Vertex pos="1.53072 3.69552 -0.5" />
                            <Vertex pos="1.53072 3.69552 7.5" />
                            <Vertex pos="0.780354 3.92314 -0.5" />
                            <Vertex pos="0.780354 3.92314 7.5" />
                            <Vertex pos="-1.45943e-005 4 -0.5" />
                            <Vertex pos="-1.4782e-005 4 7.5" />
                            <Vertex pos="-0.780383 3.92314 -0.5" />
                            <Vertex pos="-0.780383 3.92314 7.5" />
                            <Vertex pos="-1.53075 3.69551 -0.5" />
                            <Vertex pos="-1.53075 3.69551 7.5" />
                            <Vertex pos="-2.22226 3.32589 -0.5" />
                            <Vertex pos="-2.22226 3.32589 7.5" />
                            <Vertex pos="-2.82841 2.82844 -0.5" />
                            <Vertex pos="-2.82841 2.82844 7.5" />
                            <Vertex pos="-3.32587 2.22229 -0.5" />
                            <Vertex pos="-3.32587 2.22229 7.5" />
                            <Vertex pos="-3.69551 1.53075 -0.5" />
                            <Vertex pos="-3.69551 1.53075 7.5" />
                            <Vertex pos="-3.92314 0.780378 -0.5" />
                            <Vertex pos="-3.92314 0.780379 7.5" />
                            <Vertex pos="-4 5.34161e-006 -0.5" />
                            <Vertex pos="-4 5.24521e-006 7.5" />
                            <Vertex pos="-3.92314 -0.780351 -0.5" />
                            <Vertex pos="-3.92314 -0.780351 7.5" />
                            <Vertex pos="-3.69552 -1.53073 -0.5" />
                            <Vertex pos="-3.69552 -1.53073 7.5" />
                            <Vertex pos="-3.32588 -2.22228 -0.5" />
                            <Vertex pos="-3.32588 -2.22228 7.5" />
                            <Vertex pos="-2.82843 -2.82842 -0.5" />
                            <Vertex pos="-2.82843 -2.82842 7.5" />
                            <Vertex pos="-2.22228 -3.32588 -0.5" />
                            <Vertex pos="-2.22228 -3.32588 7.5" />
                            <Vertex pos="-1.53073 -3.69552 -0.5" />
                            <Vertex pos="-1.53073 -3.69552 7.5" />
                            <Vertex pos="-0.780363 -3.92314 -0.5" />
                            <Vertex pos="-0.780363 -3.92314 7.5" />
                            <Vertex pos="4.86478e-006 -4 -0.5" />
                            <Vertex pos="4.76837e-006 -4 7.5" />
                            <Vertex pos="0.780366 -3.92314 -0.5" />
                            <Vertex pos="0.780366 -3.92314 7.5" />
                            <Vertex pos="1.53074 -3.69551 -0.5" />
                            <Vertex pos="1.53074 -3.69551 7.5" />
                            <Vertex pos="2.22229 -3.32587 -0.5" />
                            <Vertex pos="2.22229 -3.32587 7.5" />
                            <Vertex pos="2.82843 -2.82842 -0.5" />
                            <Vertex pos="2.82843 -2.82842 7.5" />
                            <Vertex pos="3.32589 -2.22227 -0.5" />
                            <Vertex pos="3.32589 -2.22227 7.5" />
                            <Vertex pos="3.69552 -1.53072 -0.5" />
                            <Vertex pos="3.69552 -1.53072 7.5" />
                            <Vertex pos="3.92314 -0.780342 -0.5" />
                            <Vertex pos="3.92314 -0.780342 7.5" />
                        </Vertices>
                        <Face id="54" plane="0.995185 0.0980169 0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.382682 0.92388 0 128 0 0 -1 192 0 0.382684 0.25" texRot="0" texScale="0.382684 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="55" plane="0.95694 0.290286 -0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.382682 0.92388 0 128 0 0 -1 192 0 0.382684 0.25" texRot="0" texScale="0.382684 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="56" plane="0.881922 0.471395 -0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.382682 0.92388 0 128 0 0 -1 192 0 0.382684 0.25" texRot="0" texScale="0.382684 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="57" plane="0.773013 0.63439 -0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.382682 0.92388 0 128 0 0 -1 192 0 0.382684 0.25" texRot="0" texScale="0.382684 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="58" plane="0.63439 0.773013 -0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.923881 0.38268 0 128.001 0 0 -1 192 0 0.382685 0.25" texRot="0" texScale="0.382685 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="59" plane="0.47139 0.881925 -0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.923881 0.38268 0 128.001 0 0 -1 192 0 0.382685 0.25" texRot="0" texScale="0.382685 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="60" plane="0.290284 0.956941 -0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.923881 0.38268 0 128.001 0 0 -1 192 0 0.382685 0.25" texRot="0" texScale="0.382685 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="61" plane="0.0980176 0.995185 2.29973e-009 -3.98074" album="" material="bm_grid_blank4" texgens="-0.923881 0.38268 0 128.001 0 0 -1 192 0 0.382685 0.25" texRot="0" texScale="0.382685 0.25" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="62" plane="-0.0980176 0.995185 0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.923879 -0.382685 0 128.001 0 0 -1 192 0 0.382679 0.25" texRot="0" texScale="0.382679 0.25" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="63" plane="-0.290295 0.956937 0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.923879 -0.382685 0 128.001 0 0 -1 192 0 0.382679 0.25" texRot="0" texScale="0.382679 0.25" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="64" plane="-0.471397 0.881921 0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.923879 -0.382685 0 128.001 0 0 -1 192 0 0.382679 0.25" texRot="0" texScale="0.382679 0.25" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="65" plane="-0.63439 0.773013 0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.923879 -0.382685 0 128.001 0 0 -1 192 0 0.382679 0.25" texRot="0" texScale="0.382679 0.25" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="66" plane="-0.773007 0.634398 0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.382688 -0.923878 0 128 0 0 -1 192 0 0.382686 0.25" texRot="0" texScale="0.382686 0.25" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="67" plane="-0.881919 0.471401 0 -3.98074" album="" material="bm_grid_blank4" texgens="-0.382688 -0.923878 0 128 0 0 -1 192 0 0.382686 0.25" texRot="0" texScale="0.382686 0.25" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="68" plane="-0.956938 0.290293 -3.67685e-008 -3.98074" album="" material="bm_grid_blank4" texgens="-0.382688 -0.923878 0 128 0 0 -1 192 0 0.382686 0.25" texRot="0" texScale="0.382686 0.25" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="69" plane="-0.995185 0.0980171 1.18111e-009 -3.98074" album="" material="bm_grid_blank4" texgens="-0.382688 -0.923878 0 128 0 0 -1 192 0 0.382686 0.25" texRot="0" texScale="0.382686 0.25" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="70" plane="-0.995184 -0.0980191 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.382683 -0.92388 0 128 0 0 -1 192 0 0.382683 0.25" texRot="0" texScale="0.382683 0.25" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="71" plane="-0.956942 -0.290279 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.382683 -0.92388 0 128 0 0 -1 192 0 0.382683 0.25" texRot="0" texScale="0.382683 0.25" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="72" plane="-0.881922 -0.471395 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.382683 -0.92388 0 128 0 0 -1 192 0 0.382683 0.25" texRot="0" texScale="0.382683 0.25" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="73" plane="-0.773008 -0.634396 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.382683 -0.92388 0 128 0 0 -1 192 0 0.382683 0.25" texRot="0" texScale="0.382683 0.25" texDiv="256 256">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="74" plane="-0.634398 -0.773007 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.923879 -0.382684 0 128 0 0 -1 192 0 0.382685 0.25" texRot="0" texScale="0.382685 0.25" texDiv="256 256">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="75" plane="-0.471395 -0.881922 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.923879 -0.382684 0 128 0 0 -1 192 0 0.382685 0.25" texRot="0" texScale="0.382685 0.25" texDiv="256 256">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="76" plane="-0.290283 -0.956941 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.923879 -0.382684 0 128 0 0 -1 192 0 0.382685 0.25" texRot="0" texScale="0.382685 0.25" texDiv="256 256">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="77" plane="-0.0980177 -0.995185 -1.18123e-009 -3.98074" album="" material="bm_grid_blank4" texgens="0.923879 -0.382684 0 128 0 0 -1 192 0 0.382685 0.25" texRot="0" texScale="0.382685 0.25" texDiv="256 256">
                            <Indices indices=" 49 48 46 47" />
                        </Face>
                        <Face id="78" plane="0.0980185 -0.995185 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.001 0 0 -1 192 0 0.382684 0.25" texRot="0" texScale="0.382684 0.25" texDiv="256 256">
                            <Indices indices=" 51 50 48 49" />
                        </Face>
                        <Face id="79" plane="0.290292 -0.956938 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.001 0 0 -1 192 0 0.382684 0.25" texRot="0" texScale="0.382684 0.25" texDiv="256 256">
                            <Indices indices=" 53 52 50 51" />
                        </Face>
                        <Face id="80" plane="0.471395 -0.881922 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.001 0 0 -1 192 0 0.382684 0.25" texRot="0" texScale="0.382684 0.25" texDiv="256 256">
                            <Indices indices=" 55 54 52 53" />
                        </Face>
                        <Face id="81" plane="0.634396 -0.773008 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.923878 0.382686 0 128.001 0 0 -1 192 0 0.382684 0.25" texRot="0" texScale="0.382684 0.25" texDiv="256 256">
                            <Indices indices=" 57 56 54 55" />
                        </Face>
                        <Face id="82" plane="0.773007 -0.634398 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.382681 0.923881 0 128.001 0 0 -1 192 0 0.382682 0.25" texRot="0" texScale="0.382682 0.25" texDiv="256 256">
                            <Indices indices=" 59 58 56 57" />
                        </Face>
                        <Face id="83" plane="0.881927 -0.471385 0 -3.98074" album="" material="bm_grid_blank4" texgens="0.382681 0.923881 0 128.001 0 0 -1 192 0 0.382682 0.25" texRot="0" texScale="0.382682 0.25" texDiv="256 256">
                            <Indices indices=" 61 60 58 59" />
                        </Face>
                        <Face id="84" plane="0.956942 -0.290279 0 -3.98073" album="" material="bm_grid_blank4" texgens="0.382681 0.923881 0 128.001 0 0 -1 192 0 0.382682 0.25" texRot="0" texScale="0.382682 0.25" texDiv="256 256">
                            <Indices indices=" 63 62 60 61" />
                        </Face>
                        <Face id="85" plane="0.995184 -0.0980214 1.18055e-009 -3.98074" album="" material="bm_grid_blank4" texgens="0.382681 0.923881 0 128.001 0 0 -1 192 0 0.382682 0.25" texRot="0" texScale="0.382682 0.25" texDiv="256 256">
                            <Indices indices=" 63 3 2 62" />
                        </Face>
                        <Face id="86" plane="-0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 62 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60" />
                        </Face>
                        <Face id="87" plane="0 -0 1 -7.5" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 63 61 59 57 55 53 51 49 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="1" type="999" pos="-15.5 39.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.5 0 1 0 39.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 2" />
                            <Vertex pos="2 6 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 2.38419e-007" />
                            <Vertex pos="-2 6 2" />
                            <Vertex pos="-2 6 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="8" type="4" pos="0 0 -4" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 2 0.5" />
                            <Vertex pos="-1 2 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 1 0.5" />
                            <Vertex pos="-2 1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile11_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="12" type="4" pos="-15 0 -4" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 0 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 1 0.5" />
                            <Vertex pos="2 1 -0.5" />
                            <Vertex pos="1 2 0.5" />
                            <Vertex pos="1 2 -0.5" />
                            <Vertex pos="1 1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile11_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="16" type="4" pos="-15 15 -4" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 15 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -1 0.5" />
                            <Vertex pos="2 -1 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -2 0.5" />
                            <Vertex pos="1 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile11_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="20" type="4" pos="0 15 -4" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 15 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -2 0.5" />
                            <Vertex pos="-1 -2 -0.5" />
                            <Vertex pos="-2 -1 0.5" />
                            <Vertex pos="-2 -1 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile11_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="245" owner="0" type="0" pos="14.5 23.5 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 23.5 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692804 0.286877 -44" />
                            <Vertex pos="0.692804 0.286877 13" />
                            <Vertex pos="0.749999 -3.8147e-006 -44" />
                            <Vertex pos="0.749999 -3.8147e-006 13" />
                            <Vertex pos="0.530323 0.530304 -44" />
                            <Vertex pos="0.530323 0.530304 13" />
                            <Vertex pos="0.286868 0.692816 -44" />
                            <Vertex pos="0.286868 0.692816 13" />
                            <Vertex pos="5.72205e-006 0.75 -44" />
                            <Vertex pos="5.72205e-006 0.75 13" />
                            <Vertex pos="-0.287184 0.69278 -44" />
                            <Vertex pos="-0.287184 0.69278 13" />
                            <Vertex pos="-0.530328 0.530302 -44" />
                            <Vertex pos="-0.530328 0.530302 13" />
                            <Vertex pos="-0.692819 0.286882 -44" />
                            <Vertex pos="-0.69282 0.286882 13" />
                            <Vertex pos="-0.749999 3.05176e-005 -44" />
                            <Vertex pos="-0.749999 3.05176e-005 13" />
                            <Vertex pos="-0.692803 -0.286903 -44" />
                            <Vertex pos="-0.692802 -0.286903 13" />
                            <Vertex pos="-0.530314 -0.530285 -44" />
                            <Vertex pos="-0.530313 -0.530285 13" />
                            <Vertex pos="-0.286868 -0.692812 -44" />
                            <Vertex pos="-0.286868 -0.692812 13" />
                            <Vertex pos="-5.72205e-006 -0.75 -44" />
                            <Vertex pos="-5.72205e-006 -0.75 13" />
                            <Vertex pos="0.286881 -0.692812 -44" />
                            <Vertex pos="0.286881 -0.692812 13" />
                            <Vertex pos="0.530292 -0.530317 -44" />
                            <Vertex pos="0.530292 -0.530317 13" />
                            <Vertex pos="0.692832 -0.286842 -44" />
                            <Vertex pos="0.692832 -0.286842 13" />
                        </Vertices>
                        <Face id="0" plane="0.9807 0.195521 0 -0.735523" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6839 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831741 0.555164 -0 -0.735497" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0433 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555194 0.831721 -0 -0.735497" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4094 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195497 0.980704 -0 -0.735529" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7791 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.1954 0.980724 0 -0.735542" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1399 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555604 0.831447 0 -0.73557" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5063 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831717 0.555199 -1.47853e-008 -0.735507" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8666 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980706 0.19549 0 -0.735534" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2358 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980706 -0.195489 1.74338e-008 -0.735522" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.596 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831681 -0.555254 1.47846e-008 -0.735494" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9573 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555243 -0.831688 0 -0.735485" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3257 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.19551 -0.980702 0 -0.735527" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.691 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195494 -0.980705 0 -0.735528" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.051 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555223 -0.831702 0 -0.735496" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.42 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831698 -0.555228 0 -0.73549" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980712 -0.195456 0 -0.735534" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -44" album="" material="solid_bm" texgens="-1 0 0 0.499895 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -13" album="" material="solid_bm" texgens="1 0 0 0.500105 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="246" owner="0" type="0" pos="4.5 -42.5 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 4.5 0 1 0 -42.5 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692804 0.286877 -44" />
                            <Vertex pos="0.692804 0.286877 35" />
                            <Vertex pos="0.749999 -3.8147e-006 -44" />
                            <Vertex pos="0.749999 -3.8147e-006 35" />
                            <Vertex pos="0.530323 0.530304 -44" />
                            <Vertex pos="0.530323 0.530304 35" />
                            <Vertex pos="0.286868 0.692818 -44" />
                            <Vertex pos="0.286868 0.692818 35" />
                            <Vertex pos="5.24521e-006 0.75 -44" />
                            <Vertex pos="5.72205e-006 0.75 35" />
                            <Vertex pos="-0.287184 0.69278 -44" />
                            <Vertex pos="-0.287184 0.69278 35" />
                            <Vertex pos="-0.530328 0.5303 -44" />
                            <Vertex pos="-0.530328 0.530304 35" />
                            <Vertex pos="-0.692819 0.28688 -44" />
                            <Vertex pos="-0.69282 0.28688 35" />
                            <Vertex pos="-0.749999 3.05176e-005 -44" />
                            <Vertex pos="-0.749999 3.05176e-005 35" />
                            <Vertex pos="-0.692803 -0.286903 -44" />
                            <Vertex pos="-0.692802 -0.286903 35" />
                            <Vertex pos="-0.530314 -0.530285 -44" />
                            <Vertex pos="-0.530313 -0.530285 35" />
                            <Vertex pos="-0.286868 -0.692814 -44" />
                            <Vertex pos="-0.286868 -0.69281 35" />
                            <Vertex pos="-5.72205e-006 -0.75 -44" />
                            <Vertex pos="-5.72205e-006 -0.75 35" />
                            <Vertex pos="0.286881 -0.692814 -44" />
                            <Vertex pos="0.286881 -0.69281 35" />
                            <Vertex pos="0.530292 -0.530315 -44" />
                            <Vertex pos="0.530292 -0.530319 35" />
                            <Vertex pos="0.692832 -0.286842 -44" />
                            <Vertex pos="0.692832 -0.286842 35" />
                        </Vertices>
                        <Face id="0" plane="0.9807 0.195521 0 -0.735523" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6839 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831741 0.555164 -0 -0.735497" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0433 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555198 0.831718 -0 -0.735498" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4094 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.19549 0.980706 -1.17997e-009 -0.73553" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7791 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195401 0.980723 0 -0.735542" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1399 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555609 0.831444 -4.20301e-008 -0.735571" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5063 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831717 0.555199 -1.06679e-008 -0.735506" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8666 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980705 0.195492 0 -0.735534" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2358 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980706 -0.195489 1.25788e-008 -0.735522" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.596 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831681 -0.555254 1.06674e-008 -0.735494" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9573 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555248 -0.831685 4.20423e-008 -0.735484" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3257 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195503 -0.980703 0 -0.735528" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.691 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195487 -0.980706 4.95755e-008 -0.735526" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.051 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555232 -0.831695 -4.20428e-008 -0.735498" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.42 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831696 -0.555231 0 -0.735489" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980712 -0.195456 0 -0.735534" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -44" album="" material="solid_bm" texgens="-1 0 0 0.499895 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -35" album="" material="solid_bm" texgens="1 0 0 0.500105 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="-31.5 75.5 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -31.5 0 1 0 75.5 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692804 0.28688 -44" />
                            <Vertex pos="0.692804 0.28688 45" />
                            <Vertex pos="0.749998 -7.62939e-006 -44" />
                            <Vertex pos="0.75 0 45" />
                            <Vertex pos="0.530323 0.530304 -44" />
                            <Vertex pos="0.530323 0.530304 45" />
                            <Vertex pos="0.286867 0.692818 -44" />
                            <Vertex pos="0.286869 0.692818 45" />
                            <Vertex pos="5.72205e-006 0.75 -44" />
                            <Vertex pos="5.72205e-006 0.75 45" />
                            <Vertex pos="-0.287184 0.69278 -44" />
                            <Vertex pos="-0.287184 0.69278 45" />
                            <Vertex pos="-0.530327 0.530304 -44" />
                            <Vertex pos="-0.530327 0.530304 45" />
                            <Vertex pos="-0.692818 0.28688 -44" />
                            <Vertex pos="-0.692822 0.28688 45" />
                            <Vertex pos="-0.75 3.05176e-005 -44" />
                            <Vertex pos="-0.75 3.05176e-005 45" />
                            <Vertex pos="-0.692802 -0.286903 -44" />
                            <Vertex pos="-0.692802 -0.286903 45" />
                            <Vertex pos="-0.530315 -0.530289 -44" />
                            <Vertex pos="-0.530315 -0.530289 45" />
                            <Vertex pos="-0.286867 -0.69281 -44" />
                            <Vertex pos="-0.286869 -0.69281 45" />
                            <Vertex pos="-5.72205e-006 -0.75 -44" />
                            <Vertex pos="-5.72205e-006 -0.75 45" />
                            <Vertex pos="0.28688 -0.69281 -44" />
                            <Vertex pos="0.28688 -0.69281 45" />
                            <Vertex pos="0.530293 -0.530319 -44" />
                            <Vertex pos="0.530293 -0.530319 45" />
                            <Vertex pos="0.692833 -0.286842 -44" />
                            <Vertex pos="0.692833 -0.286842 45" />
                        </Vertices>
                        <Face id="0" plane="0.980699 0.195525 0 -0.735524" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6839 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831737 0.555169 -0 -0.735498" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0433 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555197 0.831719 -1.24561e-008 -0.735498" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4094 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195491 0.980706 -0 -0.73553" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7791 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.1954 0.980724 0 -0.735542" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1399 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555601 0.831449 0 -0.735571" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5063 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831722 0.555193 -3.73201e-008 -0.735507" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8666 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980704 0.195498 0 -0.735534" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2358 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980704 -0.195496 0 -0.735522" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.596 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831688 -0.555243 0 -0.735496" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9573 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555226 -0.831699 -1.24567e-008 -0.735486" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3257 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195517 -0.9807 0 -0.735526" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.691 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195501 -0.980704 0 -0.735527" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.051 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.55521 -0.83171 0 -0.735496" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.42 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.8317 -0.555225 0 -0.735491" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980713 -0.195454 -5.57614e-009 -0.735534" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -44" album="" material="solid_bm" texgens="-1 0 0 0.499895 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -45" album="" material="solid_bm" texgens="1 0 0 0.500105 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="248" owner="0" type="0" pos="-55.5 35.5 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -55.5 0 1 0 35.5 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692802 0.286877 -44" />
                            <Vertex pos="0.692806 0.286877 23" />
                            <Vertex pos="0.75 -3.8147e-006 -44" />
                            <Vertex pos="0.75 -3.8147e-006 23" />
                            <Vertex pos="0.530323 0.530304 -44" />
                            <Vertex pos="0.530323 0.530304 23" />
                            <Vertex pos="0.286869 0.692818 -44" />
                            <Vertex pos="0.286869 0.692818 23" />
                            <Vertex pos="3.8147e-006 0.75 -44" />
                            <Vertex pos="3.8147e-006 0.75 23" />
                            <Vertex pos="-0.287186 0.69278 -44" />
                            <Vertex pos="-0.287182 0.69278 23" />
                            <Vertex pos="-0.530327 0.5303 -44" />
                            <Vertex pos="-0.530327 0.530304 23" />
                            <Vertex pos="-0.692818 0.28688 -44" />
                            <Vertex pos="-0.692822 0.28688 23" />
                            <Vertex pos="-0.75 3.05176e-005 -44" />
                            <Vertex pos="-0.75 3.05176e-005 23" />
                            <Vertex pos="-0.692802 -0.286903 -44" />
                            <Vertex pos="-0.692802 -0.286903 23" />
                            <Vertex pos="-0.530315 -0.530285 -44" />
                            <Vertex pos="-0.530315 -0.530285 23" />
                            <Vertex pos="-0.286869 -0.692814 -44" />
                            <Vertex pos="-0.286869 -0.69281 23" />
                            <Vertex pos="-7.62939e-006 -0.75 -44" />
                            <Vertex pos="-3.8147e-006 -0.75 23" />
                            <Vertex pos="0.28688 -0.692814 -44" />
                            <Vertex pos="0.28688 -0.69281 23" />
                            <Vertex pos="0.530293 -0.530315 -44" />
                            <Vertex pos="0.530293 -0.530319 23" />
                            <Vertex pos="0.692833 -0.286842 -44" />
                            <Vertex pos="0.692833 -0.286842 23" />
                        </Vertices>
                        <Face id="0" plane="0.9807 0.195517 -5.84543e-008 -0.735523" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6839 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831744 0.55516 -0 -0.735496" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0433 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.5552 0.831717 -0 -0.735498" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4094 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195488 0.980706 -0 -0.73553" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7791 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.1954 0.980724 1.16468e-008 -0.735541" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1399 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555614 0.831441 -4.95577e-008 -0.735572" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5063 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831717 0.555199 -4.95742e-008 -0.735507" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8666 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980704 0.195498 0 -0.735534" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2358 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980705 -0.195496 0 -0.735522" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.596 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831684 -0.55525 0 -0.735495" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9573 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555248 -0.831685 4.95723e-008 -0.735484" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3257 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195504 -0.980703 1.11311e-008 -0.735528" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.691 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195487 -0.980706 5.84547e-008 -0.735526" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.051 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555229 -0.831697 -4.9573e-008 -0.735498" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.42 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831696 -0.555231 0 -0.73549" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980712 -0.195456 0 -0.735535" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -44" album="" material="solid_bm" texgens="-1 0 0 0.499895 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -23" album="" material="solid_bm" texgens="1 0 0 0.500105 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="252" owner="0" type="0" pos="-7.5 51.5 -12" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 51.5 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 15.5" />
                            <Vertex pos="2 2 -32.5" />
                            <Vertex pos="2 -6 15.5" />
                            <Vertex pos="2 -6 -32.5" />
                            <Vertex pos="-2 2 17.5" />
                            <Vertex pos="-2 2 -32.5" />
                            <Vertex pos="-2 -6 17.5" />
                            <Vertex pos="-2 -6 -32.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -14.758" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="253" owner="0" type="0" pos="-21.5 35.5 -28.5" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 35.5 0 0 1 -28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 4 4" />
                            <Vertex pos="0 4 -16" />
                            <Vertex pos="0 2 4" />
                            <Vertex pos="0 2 -16" />
                            <Vertex pos="-6 4 4" />
                            <Vertex pos="-6 4 -16" />
                            <Vertex pos="-6 2 4" />
                            <Vertex pos="-6 2 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="254" owner="0" type="0" pos="-21.5 35.5 -8.5" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 35.5 0 0 1 -8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 4 -14" />
                            <Vertex pos="0 4 -16" />
                            <Vertex pos="-2 2 -14" />
                            <Vertex pos="0 2 -16" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-6 4 -16" />
                            <Vertex pos="-4 2 -14" />
                            <Vertex pos="-6 2 -16" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0 0.707107 11.3137" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 7.07107" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 14" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="255" owner="0" type="0" pos="-21.5 35.5 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 35.5 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 4 -14" />
                            <Vertex pos="-2 4 -16" />
                            <Vertex pos="-2 2 -14" />
                            <Vertex pos="-2 2 -16" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 4 -16" />
                            <Vertex pos="-4 2 -14" />
                            <Vertex pos="-4 2 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 14" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
