//
//  GSMList.m
//  phones
//
//  Created by z on 1/29/16.
//  Copyright © 2016 z. All rights reserved.
//

#import "GSMList.h"
#import "GSM.h"

@implementation GSMList
NSMutableArray *phones;

+(void)seedPhones{
    GSM* nokia = [GSM gsmWithModel:@"123" andManufacturer:@"Nokia"];
    GSM* sony = [GSM gsmWithModel:@"123" andManufacturer:@"Sony"];
    GSM* iPhone = [GSM IPhone5S];
    phones = [NSMutableArray arrayWithObjects:nokia,sony, iPhone, nil];
}

@end
