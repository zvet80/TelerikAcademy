//
//  Battery.m
//  phones
//
//  Created by z on 1/28/16.
//  Copyright © 2016 z. All rights reserved.
//

#import "Battery.h"

@implementation Battery

-(instancetype)initWithModel:(NSString *)model hoursIdle:(int)hoursIdle hoursTalk:(int)hoursTalk andBatteryType:(BatteryType*)batteryType{
    self = [super init];
    if (self) {
        self.model=model;
        self.hoursIdle=hoursIdle;
        self.hoursTalk=hoursTalk;
        self.type=batteryType;
    }
    
    return self;
}

+(Battery*)batteryWithModel:(NSString *)model hoursIdle:(int)hoursIdle hoursTalk:(int)hoursTalk andBatteryType:(BatteryType *)batteryType{
    return [[Battery alloc] initWithModel:model hoursIdle:hoursIdle hoursTalk:hoursTalk andBatteryType:batteryType];
}

-(NSString *)description{
    return [NSString stringWithFormat:@"Model: %@, Hours idle: %d, Hours talk: %d, Bttery type: %@",
            self.model,
            self.hoursIdle,
            self.hoursTalk,
            [Battery batteryTypeToString: *(self.type)]];
}

+(NSString*)batteryTypeToString:(BatteryType)enumVal{
    NSArray* batteryTypeArray=[[NSArray alloc] initWithObjects:BatteryTypeStringArray];
    return [batteryTypeArray objectAtIndex:enumVal];
}

@end
